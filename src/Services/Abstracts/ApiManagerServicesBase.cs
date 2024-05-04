using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Abstracts {
    /// <summary>
    /// clase abstracta del administrador del servicio de consulta
    /// </summary>
    public abstract class ApiManagerServicesBase : Base, IBase {
        protected internal IAutenticaService _AutenticaService;
        protected internal IConsultaService _ConsultaService;
        protected internal IVerificaService _VerificaService;
        protected internal IDescargaService _DescargaService;

        /// <summary>
        /// constructor
        /// </summary>
        public ApiManagerServicesBase() : base() { 
            this.Version = "AP1.0.0.1";
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
