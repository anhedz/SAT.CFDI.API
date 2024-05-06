using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.CFDI {
    /// <summary>
    /// servicio de autenticacion
    /// </summary>
    internal class AutenticaService : API.Services.Abstracts.AutenticaService, IAutenticaService {
        public AutenticaService() {
            this.AddURL("https://cfdidescargamasivasolicitud.clouda.sat.gob.mx/Autenticacion/Autenticacion.svc");
        }
    }
}
