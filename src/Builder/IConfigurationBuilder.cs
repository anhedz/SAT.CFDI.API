using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Builder {
    public interface IConfigurationBuilder {
        IConfigurationDonwloadPathBuilder PathDownload(string path);
    }

    public interface IConfigurationDonwloadPathBuilder {
        IConfiguration Build();
    }
}
