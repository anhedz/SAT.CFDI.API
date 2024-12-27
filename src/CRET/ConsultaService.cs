using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.CRET {
    /// <summary>
    /// Servicio Solicutd de Descarga Masiva
    /// </summary>
    internal class ConsultaService : API.Services.Abstracts.ConsultaService, IConsultaService {
        public ConsultaService() {
            this.AddURL("https://retendescargamasivasolicitud.clouda.sat.gob.mx/SolicitaDescargaService.svc");
        }
    }
}
