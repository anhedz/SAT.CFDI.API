using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.CFDI {
    internal class DescargaService : API.Services.Abstracts.DescargaService, IDescargaService {
        public DescargaService() {
            this.AddURL("https://cfdidescargamasiva.clouda.sat.gob.mx/DescargaMasivaService.svc");
        }
    }
}
