using Jaeger.SAT.API.Services.Interfaces;
using Jaeger.SAT.API.Services.Entities;

namespace Jaeger.SAT.API.Services.Abstracts {
    /// <summary>
    /// Base de Servicio
    /// </summary>
    public abstract class Base : IBase {
        public Base() {
            Configuration = new Configuration();
        }

        /// <summary>
        /// Agregar informacion del solicitante
        /// </summary>
        public IBase AddSolicitante(ISolicitante solicitante) {
            Solicitante = solicitante;
            return this;
        }

        /// <summary>
        /// Agregar objeto de configuracion
        /// </summary>
        public IBase AddConfiguration(IConfiguration configuration) {
            Configuration = configuration;
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
