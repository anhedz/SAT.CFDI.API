namespace Jaeger.SAT.CFDI.Services.Interfaces {
    /// <summary>
    /// servicio de autenticacion
    /// </summary>
    public interface IAutenticaService : IBase {
        bool IsAuthenticated { get; }

        /// <summary>
        /// generar token de autenticacion
        /// </summary>
        /// <returns>string</returns>
        string GeneraToken();

    }
}
