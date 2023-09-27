namespace Jaeger.SAT.CFDI.Services.Interfaces {
    public interface IQueryResponse {
        #region builder
        IQueryResponse AddIdSolicitud(string idSolicitud);

        IQueryResponse AddSolicitud(ISolicitud solicitud);

        IQueryResponse AddStatusCode(IStatusCode statusCode);

        IQueryResponse AddSolicitanteRFC(string solicitanteRFC);

        IQueryResponse AddServiceProvider(string serviceProvider);

        IQueryResponse AddXML(string xml);
        #endregion

        #region propiedades
        /// <summary>
        /// obtener o establecer Contiene el resultado de la peticion con el codigo de respuesta y los UUID de los CFDIs de los cuales se solicito la descarga, pero se encuentran en espera 
        /// de una confirmación por parte del receptor
        /// </summary>
        string IdSolicitud { get; }

        /// <summary>
        /// Contiene el RFC del que esta realizando la solicitud de descarga.
        /// </summary>
        string SolicitanteRFC { get; }

        ISolicitud Solicitud { get; }

        /// <summary>
        /// obtener o establecer codigo de estatus de la solicitud y la descripcion
        /// </summary>
        IStatusCode StatusCode { get; }

        string ServiceProvider { get; }

        /// <summary>
        /// obtener xml de la solicitud
        /// </summary>
        string XML { get; }
        #endregion
    }
}
