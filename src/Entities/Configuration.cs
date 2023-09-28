using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
    public class Configuration : IConfiguration {
        public Configuration() { this.PathDownload = @"C:\Jaeger\Jaeger.Repositorio"; }
        public string PathDownload { get; set; }
    }
}
