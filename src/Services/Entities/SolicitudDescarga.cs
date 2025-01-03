using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.Services.Entities {
    /// <summary>
    ///     Peticion de descarga.
    /// </summary>
    internal class SolicitudDescarga : IDownloadResponse {
        /// <summary>
        ///     IdPaquete - Contiene el identificador del paquete que se desea descargar.
        /// </summary>
        public string IdPackage { get; internal set; }

        /// <summary>
        /// obtener codigo de estatus
        /// </summary>
        public IStatusCode StatusCode { get; internal set; }

        /// <summary>
        /// ruta de descarga
        /// </summary>
        public string Path { get; internal set; }

        #region builder
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPackage">identificador de paquete</param>
        /// <returns>IDownloadResponse</returns>
        public IDownloadResponse AddIdPackage(string idPackage) {
            IdPackage = idPackage;
            return this;
        }

        /// <summary>
        /// agregar PATH de descarga
        /// </summary>
        public IDownloadResponse AddPath(string path) {
            Path = path;
            return this;
        }

        /// <summary>
        /// agregar StatusCode
        /// </summary>
        public IDownloadResponse AddStatusCode(IStatusCode statusCode) {
            StatusCode = statusCode;
            return this;
        }
        #endregion
    }
}
