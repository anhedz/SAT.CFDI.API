using System.CodeDom.Compiler;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Jaeger.SAT.CFDI.Services.API.Autenticacion {
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class AutenticacionClient : ClientBase<IAutenticacion>, IAutenticacion {
        public AutenticacionClient() {
        }

        public AutenticacionClient(string endpointConfigurationName) : base(endpointConfigurationName) {
        }

        public AutenticacionClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress) {
        }

        public AutenticacionClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress) {
        }

        public AutenticacionClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress) {
        }

        public string Autentica() { 
            return Channel.Autentica(); 
        }

        public Task<string> AutenticaAsync() {
            return Channel.AutenticaAsync();
        }
    }
}
