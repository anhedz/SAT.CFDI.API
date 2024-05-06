using System.Collections.Generic;

namespace Jaeger.SAT.API.Services.Interfaces {
    /// <summary>
    /// Service Verify Result
    /// </summary>
    public interface IVerifyResponse {
        #region propiedades
        /// <summary>
        /// Codigo de estado de la llamada. (CodStatus)
        /// </summary>
        IStatusCode StatusCode { get; }

        /// <summary>
        /// obtener el numero correspondiente al estado de la solicitud de descarga, Estados de la solicitud: Aceptada=1, EnProceso=2, Terminada=3, Error=4, Rechazada=5, Vencida=6 (EstadoSolicitud)
        /// </summary>
        IStatusRequest StatusRequest { get; }

        /// <summary>
        /// Codigos de status de solicitud
        /// </summary>
        ICodeRequest CodeRequest { get; }

        int NumberCfdis { get; }

        List<string> PackagesIds { get; }

        string XML { get; }
        #endregion

        #region build
        IVerifyResponse AddStatusCode(IStatusCode statusCode);

        IVerifyResponse AddStatusRequest(IStatusRequest status);

        IVerifyResponse AddCodeRequest(ICodeRequest codeRequest);

        IVerifyResponse AddNumnberCFDIs(int numberCFDIs);

        IVerifyResponse AddPackagesIds(List<string> packages);

        IVerifyResponse AddXML(string xml);
        #endregion
    }
}
