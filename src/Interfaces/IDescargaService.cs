using System.IO;
using Jaeger.SAT.CFDI.Services.API.Descargas;

namespace Jaeger.SAT.CFDI.Services.Interfaces {
    public interface IDescargaService : IBase {
        IDescargaService AddToken(string token);
        void AddIdPaquete(string idPaquete);
        RespuestaDescargaMasivaTerceros DescargaSolicitud(ref Stream sPaquete);
    }
}
