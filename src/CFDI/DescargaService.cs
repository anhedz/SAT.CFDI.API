using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.CFDI {
    /// <summary>
    /// Es un servicio web que permite realizar solicitudes de descarga de CFDIs o Metadata por un rango de fechas, para que la petición sea aceptada debe ser 
    /// realizada por el emisor o receptor de los CFDIs de los cuales se quiere descargar.
    /// </summary>
    internal class DescargaService : API.Services.Abstracts.DescargaService, IDescargaService {
        public DescargaService() {
            this.AddURL("https://cfdidescargamasiva.clouda.sat.gob.mx/DescargaMasivaService.svc");
        }
    }
}
