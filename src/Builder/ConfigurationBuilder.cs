using Jaeger.SAT.CFDI.Services.Entities;
using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Builder {
    public class ConfigurationBuilder : IConfigurationBuilder, IConfigurationDonwloadPathBuilder {
        protected internal IConfiguration _Configuration;

        public ConfigurationBuilder() {
            this._Configuration = new Configuration();
        }

        public IConfiguration Build() {
            return this._Configuration;
        }

        public IConfigurationDonwloadPathBuilder PathDownload(string path) {
            this._Configuration.PathDownload = path;
            return this;
        }
    }
}
