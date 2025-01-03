using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.Services.Abstracts {
    /// <summary>
    /// clase abstracta del administrador del servicio de consulta
    /// </summary>
    public abstract class ManagerServiceBase : Base, IBase {
        #region declaraciones
        protected internal IAutenticaService _AutenticaService;
        protected internal IConsultaService _ConsultaService;
        protected internal IVerificaService _VerificaService;
        protected internal IDescargaService _DescargaService;
        #endregion

        /// <summary>
        /// constructor
        /// </summary>
        public ManagerServiceBase() : base() {
            Version = "AP1.0.0.1";
        }

        /// <summary>
        /// obetener version del servicio
        /// </summary>
        public string Version { get; internal set; }

        /// <summary>
        /// obtener Token de autenticacion del servicio de consulta
        /// </summary>
        public string Token { get; internal set; }

        /// <summary>
        /// obtener codigo de error del servicio de consulta
        /// </summary>
        public ICodeError CodeError { get; internal set; }
    }
}
