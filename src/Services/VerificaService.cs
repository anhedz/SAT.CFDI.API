using System;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Web;
using Jaeger.SAT.CFDI.Services.Abstracts;
using Jaeger.SAT.CFDI.Services.API.Verificacion;
using Jaeger.SAT.CFDI.Services.Interfaces;
using Jaeger.SAT.CFDI.Services.Helpers;
using Jaeger.SAT.CFDI.Services.Entities;

namespace Jaeger.SAT.CFDI.Services {
    public class VerificaService : ServiceBase, IServiceBase, IBase, IVerificaService {
        protected internal string _IdSolicitud;
        protected internal RespuestaVerificaSolicitudDescMasTercero _SolicitudDescMasTercero;

        public VerificaService() {
            this.AddURL("https://cfdidescargamasivasolicitud.clouda.sat.gob.mx/VerificaSolicitudDescargaService.svc");
        }

        public IVerificaService AddToken(string token) {
            this.Token = token;
            return this;
        }

        public IVerificaService AddIdSolicitud(string idSolicitud) {
            this._IdSolicitud = idSolicitud;
            return this;
        }

        public IVerifyResponse Test() {
            this._SolicitudDescMasTercero = XmlSerializerService.DeserializeObject<RespuestaVerificaSolicitudDescMasTercero>(System.IO.File.ReadAllText(@"D:\proyectos\Jaeger.SAT.Services\documentos\APITerceros\RespuestaVerificaSolicitudDescMasTercero_.xml"));
            var VerifyResponse = new VerifyResponse()
                .AddStatusCode(new StatusCode(this._SolicitudDescMasTercero.CodEstatus, this._SolicitudDescMasTercero.Mensaje))
                .AddStatusRequest(new StatusRequest(this._SolicitudDescMasTercero.EstadoSolicitud))
                .AddCodeRequest(new CodeRequest(this._SolicitudDescMasTercero.CodigoEstadoSolicitud))
                .AddXML(XmlSerializerService.SerializeObject(this._SolicitudDescMasTercero))
                .AddNumnberCFDIs(this._SolicitudDescMasTercero.NumeroCFDIs);

            if (this._SolicitudDescMasTercero.IdsPaquetes != null) {
                VerifyResponse.AddPackagesIds(this._SolicitudDescMasTercero.IdsPaquetes.ToList());
            }

            return VerifyResponse;
        }

        public IVerifyResponse Execute() {
            this._SolicitudDescMasTercero = this.VerificaSolicitud();
            var VerifyResponse = new VerifyResponse()
                .AddStatusCode(new StatusCode(this._SolicitudDescMasTercero.CodEstatus, this._SolicitudDescMasTercero.Mensaje))
                .AddStatusRequest(new StatusRequest(this._SolicitudDescMasTercero.EstadoSolicitud))
                .AddCodeRequest(new CodeRequest(this._SolicitudDescMasTercero.CodigoEstadoSolicitud))
                .AddXML(XmlSerializerService.SerializeObject(this._SolicitudDescMasTercero));

            if (this._SolicitudDescMasTercero.IdsPaquetes != null) {
                VerifyResponse.AddPackagesIds(this._SolicitudDescMasTercero.IdsPaquetes.ToList());
            }

            return VerifyResponse;
        }

        public RespuestaVerificaSolicitudDescMasTercero GetResponse {
            get { return this._SolicitudDescMasTercero; }
        }

        internal RespuestaVerificaSolicitudDescMasTercero VerificaSolicitud() {
            this._SolicitudDescMasTercero = new RespuestaVerificaSolicitudDescMasTercero();
            try {
                var descargaServiceClient = new VerificaSolicitudDescargaServiceClient(GetBinding(), GetEndpointAddress());
                using (new OperationContextScope(descargaServiceClient.InnerChannel)) {
                    HttpRequestMessageProperty requestMessageProperty = new HttpRequestMessageProperty();
                    requestMessageProperty.Headers["Authorization"] = "WRAP access_token=\"" + HttpUtility.UrlDecode(Token) + "\"";
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessageProperty;
                    _SolicitudDescMasTercero = descargaServiceClient.VerificaSolicitudDescarga(this.Request());
                }
                var salida = XmlSerializerService.SerializeObject(_SolicitudDescMasTercero);
                LogErrorService.EscribirLog("[Verifica Consulta (Peticiones)] Error: " + salida, "<-");
                Console.WriteLine(salida);
            }
            catch (Exception ex) {
                LogErrorService.EscribirLog("[Verifica Consulta (Peticiones)] Error: " + ex.Message, ex.StackTrace);
            }
            return _SolicitudDescMasTercero;
        }

        internal VerificaSolicitudDescargaMasivaTercero Request() {
            return new VerificaSolicitudDescargaMasivaTercero() {
                IdSolicitud = _IdSolicitud,
                RfcSolicitante = this.Solicitante.RFC,
                Signature = CreateDigest()
            };
        }
    }
}
