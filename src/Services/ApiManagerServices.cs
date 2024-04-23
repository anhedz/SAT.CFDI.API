using System;
using System.IO;
using Jaeger.SAT.CFDI.Services.Abstracts;
using Jaeger.SAT.CFDI.Services.Entities;
using Jaeger.SAT.CFDI.Services.Helpers;
using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services {
    public class ApiManagerServices : ApiManagerServicesBase, IBase, IApiManagerServices {
        #region declaraciones
        protected internal ISolicitud _Solicitud;
        protected internal IQueryResponse _SolicitudResponse;
        protected internal IVerifyResponse _VerifyResponse;
        protected internal bool _IsAutenticate = false;
        protected internal DateTime _LastUpdateTime = DateTime.Now;
        #endregion

        public ApiManagerServices(ISolicitante solicitante) : base() {
            this.Token = null;
            this.Solicitante = solicitante;
            this._IsAutenticate = false;
            this._AutenticaService = new AutenticaService();
            this._AutenticaService.AddConfiguration(this.Configuration).AddSolicitante(solicitante);
            this._LastUpdateTime = DateTime.Now;
        }

        public ISolicitud Solicitud {
            get { return this._Solicitud; }
        }

        public IApiManagerServices AddSolicitud(ISolicitud solicitud) {
            this._Solicitud = solicitud;
            return this;
        }

        public bool Autenticacion() {
            if (!string.IsNullOrEmpty(this.Token)) {
                if (!(this._LastUpdateTime > DateTime.Now)) {
                    this.CodeError = new CodeError(0, "Token expirado");
                    LogErrorService.Write("Token expirado", this._LastUpdateTime.ToString("dd-MM-yyyyThh:mm:ss"));
                } else {
                    return true;
                }
            }

            this.Token = this._AutenticaService.GeneraToken();
            this._LastUpdateTime = DateTime.Now.AddMinutes(4);
            LogErrorService.Write("Token expira en: " + this._LastUpdateTime.ToString("dd-MM-yyyyThh:mm:ss"), "Autenticacion");
            if (string.IsNullOrEmpty(this.Token)) {
                this.Token = null;
                this.CodeError = new CodeError(0, "Error de autenticación");
                LogErrorService.Write("Error de autenticación", this._LastUpdateTime.ToString("dd-MM-yyyyThh:mm:ss"));
                this._IsAutenticate = false;
                return false;
            }

            this._IsAutenticate = true;

            return this._IsAutenticate;
        }

        public IQueryResponse Consulta() {
            if (this._ConsultaService == null) {
                this._ConsultaService = new ConsultaService();
                this._ConsultaService.AddConfiguration(this.Configuration).AddSolicitante(this.Solicitante);
            }

            if (string.IsNullOrEmpty(this.Token)) {
                if (this.Autenticacion() == false) {
                    this.CodeError = new CodeError(0, "Error de autenticación");
                }
            }
            this._SolicitudResponse = this._ConsultaService
                .AddToken(this.Token)
                .AddSolicitud(this._Solicitud).Execute();

            return this._SolicitudResponse;
        }

        public IVerifyResponse Verifica() {
            if (this._VerificaService == null) {
                this._VerificaService = new VerificaService();
                this._VerificaService.AddConfiguration(this.Configuration).AddSolicitante(this.Solicitante);
            }

            if (string.IsNullOrEmpty(this.Token)) {
                if (this.Autenticacion() == false) {
                    LogErrorService.Write("No se puede autenticar", "");
                    Console.WriteLine("No se puede autenticar");
                }
            }

            this._VerifyResponse = this._VerificaService
                    .AddIdSolicitud(this._Solicitud.IdSolicitud)
                    .AddToken(this.Token).Execute();

            return this._VerifyResponse;
        }

        public IVerifyResponse Descargar() {
            if (this._DescargaService == null) {
                this._DescargaService = new DescargaService();
                this._DescargaService.AddConfiguration(this.Configuration).AddSolicitante(this.Solicitante);
            }

            if (this.Autenticacion() == false) {
                Console.WriteLine("No se puede autenticar");
                LogErrorService.Write("No se puede autenticar", "");
                return null;
            }

            this._DescargaService.AddToken(this.Token);

            if (this._VerifyResponse != null) {
                if (this._VerifyResponse.PackagesIds != null) {
                    if (this._VerifyResponse.PackagesIds.Count > 0) {
                        Console.WriteLine(this._VerifyResponse.StatusCode.ToString());
                        LogErrorService.Write(this._VerifyResponse.StatusCode.Message, "");

                        foreach (var package in this._VerifyResponse.PackagesIds) {
                            Stream stream = null;
                            this._DescargaService.AddIdPaquete(package);
                            var responseDescarga = this._DescargaService.Execute(ref stream);
                            IDownloadResponse downloadResponse = new SolicitudDescarga()
                                            .AddIdPackage(package)
                                            .AddStatusCode(new StatusCode(responseDescarga.CodEstatus, responseDescarga.Mensaje));

                            Console.WriteLine(responseDescarga.ToString());
                            LogErrorService.Write(responseDescarga.Mensaje, responseDescarga.CodEstatus);

                            var pathZip = package;
                            // si 
                            if (responseDescarga.CodEstatus != "5008") {
                                pathZip = this.ProcessFile(stream, package);
                            } else {
                                LogErrorService.Write($"No se pudo descargar el paquete: {package}", "APIManager-Descargar");
                            }

                            downloadResponse.AddPath(pathZip);

                            // agregar paquete
                            this._VerifyResponse.AddPackage(downloadResponse);
                            // necesito cambiar la respuesta
                        }
                    }
                }
            }
            return this._VerifyResponse;
        }

        internal string ProcessFile(Stream package, string fileName) {
            // si el directorio no existe lo creamos
            if (!Directory.Exists(this.Configuration.PathDownload)) {
                Directory.CreateDirectory(this.Configuration.PathDownload);
            }
            try {
                // nombre a asignar al nuevo archivo
                var filezip = Path.Combine(this.Configuration.PathDownload, fileName + ".zip");
                // si existe entonces hacemos un backup del archivo existente para no eliminar
                if (File.Exists(filezip)) {
                    var renamefilezip = Path.Combine(this.Configuration.PathDownload, fileName + "_back_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".zip");
                    File.Copy(filezip, renamefilezip);
                }
                // si por alguna razon el archivo esta en uso, creamos uno diferente para no perder la descarga
                if (FileService.IsFileinUse(filezip)) {
                    filezip = Path.Combine(this.Configuration.PathDownload, fileName + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".zip");
                }

                using (FileStream fileStream = File.Create(filezip)) {
                    package.CopyTo(fileStream);
                    fileStream.Close();
                }
                return filezip;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                LogErrorService.Write(ex.Message, ex.StackTrace);
            }
            return string.Empty;
        }
    }
}
