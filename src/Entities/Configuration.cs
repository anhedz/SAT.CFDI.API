using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
    public class Configuration : IConfiguration {
        public Configuration() { }
        public string PathDownload { get; set; }
    }
}
