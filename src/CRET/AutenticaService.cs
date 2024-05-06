using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.CRET {
    internal class AutenticaService : API.Services.Abstracts.AutenticaService, IAutenticaService {
        public AutenticaService() {
            this.AddURL("https://retendescargamasivasolicitud.clouda.sat.gob.mx/Autenticacion/Autenticacion.svc");
        }
    }
}
