using System.Collections.Generic;

namespace Jaeger.SAT.CFDI.Services.Interfaces {
    /// <summary>
    /// Service Verify Result
    /// </summary>
    public interface IVerifyResponse {
        #region propiedades
        IStatusCode StatusCode { get; }

        /// <summary>
        /// EstadoSolicitud
        /// </summary>
        IStatusRequest StatusRequest { get; }

        /// <summary>
        /// Codigos de status de solicitud
        /// </summary>
        ICodeRequest CodeRequest { get; }

        int NumberCfdis { get; }

        List<string> PackagesIds { get; }

        List<IDownloadResponse> DownloadsPackages { get; }

        string XML { get; }
        #endregion

        #region build
        IVerifyResponse AddStatusCode(IStatusCode statusCode);

        IVerifyResponse AddStatusRequest(IStatusRequest status);

        IVerifyResponse AddCodeRequest(ICodeRequest codeRequest);

        IVerifyResponse AddNumnberCFDIs(int numberCFDIs);

        IVerifyResponse AddPackagesIds(List<string> packages);

        IVerifyResponse AddXML(string xml);

        IVerifyResponse AddPackage(IDownloadResponse response);
        #endregion
    }
}
