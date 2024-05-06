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
        public IVerifyResponse AddStatusCode(IStatusCode statusCode) {
            _StatusCode = statusCode;
            return this;
        }

        public IVerifyResponse AddStatusRequest(IStatusRequest status) {
            _StatusRequest = status;
            return this;
        }

        public IVerifyResponse AddCodeRequest(ICodeRequest codeRequest) {
            _CodeRequest = codeRequest;
            return this;
        }

        public IVerifyResponse AddNumnberCFDIs(int numberCFDIs) {
            _NumberCfdis = numberCFDIs;
            return this;
        }

        public IVerifyResponse AddPackagesIds(List<string> packages) {
            _PackagesIds = packages;
            return this;
        }

        public IVerifyResponse AddXML(string xml) {
            _XML = xml;
            return this;
        }

        //public IVerifyResponse AddPackage(IDownloadResponse response) {
        //    if (DownloadsPackages == null) {
        //        DownloadsPackages = new List<IDownloadResponse>();
        //    }
        //    DownloadsPackages.Add(response);
        //    return this;
        //}
        #endregion
    }
}
