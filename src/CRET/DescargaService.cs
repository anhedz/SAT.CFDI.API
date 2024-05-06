using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.CRET {
    internal class DescargaService : API.Services.Abstracts.DescargaService, IDescargaService {
        public DescargaService() {
            this.AddURL("https://retendescargamasiva.clouda.sat.gob.mx/DescargaMasivaService.svc");
        }
    }
}
