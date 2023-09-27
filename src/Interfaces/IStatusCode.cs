namespace Jaeger.SAT.CFDI.Services.Interfaces {
    public interface IStatusCode {
        int Code { get; }
        string Message { get; }

        /// <summary>
        /// The only success code is "5000: Solicitud recibida con éxito"
        /// </summary>
        /// <returns>true when "CodEstatus" is success</returns>
        bool IsAccepted();
    }
}
