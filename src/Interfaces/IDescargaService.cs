using System.IO;
using Jaeger.SAT.CFDI.Services.API.Descargas;

namespace Jaeger.SAT.CFDI.Services.Interfaces {
    public interface IDescargaService : IBase {
        /// <summary>
        /// Agregar token de autenticacion
        /// </summary>
        IDescargaService AddToken(string token);

        /// <summary>
        /// agregar id de paquete de la solicitud
        /// </summary>
        void AddIdPaquete(string idPaquete);

        /// <summary>
        /// ejecutar metodo de descarga de paquetes
        /// </summary>
        /// <param name="package">referencia stream</param>
        /// <returns>IRespuestaDescargaMasivaTerceros</returns>
        RespuestaDescargaMasivaTerceros Execute(ref Stream package);
    }
}
