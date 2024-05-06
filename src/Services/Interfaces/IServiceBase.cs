namespace Jaeger.SAT.API.Services.Interfaces {
    public interface IServiceBase : IBase {
        #region propiedades
        /// <summary>
        /// URL del servicio
        /// </summary>
        string URL { get; set; }

        /// <summary>
        /// identificador de autenticacion del servicio
        /// </summary>
        string Token { get; set; }

        ICodeError CodeError { get; }
        #endregion
    }
}
