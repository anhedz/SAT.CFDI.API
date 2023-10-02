namespace Jaeger.SAT.CFDI.Services.Interfaces {
    public interface IDownloadResponse {
        /// <summary>
        /// obtener id de paquete
        /// </summary>
        string IdPackage { get; }
        /// <summary>
        /// codigo de estatus 
        /// </summary>
        IStatusCode StatusCode { get; }
        /// <summary>
        /// obtener ruta 
        /// </summary>
        string Path { get; }

        #region builder
        IDownloadResponse AddIdPackage(string idPackage);
        IDownloadResponse AddStatusCode(IStatusCode statusCode);
        IDownloadResponse AddPath(string path);
        #endregion
    }
}
