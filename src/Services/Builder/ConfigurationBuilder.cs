using Jaeger.SAT.API.Services.Interfaces;
using Jaeger.SAT.API.Services.Entities;

namespace Jaeger.SAT.API.Services.Builder {
    /// <summary>
    /// Configuracion
    /// </summary>
    public class ConfigurationBuilder : IConfigurationBuilder, IConfigurationDonwloadPathBuilder {
        protected internal IConfiguration _Configuration;

        /// <summary>
        /// cosntructor
        /// </summary>
        public ConfigurationBuilder() {
            _Configuration = new Configuration();
        }

        public IConfiguration Build() {
            return _Configuration;
        }

        /// <summary>
        /// path de descarga
        /// </summary>
        public IConfigurationDonwloadPathBuilder PathDownload(string path) {
            _Configuration.PathDownload = path;
            return this;
        }
    }
}
