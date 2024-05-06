using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Jaeger.SAT.API.WebService.Descargas {
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(ConfigurationName = "Descargas.IDescargaMasivaTercerosService", Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    public interface IDescargaMasivaTercerosService {
        [OperationContract(Action = "http://DescargaMasivaTerceros.sat.gob.mx/IDescargaMasivaTercerosService/Descargar", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/IDescargaMasivaTercerosService/DescargarResponse")]
        [XmlSerializerFormat(SupportFaults = true)]
        RespuestaDescargaMasivaTercerosSalida Descargar(
          PeticionDescargaMasivaTercerosEntrada request);

        [OperationContract(Action = "http://DescargaMasivaTerceros.sat.gob.mx/IDescargaMasivaTercerosService/Descargar", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/IDescargaMasivaTercerosService/DescargarResponse")]
        Task<RespuestaDescargaMasivaTercerosSalida> DescargarAsync(
          PeticionDescargaMasivaTercerosEntrada request);
    }
}
