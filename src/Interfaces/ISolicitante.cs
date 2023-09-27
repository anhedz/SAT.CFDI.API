namespace Jaeger.SAT.CFDI.Services.Interfaces {
    /// <summary>
    /// Informacion del Solicitante
    /// </summary>
    public interface ISolicitante {
        /// <summary>
        /// obtener o establecer registro federal de contribuyentes
        /// </summary>
        string RFC { get; set; }

        /// <summary>
        /// obtener o establecer password
        /// </summary>
        string PasswordKey { get; set; }

        /// <summary>
        /// obtener o establecer contenido del certificado en formato PFX
        /// </summary>
        string B64PFX { get; set; }

        byte[] GetBytes();
    }
}
