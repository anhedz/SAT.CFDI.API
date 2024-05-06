using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.CRET {
    internal class VerificaService : API.Services.Abstracts.VerificaService, IVerificaService {
        public VerificaService() {
            this.AddURL("https://retendescargamasivasolicitud.clouda.sat.gob.mx/VerificaSolicitudDescargaService.svc");
        }
    }
}
