using System;
using System.IO;
using Jaeger.SAT.CFDI.Services.Abstracts;
using Jaeger.SAT.CFDI.Services.Entities;
using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services {
    public class ApiManagerServices : ApiManagerServicesBase, IBase, IApiManagerServices {
        protected internal ISolicitud _Solicitud;
        protected internal IQueryResponse _SolicitudResponse;
        protected internal IVerifyResponse _VerifyResponse;
        protected internal bool _IsAutenticate = false;
        private DateTime _lastUpdateTime = DateTime.Now;

        public ApiManagerServices(ISolicitante solicitante) : base() {
            this._Token = null;
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
            this._Token = this._AutenticaService.GeneraToken();
            if (string.IsNullOrEmpty(this._Token)) {
                this._Token = null;
                this.CodeError = new CodeError(0, "Error de autenticación");
                this._IsAutenticate = false;
                this._lastUpdateTime = DateTime.Now.AddMinutes(4);
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
            //var d0 = XmlSerializerService.DeserializeObject<RespuestaSolicitudDescMasTercero>(System.IO.File.ReadAllText(@"D:\proyectos\Jaeger.SAT.Services\documentos\APITerceros\RespuestaSolicitudDescMasTercero.xml"));
            //this._SolicitudResponse = d0.ToTraslate().AddSolicitud(this._Solicitud).AddSolicitanteRFC(this.Solicitante.RFC).AddServiceProvider(this.Version);

            return this._SolicitudResponse;
        }

        public IVerifyResponse Verifica() {
            this._VerificaService = new VerificaService();
            return this._VerificaService.Test();
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
                    .AddToken(this._Token).Execute();

            return _VerifyResponse;
        }

        public void Descargar() {
            if (this._DescargaService == null) {
                this._DescargaService = new DescargaService();
                this._DescargaService.AddConfiguration(this.Configuration).AddSolicitante(this.Solicitante);
            }

            if (string.IsNullOrEmpty(this.Token)) {
                if (this.Autenticacion() == false) {
                    Console.WriteLine("No se puede autenticar");
                }
            }
            this._DescargaService.AddToken(this.Token);

            if (this._VerifyResponse != null) {
                if (this._VerifyResponse.PackagesIds != null) {
                    if (this._VerifyResponse.PackagesIds.Count > 0) {
                        Console.WriteLine(this._VerifyResponse.StatusCode.Message);
                        foreach (var item in this._VerifyResponse.PackagesIds) {
                            Stream stream = null;
                            this._DescargaService.AddIdPaquete(item);
                            var response = this._DescargaService.DescargaSolicitud(ref stream);
                            if (stream != null) {
                                IDownloadResponse d0 = new SolicitudDescarga();
                                d0.AddIdPackage(item);
                                d0.AddPath(this.ProcessFile(stream, item));
                                d0.AddStatusCode(new StatusCode(response.CodEstatus, response.Mensaje));
                            }
                        }
                    }
                }
            }
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
