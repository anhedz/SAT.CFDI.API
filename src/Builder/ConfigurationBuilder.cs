using Jaeger.SAT.CFDI.Services.Entities;
using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Builder {
    /// <summary>
    /// Configuracion
    /// </summary>
    public class ConfigurationBuilder : IConfigurationBuilder, IConfigurationDonwloadPathBuilder {
        protected internal IConfiguration _Configuration;

        /// <summary>
        /// cosntructor
        /// </summary>
        public ConfigurationBuilder() {
            this._Configuration = new Configuration();
        }

        public IConfiguration Build() {
            return this._Configuration;
        }

        /// <summary>
        /// path de descarga
        /// </summary>
        public IConfigurationDonwloadPathBuilder PathDownload(string path) {
            this._Configuration.PathDownload = path;
            return this;
        }
    }
}
