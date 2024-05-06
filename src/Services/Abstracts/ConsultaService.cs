using System;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Web;
using Jaeger.SAT.API.Services.Enums;
using Jaeger.SAT.API.Services.Helpers;
using Jaeger.SAT.API.Services.Interfaces;
using Jaeger.SAT.API.WebService.Consultas;

namespace Jaeger.SAT.API.Services.Abstracts {
    /// <summary>
    /// Servicio Solicutd de Descarga Masiva
    /// </summary>
    internal abstract class ConsultaService : ServiceBase, IServiceBase, IBase, IConsultaService {
        protected internal ISolicitud _Solicitud;
        protected internal RespuestaSolicitudDescMasTercero _SolicitudDescMasTercero;

        public ConsultaService() {
            
        }

        /// <summary>
        /// Parametro obligatorio, token de autenticacion
        /// </summary>
        public IConsultaService AddToken(string token) {
            Token = token;
            return this;
        }

        /// <summary>
        /// agregar informacion de la solicitud
        /// </summary>
        /// <param name="solicitud">ISolicitud</param>
        public IConsultaService AddSolicitud(ISolicitud solicitud) {
            _Solicitud = solicitud;
            return this;
        }

        /// <summary>
        /// ejecutar consulta
        /// </summary>
        /// <returns>IQueryResponse</returns>
        public IQueryResponse Execute() {
            this.Execute(_Solicitud);
            var response = _SolicitudDescMasTercero.ToTraslate().AddSolicitud(_Solicitud).AddSolicitanteRFC(Solicitante.RFC);
            return response;
        }

        public RespuestaSolicitudDescMasTercero Execute(ISolicitud solicitud) {
            Execute(CrearSolicitud(solicitud));
            return _SolicitudDescMasTercero;
        }

        public RespuestaSolicitudDescMasTercero Execute(SolicitudDescargaMasivaTercero request) {
            try {
                var descargaServiceClient = new SolicitaDescargaServiceClient(GetBinding(), GetEndpointAddress());

                using (new OperationContextScope(descargaServiceClient.InnerChannel)) {
                    var requestMessageProperty = new HttpRequestMessageProperty();
                    requestMessageProperty.Headers["Authorization"] = "WRAP access_token=\"" + HttpUtility.UrlDecode(Token) + "\"";
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessageProperty;
                    // serializar peticion
                    var xmlRequest = XmlSerializerService.SerializeObject(request);
                    LogInfoService.Log("[Genera Consulta (Peticiones)] Request: ", xmlRequest);
                    _SolicitudDescMasTercero = descargaServiceClient.SolicitaDescarga(request);
                }
                var xmlResponse = XmlSerializerService.SerializeObject(_SolicitudDescMasTercero);
                LogInfoService.Log("[Genera Consulta (Peticiones)] Response: ", xmlResponse);
            } catch (Exception ex) {
                LogErrorService.Log("[Genera Consulta (Peticiones)] Error: " + ex.Message, ex.StackTrace);
            }
            return _SolicitudDescMasTercero;
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
                RfcSolicitante = Solicitante.RFC,
            };

            if (solicitud.TipoConsulta == TipoConsultaEnum.Emitidos) {
                response.RfcEmisor = Solicitante.RFC;
            } else {
                response.RfcReceptores = new string[] { Solicitante.RFC };
            }

            // tipo de descarga
            // CFDI- descarga de comprobantes,
            // Metadata- solo informacion general de los comprobantes seleccionados.
            if (solicitud.Tipo == TipoDescargaEnum.CFDI) {
                response.TipoSolicitud = TipoDescargaMasivaTerceros.CFDI;
            } else if (solicitud.Tipo == TipoDescargaEnum.Metadata) {
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
            if (solicitud.Estado == EstadoComprobanteEnum.Todos) {
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
            LogInfoService.Log("[Crear Solicitud]", XmlSerializerService.SerializeObject(response));
            return response;
        }
    }
}
