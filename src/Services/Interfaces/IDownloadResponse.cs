namespace Jaeger.SAT.API.Services.Interfaces {
    public interface IDownloadResponse {
        /// <summary>
        /// obtener id de paquete
        /// </summary>
        string IdPackage { get; }

        /// <summary>
        /// Codigo de estado de la peticion
        /// </summary>
        IStatusCode StatusCode { get; }
        
        /// <summary>
        /// obtener ruta 
        /// </summary>
        string Path { get; }

        #region builder
        /// <summary>
        /// Codigo de estado de la peticion
        /// </summary>
        IDownloadResponse AddStatusCode(IStatusCode statusCode);

        /// <summary>
        /// Agregar ID de Paquete
        /// </summary>
        IDownloadResponse AddIdPackage(string idPackage);

        /// <summary>
        /// Agregar ruta de descarga
        /// </summary>
        IDownloadResponse AddPath(string path);
        #endregion
    }
}
