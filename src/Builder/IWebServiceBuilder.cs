using Jaeger.SAT.CFDI.API.Contracts;
using Jaeger.SAT.CFDI.Interfaces;

namespace Jaeger.SAT.CFDI.Builder {
    public interface IWebServiceBuilder {
        IWebServiceConfigurationBuilder AddConfiguration(IConfiguration cofiguration);
    }

    public interface IWebServiceConfigurationBuilder {
        IWebServiceSolicitanteBuilder Solicitante(ISolicitante solicitante);
    }

    public interface IWebServiceSolicitanteBuilder {
        IWebServiceSAT Build();
    }
}
