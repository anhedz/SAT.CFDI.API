using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Jaeger.SAT.CFDI.Services.API.Verificacion {
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class VerificaSolicitudDescargaServiceClient :
    ClientBase<IVerificaSolicitudDescargaService>,
    IVerificaSolicitudDescargaService {
        public VerificaSolicitudDescargaServiceClient() {
        }

        public VerificaSolicitudDescargaServiceClient (string endpointConfigurationName) : base(endpointConfigurationName) {
        }

        public VerificaSolicitudDescargaServiceClient (string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress) {
        }

        public VerificaSolicitudDescargaServiceClient (string endpointConfigurationName, EndpointAddress remoteAddress)
          : base(endpointConfigurationName, remoteAddress) {
        }

        public VerificaSolicitudDescargaServiceClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress) {
        }

        public RespuestaVerificaSolicitudDescMasTercero VerificaSolicitudDescarga (VerificaSolicitudDescargaMasivaTercero solicitud) {
            return Channel.VerificaSolicitudDescarga(solicitud);
        }

        public Task<RespuestaVerificaSolicitudDescMasTercero> VerificaSolicitudDescargaAsync(
          VerificaSolicitudDescargaMasivaTercero solicitud) {
            return Channel.VerificaSolicitudDescargaAsync(solicitud);
        }
    }
}
