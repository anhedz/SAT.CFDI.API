namespace Jaeger.SAT.API.Services.Interfaces {
    public interface IManagerServices : IBase {
        /// <summary>
        /// obetener version del servicio
        /// </summary>
        string Version { get; }

        /// <summary>
        /// obtener Token de autenticacion del servicio de consulta
        /// </summary>
        string Token { get; }

        /// <summary>
        /// obtener solicitud de descarga de CFDIs o Metadata
        /// </summary>
        ISolicitud Solicitud { get; }

        /// <summary>
        /// interface de codigo de error del servicio de consulta
        /// </summary>
        ICodeError CodeError { get; }

        IManagerServices AddSolicitud(ISolicitud solicitud);

        bool Autenticacion();

        IQueryResponse Consulta();

        IVerifyResponse Verifica();

        IVerifyResponse Verifica(ISolicitud solicitud);

        IDownloadResponse Descargar(string package);
    }
}
