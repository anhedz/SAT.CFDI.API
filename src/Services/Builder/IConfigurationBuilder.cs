using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.Services.Builder {
    public interface IConfigurationBuilder {
        /// <summary>
        /// path de descarga
        /// </summary>
        IConfigurationDonwloadPathBuilder PathDownload(string path);
    }

    public interface IConfigurationDonwloadPathBuilder {
        IConfiguration Build();
    }
}
