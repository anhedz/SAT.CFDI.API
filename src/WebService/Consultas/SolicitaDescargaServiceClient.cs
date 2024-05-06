using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Jaeger.SAT.API.WebService.Consultas {
    /// <summary>
    /// Solicitud de Descarga Masiva
    /// </summary>
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class SolicitaDescargaServiceClient : ClientBase<ISolicitaDescargaService>, ISolicitaDescargaService {
        public SolicitaDescargaServiceClient() {
        }

        public SolicitaDescargaServiceClient(string endpointConfigurationName) : base(endpointConfigurationName) {
        }

        public SolicitaDescargaServiceClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress) {
        }

        public SolicitaDescargaServiceClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress) {
        }

        public SolicitaDescargaServiceClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress) {
        }

        public RespuestaSolicitudDescMasTercero SolicitaDescarga(SolicitudDescargaMasivaTercero solicitud) {
            return Channel.SolicitaDescarga(solicitud);
        }

        public Task<RespuestaSolicitudDescMasTercero> SolicitaDescargaAsync(SolicitudDescargaMasivaTercero solicitud) {
            return Channel.SolicitaDescargaAsync(solicitud);
        }
    }
}
