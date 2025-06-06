using System;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Web;
using Jaeger.SAT.API.Services.Enums;
using Jaeger.SAT.API.Services.Helpers;
using Jaeger.SAT.API.Services.Interfaces;
using Jaeger.SAT.API.WebService.Solicitud;

namespace Jaeger.SAT.API.Services.Abstracts {
    public class SolicitudService : ServiceBase, IServiceBase, IBase, IConsultaService {
        #region
        protected internal ISolicitud _Solicitud;
        protected internal RespuestaSolicitudDescMasTercero _RespuestaSolicitudDescTercero;
        #endregion

        /// <summary>
        /// constructor
        /// </summary>
        public SolicitudService() { }

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
            var response = _RespuestaSolicitudDescTercero.ToTraslate().AddSolicitud(_Solicitud).AddSolicitanteRFC(Solicitante.RFC);
            return response;
        }

        /// <summary>
        /// ejecutar consulta
        /// </summary>
        /// <returns>IQueryResponse</returns>
        public RespuestaSolicitudDescMasTercero Execute(ISolicitud solicitud) {
            if (solicitud.TipoConsulta == TipoConsultaEnum.Emitidos) {
                _RespuestaSolicitudDescTercero = this.Execute(CrearSolicitudEmitidos(solicitud));
            } else if (solicitud.TipoConsulta == TipoConsultaEnum.Recibidos) {
                _RespuestaSolicitudDescTercero = this.Execute(CrearSolicitudRecibidos(solicitud));
            } else if (solicitud.TipoConsulta == TipoConsultaEnum.Folio) {
                _RespuestaSolicitudDescTercero = this.Execute(CrearSolicitudFolio(solicitud));
            }
            return _RespuestaSolicitudDescTercero;
        }

        public RespuestaSolicitudDescMasTercero Execute(SolicitudDescargaMasivaTerceroEmitidos request) {
            try {
                var descargaServiceClient = new SolicitaDescargaServiceClient(GetBinding(), GetEndpointAddress());

                using (new OperationContextScope(descargaServiceClient.InnerChannel)) {
                    var requestMessageProperty = new HttpRequestMessageProperty();
                    requestMessageProperty.Headers["Authorization"] = "WRAP access_token=\"" + HttpUtility.UrlDecode(Token) + "\"";
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessageProperty;
                    // serializar peticion
                    var xmlRequest = XmlSerializerService.SerializeObject(request);
                    LogInfoService.Log("[Genera Solicitud (Peticiones)] Request: ", xmlRequest);
                    _RespuestaSolicitudDescTercero = descargaServiceClient.SolicitaDescargaEmitidos(request);
                }
                var xmlResponse = XmlSerializerService.SerializeObject(_RespuestaSolicitudDescTercero);
                LogInfoService.Log("[Genera Solicitud (Peticiones)] Response: ", xmlResponse);
            } catch (Exception ex) {
                LogErrorService.Log("[Genera Solicitud (Peticiones)] Error: " + ex.Message, ex.StackTrace);
            }
            return _RespuestaSolicitudDescTercero;
        }

        public RespuestaSolicitudDescMasTercero Execute(SolicitudDescargaMasivaTerceroFolio request) {
            try {
                var descargaServiceClient = new SolicitaDescargaServiceClient(GetBinding(), GetEndpointAddress());

                using (new OperationContextScope(descargaServiceClient.InnerChannel)) {
                    var requestMessageProperty = new HttpRequestMessageProperty();
                    requestMessageProperty.Headers["Authorization"] = "WRAP access_token=\"" + HttpUtility.UrlDecode(Token) + "\"";
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessageProperty;
                    // serializar peticion
                    var xmlRequest = XmlSerializerService.SerializeObject(request);
                    LogInfoService.Log("[Genera Solicitud (Peticiones)] Request: ", xmlRequest);
                    _RespuestaSolicitudDescTercero = descargaServiceClient.SolicitaDescargaFolio(request);
                }
                var xmlResponse = XmlSerializerService.SerializeObject(_RespuestaSolicitudDescTercero);
                LogInfoService.Log("[Genera Solicitud (Peticiones)] Response: ", xmlResponse);
            } catch (Exception ex) {
                LogErrorService.Log("[Genera Solicitud (Peticiones)] Error: " + ex.Message, ex.StackTrace);
            }
            return _RespuestaSolicitudDescTercero;
        }

