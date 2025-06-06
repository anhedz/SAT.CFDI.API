using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.CFDI {
    /// <summary>
    /// Servicio Solicutd de Descarga Masiva
    /// </summary>
    internal class SolicitudService : API.Services.Abstracts.SolicitudService, IConsultaService {
        public SolicitudService() {
            this.AddURL("https://cfdidescargamasivasolicitud.clouda.sat.gob.mx/SolicitaDescargaService.svc");
        }
    }
}
