using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
    /// <summary>
    /// configuracion del servicio
    /// </summary>
    public class Configuration : IConfiguration {
        public Configuration() { this.PathDownload = @"C:\Jaeger\Jaeger.Repositorio"; }

        /// <summary>
        /// obtener o establecer ruta de descarga
        /// </summary>
        public string PathDownload { get; set; }
    }
}
