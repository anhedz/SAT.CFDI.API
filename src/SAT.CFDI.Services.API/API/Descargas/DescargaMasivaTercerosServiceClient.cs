using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Jaeger.SAT.CFDI.Services.API.Descargas {
    public class DescargaMasivaTercerosServiceClient : ClientBase<IDescargaMasivaTercerosService>, IDescargaMasivaTercerosService {
        public DescargaMasivaTercerosServiceClient() {
        }

        public DescargaMasivaTercerosServiceClient(string endpointConfigurationName) : base(endpointConfigurationName) {
        }

        public DescargaMasivaTercerosServiceClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress) {
        }

        public DescargaMasivaTercerosServiceClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress) {
        }

        public DescargaMasivaTercerosServiceClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress) {
        }

        RespuestaDescargaMasivaTercerosSalida IDescargaMasivaTercerosService.Descargar(PeticionDescargaMasivaTercerosEntrada request) {
            return Channel.Descargar(request);
        }

        public RespuestaDescargaMasivaTerceros Descargar(PeticionDescargaMasivaTerceros peticionDescarga, out Stream Paquete) {
            RespuestaDescargaMasivaTercerosSalida masivaTercerosSalida = ((IDescargaMasivaTercerosService)this).Descargar(new PeticionDescargaMasivaTercerosEntrada() {
                peticionDescarga = peticionDescarga
            });
            Paquete = masivaTercerosSalida.Paquete;
            return masivaTercerosSalida.respuesta;
        }

        Task<RespuestaDescargaMasivaTercerosSalida> IDescargaMasivaTercerosService.DescargarAsync(PeticionDescargaMasivaTercerosEntrada request) {
            return Channel.DescargarAsync(request);
        }

        public Task<RespuestaDescargaMasivaTercerosSalida> DescargarAsync(PeticionDescargaMasivaTerceros peticionDescarga) {
            return ((IDescargaMasivaTercerosService)this).DescargarAsync(new PeticionDescargaMasivaTercerosEntrada() {
                peticionDescarga = peticionDescarga
            });
        }
    }
}
