using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.CFDI {
    /// <summary>
    /// Servicio de Verificacion de Solicitud de Descarga
    /// </summary>
    internal class VerificaService : API.Services.Abstracts.VerificaService, IVerificaService {
        public VerificaService() {
            this.AddURL("https://cfdidescargamasivasolicitud.clouda.sat.gob.mx/VerificaSolicitudDescargaService.svc");
        }
    }
}
