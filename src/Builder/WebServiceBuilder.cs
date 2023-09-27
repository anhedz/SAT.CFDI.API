using Jaeger.SAT.CFDI.API.Contracts;
using Jaeger.SAT.CFDI.Interfaces;

namespace Jaeger.SAT.CFDI.Builder {
    public class WebServiceBuilder : IWebServiceBuilder, IWebServiceConfigurationBuilder, IWebServiceSolicitanteBuilder {
        protected internal IWebServiceSAT _WebServices;
        
        public WebServiceBuilder() { }

        public IWebServiceConfigurationBuilder AddConfiguration(IConfiguration cofiguration) {
            return this;
        }
        
        public IWebServiceSolicitanteBuilder Solicitante(ISolicitante solicitante) {
            return this;
        }

        public IWebServiceSAT Build() {
            return this._WebServices;
        }
    }
}
