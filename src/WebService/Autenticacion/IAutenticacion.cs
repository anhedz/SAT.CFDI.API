using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Jaeger.SAT.API.WebService.Autenticacion {
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(ConfigurationName = "Autenticacion.IAutenticacion", Namespace = "http://DescargaMasivaTerceros.gob.mx")]
    public interface IAutenticacion {
        [OperationContract(Action = "http://DescargaMasivaTerceros.gob.mx/IAutenticacion/Autentica", ReplyAction = "http://DescargaMasivaTerceros.gob.mx/IAutenticacion/AutenticaResponse")]
        string Autentica();

        [OperationContract(Action = "http://DescargaMasivaTerceros.gob.mx/IAutenticacion/Autentica", ReplyAction = "http://DescargaMasivaTerceros.gob.mx/IAutenticacion/AutenticaResponse")]
        Task<string> AutenticaAsync();
    }
}
