namespace Jaeger.SAT.CFDI.Services.Interfaces {
    public interface IStatusCode {
        /// <summary>
        /// obtener codigo de status
        /// </summary>
        int Code { get; }

        /// <summary>
        /// obtener mensaje
        /// </summary>
        string Message { get; }

        /// <summary>
        /// The only success code is "5000: Solicitud recibida con éxito"
        /// </summary>
        /// <returns>true when "CodEstatus" is success</returns>
        bool IsAccepted();
    }
}
