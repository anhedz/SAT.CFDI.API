namespace Jaeger.SAT.CFDI.Services.Interfaces {
    /// <summary>
    /// EstadoSolicitud
    /// </summary>
    public interface IStatusRequest {
        /// <summary>
        /// Contains the "EstadoSolicitud" value
        /// obtener el numero correspondiente al estado de la solicitud de descarga, Estados de la solicitud: Aceptada=1, EnProceso=2, Terminada=3, Error=4, Rechazada=5, Vencida=6
        /// </summary>
        int Code { get; }

        /// <summary>
        /// Contains the "EstadoSolicitud" value
        /// modo texto
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Solicitud Acepatada
        /// </summary>
        bool IsAccepted();

        /// <summary>
        /// Solicitud En Proceso
        /// </summary>
        bool IsInProgress();

        /// <summary>
        /// Solicitud Terminada
        bool IsFinished();

        /// <summary>
        /// Solicitud Notifica error
        /// </summary>
        bool IsFailure();

        /// <summary>
        /// Solicitud Rechazada
        /// </summary>
        bool IsRejected();

        /// <summary>
        /// para conocer si se encuentra en el estado 6: Vencida
        /// </summary>
        /// <returns>bool</returns>
        bool IsExpired();
    }
}
