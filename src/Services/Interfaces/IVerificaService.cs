namespace Jaeger.SAT.API.Services.Interfaces {
    /// <summary>
    /// Servicio de Verificacion de Solicitud de Descarga
    /// </summary>
    public interface IVerificaService : IServiceBase, IBase {
        /// <summary>
        /// Agregar Id de Solicitud a verificar
        /// </summary>
        IVerificaService AddIdSolicitud(string idSolicitud);

        /// <summary>
        /// Agregar token de autenticacion
        /// </summary>
        IVerificaService AddToken(string token);

        /// <summary>
        /// Ejecutar 
        /// </summary>
        IVerifyResponse Execute();
        IVerifyResponse Test();
    }
}
