using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.Services.Entities {
    /// <summary>
    /// configuracion del servicio
    /// </summary>
    public class Configuration : IConfiguration {
        public Configuration() { PathDownload = @"C:\Jaeger\Jaeger.Repositorio"; }

        /// <summary>
        /// obtener o establecer ruta de descarga
        /// </summary>
        public string PathDownload { get; set; }
    }
}
