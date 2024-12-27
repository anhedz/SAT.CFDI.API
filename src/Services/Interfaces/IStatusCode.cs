namespace Jaeger.SAT.API.Services.Interfaces {
    /// <summary>
    /// Codigo de estado de la peticion
    /// </summary>
    public interface IStatusCode {
        /// <summary>
        /// obtener codigo de estado de la llamada. (CodStatus)
        /// </summary>
        int Code { get; }

        /// <summary>
        /// obtener descripcion del codigo de estado.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// The only success code is "5000: Solicitud recibida con éxito"
        /// </summary>
        /// <returns>true when "CodEstatus" is success</returns>
        bool IsAccepted();
    }
}
