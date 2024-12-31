namespace Jaeger.SAT.API.Services.Interfaces {
    /// <summary>
    /// interface de configuracion
    /// </summary>
    public interface IConfiguration {
        /// <summary>
        /// obtener o establecer ruta de descarga
        /// </summary>
        string PathDownload { get; set; }
    }
}