        public RespuestaSolicitudDescMasTercero Execute(SolicitudDescargaMasivaTerceroRecibidos request) {
            try {
                var descargaServiceClient = new SolicitaDescargaServiceClient(GetBinding(), GetEndpointAddress());

                using (new OperationContextScope(descargaServiceClient.InnerChannel)) {
                    var requestMessageProperty = new HttpRequestMessageProperty();
                    requestMessageProperty.Headers["Authorization"] = "WRAP access_token=\"" + HttpUtility.UrlDecode(Token) + "\"";
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessageProperty;
                    // serializar peticion
                    var xmlRequest = XmlSerializerService.SerializeObject(request);
                    LogInfoService.Log("[Genera Solicitud (Peticiones)] Request: ", xmlRequest);
                    _RespuestaSolicitudDescTercero = descargaServiceClient.SolicitaDescargaRecibidos(request);
                }
                var xmlResponse = XmlSerializerService.SerializeObject(_RespuestaSolicitudDescTercero);
                LogInfoService.Log("[Genera Solicitud (Peticiones)] Response: ", xmlResponse);
            } catch (Exception ex) {
                LogErrorService.Log("[Genera Solicitud (Peticiones)] Error: " + ex.Message, ex.StackTrace);
            }
            return _RespuestaSolicitudDescTercero;
        }

        /// <summary>
        /// crear solicitud de peticion del servicio 
        /// </summary>
        /// <param name="solicitud">objeto Solicitud</param>
        /// <returns>SolicitudDescargaMasivaTercero</returns>
        internal SolicitudDescargaMasivaTerceroEmitidos CrearSolicitudEmitidos(ISolicitud solicitud) {
            var response = new SolicitudDescargaMasivaTerceroEmitidos {
                FechaInicial = solicitud.FechaInicial,
                FechaFinal = solicitud.FechaFinal,
                RfcSolicitante = Solicitante.RFC,
                RfcEmisor = Solicitante.RFC
            };

            //Contiene el/los RFC’s receptores de los cuales se quiere consultar los CFDIs
            //Importante: El campo RfcReceptor, únicamente permite la captura de 5 registros como máximo.
            if (solicitud.ReceptorRFC != null) {
                response.RfcReceptores = new string[] { solicitud.ReceptorRFC };
            }

            // tipo de descarga
            // CFDI- descarga de comprobantes,
            // Metadata- solo informacion general de los comprobantes seleccionados.
            response.TipoSolicitud = this.GetTipoSolicitud(solicitud.Tipo);

            // en el caso del estado de comprobante Todos debemos omitir la especificacion
            // del estado
            response.EstadoComprobante = this.GetEstadoComprobante(solicitud.Estado);

            response.TipoComprobante = this.GetTipoDeComprobante(solicitud.TipoDeComprobante);

            response.RfcACuentaTerceros = this.GetRfcACuentaTerceros(solicitud.RfcACuentaTerceros);

            // en caso de no declarar un complemento se obtendran todos los comprobantes sin
            // importar el complemento asociado a los comprobantes
            response.Complemento = this.GetComplemento(solicitud.Complemento);

            response.Signature = CreateDigest();
            LogInfoService.Log("[Crear Solicitud]", XmlSerializerService.SerializeObject(response));
            return response;
        }

