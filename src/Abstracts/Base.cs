using Jaeger.SAT.CFDI.Services.Entities;
using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Abstracts {
    public abstract class Base : IBase {
        public Base() {
            this.Configuration = new Configuration();
        }

        /// <summary>
        /// Agregar informacion del solicitante
        /// </summary>
        public IBase AddSolicitante(ISolicitante solicitante) {
            this.Solicitante = solicitante;
            return this;
        }

        /// <summary>
        /// Agregar objeto de configuracion
        /// </summary>
        public IBase AddConfiguration(IConfiguration configuration) {
            this.Configuration = configuration;
            return this;
        }

        /// <summary>
        /// obtener o establecer configuracion del servicio
        /// </summary>
        public IConfiguration Configuration { get; set; }

        /// <summary>
        /// obtener o establecer informacion del solicitante
        /// </summary>
        public ISolicitante Solicitante { get; set; }
    }
}
