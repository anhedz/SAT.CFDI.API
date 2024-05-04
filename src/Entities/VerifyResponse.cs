using System.Collections.Generic;
using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
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
            get { return this._StatusCode; }
        }

        public IStatusRequest StatusRequest {
            get { return this._StatusRequest; }
        }

        public ICodeRequest CodeRequest {
            get { return this._CodeRequest; }
        }

        /// <summary>
        ///     NumeroCFDIs - Número de CFDIs que conforman la solicitud de descarga consultada.
        /// </summary>
        public int NumberCfdis {
            get { return this._NumberCfdis; }
        }

        /// <summary>
        ///     IdsPaquetes - Contiene los identificadores de los paquetes que componen la solicitud de descarga masiva. Solo se
        ///     devuelve cuando la solicitud posee un estatus de finalizado.
        /// </summary>
        public List<string> PackagesIds {
            get { return this._PackagesIds; }
        }
        
        public string XML {
            get { return this._XML; }
        }

        /// <summary>
        ///     IdsPaquetes - Contiene los identificadores de los paquetes que componen la solicitud de descarga masiva. Solo se
        ///     devuelve cuando la solicitud posee un estatus de finalizado.
        /// </summary>
        public List<IDownloadResponse> DownloadsPackages { get; internal set; }
        #endregion

        #region class builder
        public IVerifyResponse AddStatusCode(IStatusCode statusCode) {
            this._StatusCode = statusCode;
            return this;
        }

        public IVerifyResponse AddStatusRequest(IStatusRequest status) {
            this._StatusRequest = status;
            return this;
        }

        public IVerifyResponse AddCodeRequest(ICodeRequest codeRequest) {
            this._CodeRequest = codeRequest;
            return this;
        }

        public IVerifyResponse AddNumnberCFDIs(int numberCFDIs) {
            this._NumberCfdis = numberCFDIs;
            return this;
        }

        public IVerifyResponse AddPackagesIds(List<string> packages) {
            this._PackagesIds = packages;
            return this;
        }

        public IVerifyResponse AddXML(string xml) {
            this._XML = xml;
            return this;
        }

        public IVerifyResponse AddPackage(IDownloadResponse response) {
            if (this.DownloadsPackages == null) {
                this.DownloadsPackages = new List<IDownloadResponse>();
            }
            this.DownloadsPackages.Add(response);
            return this;
        }
        #endregion
    }
}
