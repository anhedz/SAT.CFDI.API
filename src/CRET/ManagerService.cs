using Jaeger.SAT.API.Services.Abstracts;
using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.CRET {
    public class ManagerServices : ManagerService, IBase, IManagerServices {

        public ManagerServices(ISolicitante solicitante) : base(solicitante) {

        }

        protected override void FactoryAutentica() {
            this._AutenticaService = new AutenticaService();
        }

        protected override void FactoryConsulta() {
            this._ConsultaService = new ConsultaService();
        }

        protected override void FactoryDescarga() {
            this._DescargaService = new DescargaService();
        }

        protected override void FactoryVerifica() {
            this._VerificaService = new VerificaService();
        }
    }
}
