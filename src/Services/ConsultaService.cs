using System;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Web;
using Jaeger.SAT.CFDI.Services.Abstracts;
using Jaeger.SAT.CFDI.Services.API.Consultas;
using Jaeger.SAT.CFDI.Services.Interfaces;
using Jaeger.SAT.CFDI.Helpers;
using Jaeger.SAT.CFDI.Services.Helpers;

namespace Jaeger.SAT.CFDI.Services {
    /// <summary>
    /// Servicio Solicutd de Descarga Masiva
    /// </summary>
    public class ConsultaService : ServiceBase, IServiceBase, IBase, IConsultaService {
        protected internal ISolicitud _Solicitud;
        protected internal RespuestaSolicitudDescMasTercero _SolicitudDescMasTercero;

        public ConsultaService() {
            this.AddURL("https://cfdidescargamasivasolicitud.clouda.sat.gob.mx/SolicitaDescargaService.svc");
        }

        /// <summary>
        /// Parametro obligatorio, token de autenticacion
        /// </summary>
        public IConsultaService AddToken(string token) {
            this.Token = token;
            return this;
        }

        /// <summary>
        /// agregar informacion de la solicitud
        /// </summary>
        /// <param name="solicitud">ISolicitud</param>
        public IConsultaService AddSolicitud(ISolicitud solicitud) {
            this._Solicitud = solicitud;
            return this;
        }

        /// <summary>
        /// ejecutar consulta
        /// </summary>
        /// <returns>IQueryResponse</returns>
        public IQueryResponse Execute() {
            this.Execute(this._Solicitud);
            var response = this._SolicitudDescMasTercero.ToTraslate().AddSolicitud(this._Solicitud).AddSolicitanteRFC(this.Solicitante.RFC);
            return response;
        }

        public RespuestaSolicitudDescMasTercero Execute(ISolicitud solicitud) {
            this.Execute(this.CrearSolicitud(solicitud));
            return this._SolicitudDescMasTercero;
        }

        public RespuestaSolicitudDescMasTercero Execute(SolicitudDescargaMasivaTercero request) {
            try {
                var descargaServiceClient = new SolicitaDescargaServiceClient(GetBinding(), GetEndpointAddress());

                using (new OperationContextScope(descargaServiceClient.InnerChannel)) {
                    var requestMessageProperty = new HttpRequestMessageProperty();
                    requestMessageProperty.Headers["Authorization"] = "WRAP access_token=\"" + HttpUtility.UrlDecode(this.Token) + "\"";
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessageProperty;
                    // serializar peticion
                    var xmlRequest = XmlSerializerService.SerializeObject(request);
                    LogInfoService.Write("[Genera Consulta (Peticiones)] Request: " + xmlRequest, "<-----");
                    this._SolicitudDescMasTercero = descargaServiceClient.SolicitaDescarga(request);
                }
                var xmlResponse = XmlSerializerService.SerializeObject(this._SolicitudDescMasTercero);
                LogErrorService.EscribirLog("[Genera Consulta (Peticiones)] Response: \r\n" + xmlResponse, "<-----");
            } catch (Exception ex) {
                LogErrorService.EscribirLog("[Genera Consulta (Peticiones)] Error: " + ex.Message, ex.StackTrace);
            }
            return this._SolicitudDescMasTercero;
        }

        /// <summary>
        /// crear solicitud de peticion del servicio 
        /// </summary>
        /// <param name="solicitud"></param>
        /// <returns>SolicitudDescargaMasivaTercero</returns>
        internal SolicitudDescargaMasivaTercero CrearSolicitud(ISolicitud solicitud) {
            var response = new SolicitudDescargaMasivaTercero {
                FechaInicial = solicitud.FechaInicial,
                FechaInicialSpecified = true,
                FechaFinal = solicitud.FechaFinal,
                FechaFinalSpecified = true,
                RfcSolicitante = this.Solicitante.RFC,
            };

            if (solicitud.TipoConsulta == Enums.TipoConsultaEnum.Emitidos) {
                response.RfcEmisor = this.Solicitante.RFC;
            }
            else {
                response.RfcReceptores = new string[] { this.Solicitante.RFC };
            }

            // tipo de descarga
            // CFDI- descarga de comprobantes,
            // Metadata- solo informacion general de los comprobantes seleccionados.
            if (solicitud.Tipo == Enums.TipoDescargaEnum.CFDI) {
                response.TipoSolicitud = TipoDescargaMasivaTerceros.CFDI;
            }
            else if (solicitud.Tipo == Enums.TipoDescargaEnum.Metadata) {
                response.TipoSolicitud = TipoDescargaMasivaTerceros.Metadata;
            }

            // en el caso de realiza una consulta por folio fiscal el paramatro
            // RfcEmisor y RfcSolicitane no debe declararse
            if (!string.IsNullOrEmpty(solicitud.UUID)) {
                response.RfcEmisor = null;
                response.RfcSolicitante = null;
                response.FechaInicialSpecified = false;
                response.FechaFinalSpecified = false;
            }

            // en el caso del estado de comprobante Todos debemos omitir la especificacion
            // del estado
            if (solicitud.Estado == Enums.EstadoComprobanteEnum.Todos) {
                response.EstadoComprobanteSpecified = false;
            }

            if (solicitud.TipoDeComprobante == Enums.TipoDeComprobante.Todos) {
                response.TipoComprobanteSpecified = false;
            }

            if (string.IsNullOrEmpty(solicitud.RfcACuentaTerceros)) {
                response.RfcACuentaTerceros = null;
            }

            // en caso de no declarar un complemento se obtendran todos los comprobantes sin
            // importar el complemento asociado a los comprobantes
            if (string.IsNullOrEmpty(solicitud.Complemento)) {
                response.Complemento = null;
            }
            response.Signature = CreateDigest();
            return response;
        }
    }
}