        /// <summary>
        /// crear solicitud de peticion del servicio 
        /// </summary>
        /// <param name="solicitud">objeto Solicitud</param>
        /// <returns>SolicitudDescargaMasivaTercero</returns>
        internal SolicitudDescargaMasivaTerceroRecibidos CrearSolicitudRecibidos(ISolicitud solicitud) {
            var response = new SolicitudDescargaMasivaTerceroRecibidos {
                FechaInicial = solicitud.FechaInicial,
                FechaFinal = solicitud.FechaFinal,
                RfcSolicitante = Solicitante.RFC,
                RfcReceptor = Solicitante.RFC
            };

            // en el caso de los comprobantes recibidos podemos especificar el RFC del emisor
            if (solicitud.ReceptorRFC != null) {
                response.RfcEmisor = solicitud.ReceptorRFC;
            }

            // tipo de descarga
            // CFDI- descarga de comprobantes,
            // Metadata- solo informacion general de los comprobantes seleccionados.
            response.TipoSolicitud = this.GetTipoSolicitud(solicitud.Tipo);

            // en el caso del estado de comprobante Todos debemos omitir la especificacion
            // del estado
            response.EstadoComprobante = this.GetEstadoComprobante(solicitud.Estado);

            response.TipoComprobante = this.GetTipoDeComprobante(solicitud.TipoDeComprobante);

            response.RfcACuentaTerceros = this.GetRfcACuentaTerceros(solicitud.RfcACuentaTerceros);

            // en caso de no declarar un complemento se obtendran todos los comprobantes sin
            // importar el complemento asociado a los comprobantes
            response.Complemento = this.GetComplemento(solicitud.Complemento);

            response.Signature = CreateDigest();
            LogInfoService.Log("[Crear Solicitud]", XmlSerializerService.SerializeObject(response));
            return response;
        }

        internal SolicitudDescargaMasivaTerceroFolio CrearSolicitudFolio(ISolicitud solicitud) {
            var response = new SolicitudDescargaMasivaTerceroFolio {
                RfcSolicitante = Solicitante.RFC,
                Folio = solicitud.UUID,
                Signature = CreateDigest()
            };
            LogInfoService.Log("[Crear Solicitud]", XmlSerializerService.SerializeObject(response));
            return response;
        }

        #region metodos privados
        internal string GetTipoDeComprobante(TipoDeComprobante tipoDeComprobante) {
            switch (tipoDeComprobante) {
                case TipoDeComprobante.Ingreso:
                    return "I";
                case TipoDeComprobante.Egreso:
                    return "E";
                case TipoDeComprobante.Traslado:
                    return "T";
                case TipoDeComprobante.Nomina:
                    return "N";
                case TipoDeComprobante.Pagos:
                    return "P";
                default:
                    return null;
            }
        }

        internal string GetEstadoComprobante(EstadoComprobanteEnum estado) {
            // es un dato opcional pero debemos especificar "Todos" para que se incluyan los cancelados,
            // si no se especifica se considera Vigente como valor por defecto
            switch (estado) {
                case EstadoComprobanteEnum.Todos:
                    return "Todos"; 
                case EstadoComprobanteEnum.Vigente:
                    return "Vigente";
                case EstadoComprobanteEnum.Cancelado:
                    return "Cancelado";
                default:
                    return null;
            }
        }

        // tipo de descarga
        // CFDI- descarga de comprobantes,
        // Metadata- solo informacion general de los comprobantes seleccionados.
        internal TipoDescargaMasivaTerceros GetTipoSolicitud(TipoDescargaEnum tipo) {
            switch (tipo) {
                case TipoDescargaEnum.CFDI:
                    return TipoDescargaMasivaTerceros.CFDI;
                case TipoDescargaEnum.Metadata:
                    return TipoDescargaMasivaTerceros.Metadata;
                default:
                    return TipoDescargaMasivaTerceros.CFDI; // Default to CFDI if not specified
            }
        }

        internal string GetRfcACuentaTerceros(string rfcACuentaTerceros) {
            return string.IsNullOrEmpty(rfcACuentaTerceros) ? null : rfcACuentaTerceros;
        }

        internal string GetComplemento(string complemento) {
            return string.IsNullOrEmpty(complemento) ? null : complemento;
        }
        #endregion
    }
}
