namespace Jaeger.SAT.API.Services.Interfaces {
    public interface IBase {
        /// <summary>
        /// obtener o establecer configuracion del servicio
        /// </summary>
        IConfiguration Configuration { get; set; }

        /// <summary>
        /// obtener o establecer informacion del solicitante
        /// </summary>
        ISolicitante Solicitante { get; set; }

        /// <summary>
        /// Agregar informacion del solicitante
        /// </summary>
        IBase AddSolicitante(ISolicitante solicitante);

        /// <summary>
        /// Agregar objeto de configuracion
        /// </summary>
        IBase AddConfiguration(IConfiguration configuration);
    }
}
