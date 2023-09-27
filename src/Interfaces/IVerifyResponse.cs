using System.Collections.Generic;

namespace Jaeger.SAT.CFDI.Services.Interfaces {
    public interface IVerifyResponse {
        IVerifyResponse AddStatusCode(IStatusCode statusCode);

        IVerifyResponse AddStatusRequest(IStatusRequest status);

        IVerifyResponse AddCodeRequest(ICodeRequest codeRequest);

        IVerifyResponse AddNumnberCFDIs(int numberCFDIs);

        IVerifyResponse AddPackagesIds(List<string> packages);

        IVerifyResponse AddXML(string xml);

        #region propiedades
        IStatusCode StatusCode { get; }

        IStatusRequest StatusRequest { get; }

        ICodeRequest CodeRequest { get; }

        int NumberCfdis { get; }

        List<string> PackagesIds { get; }

        string XML { get; }
        #endregion
    }
}
