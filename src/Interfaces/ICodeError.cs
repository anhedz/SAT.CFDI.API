namespace Jaeger.SAT.CFDI.Services.Interfaces {
    /// <summary>
    /// interface de codigo de error del servicio de consulta
    /// </summary>
    public interface ICodeError {
        /// <summary>
        /// obtener numero del codigo de error
        /// </summary>
        int Code { get; }

        /// <summary>
        /// obtener mensaje del codigo de error
        /// </summary>
        string Message { get; }
    }
}
