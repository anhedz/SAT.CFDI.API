using System.Collections.Generic;
using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
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

        #region class build
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

        public int NumberCfdis {
            get { return this._NumberCfdis; }
        }

        public List<string> PackagesIds {
            get { return this._PackagesIds; }
        }

        
        public string XML {
            get { return this._XML; }
        }

        public List<IDownloadResponse> DownloadsPackages { get; internal set; }
        #endregion
    }
}
