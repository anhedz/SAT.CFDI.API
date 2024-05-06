using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.CRET {
    internal class ConsultaService : API.Services.Abstracts.ConsultaService, IConsultaService {
        public ConsultaService() {
            this.AddURL("https://retendescargamasivasolicitud.clouda.sat.gob.mx/SolicitaDescargaService.svc");
        }
    }
}
