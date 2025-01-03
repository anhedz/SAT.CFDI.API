using System.Collections.Generic;
using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.Services.Entities {
    /// <summary>
    /// Service Verify Result
    /// </summary>
    public class VerifyResponse : IVerifyResponse {
        #region declaraciones
        protected internal IStatusCode _StatusCode;
        protected internal IStatusRequest _StatusRequest;
        protected internal ICodeRequest _CodeRequest;
        protected internal int _NumberCfdis;
        protected internal List<string> _PackagesIds;
        protected internal string _XML;
        #endregion

        /// <summary>
        /// constructor
        /// </summary>
        public VerifyResponse() { }

        #region propiedades
        public IStatusCode StatusCode {
            get { return _StatusCode; }
        }

        public IStatusRequest StatusRequest {
            get { return _StatusRequest; }
        }

        public ICodeRequest CodeRequest {
            get { return _CodeRequest; }
        }

        /// <summary>
        ///     NumeroCFDIs - Número de CFDIs que conforman la solicitud de descarga consultada.
        /// </summary>
        public int NumberCfdis {
            get { return _NumberCfdis; }
        }

        /// <summary>
        ///     IdsPaquetes - Contiene los identificadores de los paquetes que componen la solicitud de descarga masiva. Solo se
        ///     devuelve cuando la solicitud posee un estatus de finalizado.
        /// </summary>
        public List<string> PackagesIds {
            get { return _PackagesIds; }
        }

        /// <summary>
        /// xml del conteido de la respuesta
        /// </summary>
        public string XML {
            get { return _XML; }
        }

        /// <summary>
        ///     IdsPaquetes - Contiene los identificadores de los paquetes que componen la solicitud de descarga masiva. Solo se
        ///     devuelve cuando la solicitud posee un estatus de finalizado.
        /// </summary>
        //public List<IDownloadResponse> DownloadsPackages { get; internal set; }
        #endregion

        #region class builder
        /// <summary>
        /// Codigo de estado de la llamada. (CodStatus)
        /// </summary>
        public IVerifyResponse AddStatusCode(IStatusCode statusCode) {
            _StatusCode = statusCode;
            return this;
        }

        /// <summary>
        /// numero correspondiente al estado de la solicitud de descarga, Estados de la solicitud: Aceptada=1, EnProceso=2, Terminada=3, Error=4, Rechazada=5, Vencida=6 (EstadoSolicitud)
        /// </summary>
        public IVerifyResponse AddStatusRequest(IStatusRequest status) {
            _StatusRequest = status;
            return this;
        }

        /// <summary>
        /// Codigos de status de solicitud
        /// </summary>
        public IVerifyResponse AddCodeRequest(ICodeRequest codeRequest) {
            _CodeRequest = codeRequest;
            return this;
        }

        /// <summary>
        /// numero de CFDIs que conforman la solicitud de descarga consultada.
        /// </summary>
        public IVerifyResponse AddNumnberCFDIs(int numberCFDIs) {
            _NumberCfdis = numberCFDIs;
            return this;
        }

        /// <summary>
        /// identificadores de los paquetes que componen la solicitud de descarga masiva. Solo se devuelve cuando la solicitud posee un estatus de finalizado.
        /// </summary>
        public IVerifyResponse AddPackagesIds(List<string> packages) {
            _PackagesIds = packages;
            return this;
        }

        /// <summary>
        /// establecer contenido de la respuesta en formato XML
        /// </summary>
        public IVerifyResponse AddXML(string xml) {
            _XML = xml;
            return this;
        }
        #endregion
    }
}
