using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Abstracts {
    public abstract class ApiManagerServicesBase : Base, IBase {
        protected internal IAutenticaService _AutenticaService;
        protected internal IConsultaService _ConsultaService;
        protected internal IVerificaService _VerificaService;
        protected internal IDescargaService _DescargaService;

        public ApiManagerServicesBase() : base() { 
            this.Version = "AP1.0.0.1";
        }

        public string Version { get; internal set; }

        public string Token { get; internal set; }

        public ICodeError CodeError { get; internal set; }
    }
}
