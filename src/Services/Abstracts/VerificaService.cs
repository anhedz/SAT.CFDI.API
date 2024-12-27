using System;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Web;
using Jaeger.SAT.API.Services.Helpers;
using Jaeger.SAT.API.Services.Interfaces;
using Jaeger.SAT.API.WebService.Verificacion;
using Jaeger.SAT.API.Services.Entities;

namespace Jaeger.SAT.API.Services.Abstracts {
    /// <summary>
    /// Servicio de Verificacion de Solicitud de Descarga
    /// </summary>
    internal abstract class VerificaService : ServiceBase, IServiceBase, IBase, IVerificaService {
        protected internal string _IdSolicitud;
        protected internal RespuestaVerificaSolicitudDescMasTercero _SolicitudDescMasTercero;

        public VerificaService() {
            
        }

        /// <summary>
        /// Agregar token de autenticacion
        /// </summary>
        public IVerificaService AddToken(string token) {
            Token = token;
            return this;
        }

        /// <summary>
        /// Agregar Id de Solicitud a verificar
        /// </summary>
        public IVerificaService AddIdSolicitud(string idSolicitud) {
            _IdSolicitud = idSolicitud;
            return this;
        }

        public IVerifyResponse Test() {
            _SolicitudDescMasTercero = XmlSerializerService.DeserializeObject<RespuestaVerificaSolicitudDescMasTercero>(System.IO.File.ReadAllText(@"D:\proyectos\Jaeger.SAT.Services\documentos\APITerceros\RespuestaVerificaSolicitudDescMasTercero_.xml"));
            var VerifyResponse = new VerifyResponse()
                .AddStatusCode(new StatusCode(_SolicitudDescMasTercero.CodEstatus, _SolicitudDescMasTercero.Mensaje))
                .AddStatusRequest(new StatusRequest(_SolicitudDescMasTercero.EstadoSolicitud))
                .AddCodeRequest(new CodeRequest(_SolicitudDescMasTercero.CodigoEstadoSolicitud))
                .AddXML(XmlSerializerService.SerializeObject(_SolicitudDescMasTercero))
                .AddNumnberCFDIs(_SolicitudDescMasTercero.NumeroCFDIs);

            if (_SolicitudDescMasTercero.IdsPaquetes != null) {
                VerifyResponse.AddPackagesIds(_SolicitudDescMasTercero.IdsPaquetes.ToList());
            }

            return VerifyResponse;
        }

        /// <summary>
        /// Ejecutar 
        /// </summary>
        public IVerifyResponse Execute() {
            this._SolicitudDescMasTercero = this.VerificaSolicitud();
            var VerifyResponse = new VerifyResponse()
                .AddStatusCode(new StatusCode(_SolicitudDescMasTercero.CodEstatus, _SolicitudDescMasTercero.Mensaje))
                .AddStatusRequest(new StatusRequest(_SolicitudDescMasTercero.EstadoSolicitud))
                .AddCodeRequest(new CodeRequest(_SolicitudDescMasTercero.CodigoEstadoSolicitud))
                .AddXML(XmlSerializerService.SerializeObject(_SolicitudDescMasTercero))
                .AddNumnberCFDIs(_SolicitudDescMasTercero.NumeroCFDIs);

            if (_SolicitudDescMasTercero.IdsPaquetes != null) {
                VerifyResponse.AddPackagesIds(_SolicitudDescMasTercero.IdsPaquetes.ToList());
            }

            return VerifyResponse;
        }

        public RespuestaVerificaSolicitudDescMasTercero GetResponse {
            get { return _SolicitudDescMasTercero; }
        }

        internal RespuestaVerificaSolicitudDescMasTercero VerificaSolicitud() {
            _SolicitudDescMasTercero = new RespuestaVerificaSolicitudDescMasTercero();
            try {
                var descargaServiceClient = new VerificaSolicitudDescargaServiceClient(GetBinding(), GetEndpointAddress());
                using (new OperationContextScope(descargaServiceClient.InnerChannel)) {
                    HttpRequestMessageProperty requestMessageProperty = new HttpRequestMessageProperty();
                    requestMessageProperty.Headers["Authorization"] = "WRAP access_token=\"" + HttpUtility.UrlDecode(Token) + "\"";
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessageProperty;
                    _SolicitudDescMasTercero = descargaServiceClient.VerificaSolicitudDescarga(Request());
                }
                var outXML = XmlSerializerService.SerializeObject(_SolicitudDescMasTercero);
                LogInfoService.Log($"[Verifica Descarga (Response)]: IdSolicitud {_IdSolicitud}", outXML);
            } catch (Exception ex) {
                LogErrorService.Log("[Verifica Descarga (Request)] Error: " + ex.Message, ex.StackTrace);
            }
            return _SolicitudDescMasTercero;
        }

        internal VerificaSolicitudDescargaMasivaTercero Request() {
            var request = new VerificaSolicitudDescargaMasivaTercero() {
                IdSolicitud = _IdSolicitud,
                RfcSolicitante = Solicitante.RFC,
                Signature = new Signer().AddBytes(Solicitante.GetBytes()).AddPassword(Solicitante.PasswordKey).Build()
            };
            LogInfoService.Log("[Verifica Descarga (Request)]", XmlSerializerService.SerializeObject(request));
            return request;
        }
    }
}
