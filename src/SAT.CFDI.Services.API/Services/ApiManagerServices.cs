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
        protected internal DateTime _lastUpdateTime = DateTime.Now;
        #endregion

        public ApiManagerServices(ISolicitante solicitante) : base() {
            this.Token = null;
            this.Solicitante = solicitante;
            this._IsAutenticate = false;
            this._AutenticaService = new AutenticaService();
            this._AutenticaService.AddConfiguration(this.Configuration).AddSolicitante(solicitante);
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
                if (!(this._lastUpdateTime > DateTime.Now)) {
                    this.CodeError = new CodeError(0, "Token expirado");
                    LogErrorService.EscribirLog("Token expirado", this._lastUpdateTime.ToString("dd-MM-yyyyThh:mm:ss"));
                } else {
                    return true;
                }
            }

            this.Token = this._AutenticaService.GeneraToken();
            this._lastUpdateTime = DateTime.Now.AddMinutes(4);
            LogErrorService.EscribirLog("Token expira en: ", this._lastUpdateTime.ToString("dd-MM-yyyyThh:mm:ss"));
            if (string.IsNullOrEmpty(this.Token)) {
                this.Token = null;
                this.CodeError = new CodeError(0, "Error de autenticación");
                LogErrorService.EscribirLog("Error de autenticación", this._lastUpdateTime.ToString("dd-MM-yyyyThh:mm:ss"));
                this._IsAutenticate = false;
                return false;
            }

            this._IsAutenticate = true;

            return true;
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
                LogErrorService.EscribirLog("No se puede autenticar", "");
                return null;
            }

            this._DescargaService.AddToken(this.Token);

            if (this._VerifyResponse != null) {
                if (this._VerifyResponse.PackagesIds != null) {
                    if (this._VerifyResponse.PackagesIds.Count > 0) {
                        Console.WriteLine(this._VerifyResponse.StatusCode.Message);
                        foreach (var item in this._VerifyResponse.PackagesIds) {
                            Stream stream = null;
                            this._DescargaService.AddIdPaquete(item);
                            var response = this._DescargaService.Execute(ref stream);
                            if (stream != null) {
                                IDownloadResponse d0 = new SolicitudDescarga().AddIdPackage(item)
                                .AddPath(this.ProcessFile(stream, item))
                                .AddStatusCode(new StatusCode(response.CodEstatus, response.Mensaje));
                                this._VerifyResponse.AddPackage(d0);
                            }
                        }
                    }
                }
            }
            return this._VerifyResponse;
        }

        internal string ProcessFile(Stream package, string fileName) {
            if (!Directory.Exists(this.Configuration.PathDownload)) {
                Directory.CreateDirectory(this.Configuration.PathDownload);
            }
            var filezip = Path.Combine(this.Configuration.PathDownload, fileName + ".zip");
            using (FileStream fileStream = File.Create(filezip)) {
                package.CopyTo(fileStream);
                fileStream.Close();
            }
            return filezip;
        }
    }
}
