namespace Jaeger.SAT.API.WebService.Solicitud {
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SolicitaDescargaServiceClient : System.ServiceModel.ClientBase<ISolicitaDescargaService>, ISolicitaDescargaService {

        public SolicitaDescargaServiceClient() {
        }

        public SolicitaDescargaServiceClient(string endpointConfigurationName) :
                base(endpointConfigurationName) {
        }

        public SolicitaDescargaServiceClient(string endpointConfigurationName, string remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public SolicitaDescargaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
                base(endpointConfigurationName, remoteAddress) {
        }

        public SolicitaDescargaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress) {
        }

        public RespuestaSolicitudDescMasTercero SolicitaDescargaEmitidos(SolicitudDescargaMasivaTerceroEmitidos solicitud) {
            return base.Channel.SolicitaDescargaEmitidos(solicitud);
        }

        public System.Threading.Tasks.Task<RespuestaSolicitudDescMasTercero> SolicitaDescargaEmitidosAsync(SolicitudDescargaMasivaTerceroEmitidos solicitud) {
            return base.Channel.SolicitaDescargaEmitidosAsync(solicitud);
        }

        public RespuestaSolicitudDescMasTercero SolicitaDescargaRecibidos(SolicitudDescargaMasivaTerceroRecibidos solicitud) {
            return base.Channel.SolicitaDescargaRecibidos(solicitud);
        }

        public System.Threading.Tasks.Task<RespuestaSolicitudDescMasTercero> SolicitaDescargaRecibidosAsync(SolicitudDescargaMasivaTerceroRecibidos solicitud) {
            return base.Channel.SolicitaDescargaRecibidosAsync(solicitud);
        }

        public RespuestaSolicitudDescMasTercero SolicitaDescargaFolio(SolicitudDescargaMasivaTerceroFolio solicitud) {
            return base.Channel.SolicitaDescargaFolio(solicitud);
        }

        public System.Threading.Tasks.Task<RespuestaSolicitudDescMasTercero> SolicitaDescargaFolioAsync(SolicitudDescargaMasivaTerceroFolio solicitud) {
            return base.Channel.SolicitaDescargaFolioAsync(solicitud);
        }
    }
}
