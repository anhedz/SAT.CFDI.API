using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
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

        public string Path { get; internal set; }

        #region builder
        public IDownloadResponse AddIdPackage(string idPackage) {
            this.IdPackage = idPackage;
            return this;
        }

        public IDownloadResponse AddPath(string path) {
            this.Path = path;
            return this;
        }

        public IDownloadResponse AddStatusCode(IStatusCode statusCode) {
            this.StatusCode = statusCode;
            return this;
        }
        #endregion
    }
}
