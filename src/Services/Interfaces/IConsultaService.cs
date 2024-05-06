namespace Jaeger.SAT.API.Services.Interfaces {
    public interface IConsultaService : IServiceBase, IBase {
        /// <summary>
        /// Parametro obligatorio, token de autenticacion
        /// </summary>
        IConsultaService AddToken(string token);

        /// <summary>
        /// agregar informacion de la solicitud
        /// </summary>
        /// <param name="solicitud">ISolicitud</param>
        IConsultaService AddSolicitud(ISolicitud solicitud);

        /// <summary>
        /// ejecutar consulta
        /// </summary>
        /// <returns>IQueryResponse</returns>
        IQueryResponse Execute();
    }
}
