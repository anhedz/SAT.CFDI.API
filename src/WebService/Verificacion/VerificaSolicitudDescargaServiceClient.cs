namespace Jaeger.SAT.API.WebService.Verificacion
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VerificaSolicitudDescargaServiceClient : System.ServiceModel.ClientBase<IVerificaSolicitudDescargaService>, IVerificaSolicitudDescargaService {

        public VerificaSolicitudDescargaServiceClient() {
        }

        public VerificaSolicitudDescargaServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName) {
        }

        public VerificaSolicitudDescargaServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public VerificaSolicitudDescargaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public VerificaSolicitudDescargaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress) {
        }

        public RespuestaVerificaSolicitudDescMasTercero VerificaSolicitudDescarga(VerificaSolicitudDescargaMasivaTercero solicitud) {
            return base.Channel.VerificaSolicitudDescarga(solicitud);
        }

        public System.Threading.Tasks.Task<RespuestaVerificaSolicitudDescMasTercero> VerificaSolicitudDescargaAsync(VerificaSolicitudDescargaMasivaTercero solicitud) {
            return base.Channel.VerificaSolicitudDescargaAsync(solicitud);
        }
    }
}
