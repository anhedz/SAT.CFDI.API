using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.CFDI {
    internal class ConsultaService : API.Services.Abstracts.ConsultaService, IConsultaService {
        public ConsultaService() {
            this.AddURL("https://cfdidescargamasivasolicitud.clouda.sat.gob.mx/SolicitaDescargaService.svc");
        }
    }
}
