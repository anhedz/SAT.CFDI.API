using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
    public class QueryResponse : IQueryResponse {
        protected internal string _IdSolicitud;
        protected internal string _XML;
        protected internal string _SolicitanteRFC;
        protected internal IStatusCode _StatusCode;
        protected internal ISolicitud _Solicitud;

        public QueryResponse() { }

        public string IdSolicitud { get; internal set; }

        public IStatusCode StatusCode {
            get { return this._StatusCode; }
        }

        public ISolicitud Solicitud {
            get { return this._Solicitud; }
        }

        public string SolicitanteRFC {
            get { return this._SolicitanteRFC; }
        }

        public string ServiceProvider { get; internal set; }

        public string XML {
            get { return this._XML; }
        }

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
    }
}
