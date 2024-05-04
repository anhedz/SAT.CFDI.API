using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
    public class QueryResponse : IQueryResponse {
        protected internal string _IdSolicitud;
        protected internal string _XML;
        protected internal string _SolicitanteRFC;
        protected internal IStatusCode _StatusCode;
        protected internal ISolicitud _Solicitud;

        public QueryResponse() { }

        #region propiedades
        /// <summary>
        ///     IdSolicitud - Contiene el resultado de la petición con el código de respuesta y los UUID de los CFDIs de los cuales
        ///     se solicitó la descarga, pero se encuentran en espera de una confirmación por parte del receptor.
        /// </summary>
        public string IdSolicitud { get; internal set; }

        /// <summary>
        /// obtener Codigo de Status
        /// </summary>
        public IStatusCode StatusCode {
            get { return this._StatusCode; }
        }

        /// <summary>
        /// solicitud de descarga de CFDIs o Metadata
        /// </summary>
        public ISolicitud Solicitud {
            get { return this._Solicitud; }
        }

        /// <summary>
        /// obtener Regitro Federal de Contribuyentes del solicitante
        /// </summary>
        public string SolicitanteRFC {
            get { return this._SolicitanteRFC; }
        }

        /// <summary>
        /// obtener nombre del proveedor del servicio
        /// </summary>
        public string ServiceProvider { get; internal set; }

        /// <summary>
        /// obtener respuesta en formato XML
        /// </summary>
        public string XML {
            get { return this._XML; }
        }
        #endregion

        #region builder
        public IQueryResponse AddIdSolicitud(string idSolicitud) {
            this.IdSolicitud = idSolicitud;
            return this;
        }

        public IQueryResponse AddSolicitud(ISolicitud solicitud) {
            this._Solicitud = solicitud;
            return this;
        }

        public IQueryResponse AddStatusCode(IStatusCode statusCode) {
            this._StatusCode = statusCode;
            return this;
        }

        public IQueryResponse AddSolicitanteRFC(string  solicitanteRFC) {
            this._SolicitanteRFC = solicitanteRFC;
            return this;
        }

        public IQueryResponse AddServiceProvider(string serviceProvider) { 
            this.ServiceProvider = serviceProvider;
            return this;
        }

        public IQueryResponse AddXML(string xml) {
            this._XML = xml;
            return this;
        }
        #endregion
    }
}
