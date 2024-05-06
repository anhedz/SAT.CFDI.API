namespace Jaeger.SAT.API.Services.Interfaces {
    public interface IManagerServices : IBase {
        /// <summary>
        /// obetener version del servicio
        /// </summary>
        string Version { get; }

        IManagerServices AddSolicitud(ISolicitud solicitud);

        /// <summary>
        /// obtener Token de autenticacion del servicio de consulta
        /// </summary>
        string Token { get; }

        /// <summary>
        /// solicitud de descarga de CFDIs o Metadata
        /// </summary>
        ISolicitud Solicitud { get; }

        /// <summary>
        /// interface de codigo de error del servicio de consulta
        /// </summary>
        ICodeError CodeError { get; }

        bool Autenticacion();

        IQueryResponse Consulta();

        IVerifyResponse Verifica();

        IDownloadResponse Descargar(string package);
    }
}
