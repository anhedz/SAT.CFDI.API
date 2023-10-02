using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Jaeger.SAT.CFDI.Services.API.Verificacion {
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(ConfigurationName = "Verificacion.IVerificaSolicitudDescargaService", Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    public interface IVerificaSolicitudDescargaService {
        [OperationContract(Action = "http://DescargaMasivaTerceros.sat.gob.mx/IVerificaSolicitudDescargaService/VerificaSolicitudDescarga", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/IVerificaSolicitudDescargaService/VerificaSolicitudDescargaResponse")]
        [XmlSerializerFormat(SupportFaults = true)]
        RespuestaVerificaSolicitudDescMasTercero VerificaSolicitudDescarga(
          VerificaSolicitudDescargaMasivaTercero solicitud);

        [OperationContract(Action = "http://DescargaMasivaTerceros.sat.gob.mx/IVerificaSolicitudDescargaService/VerificaSolicitudDescarga", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/IVerificaSolicitudDescargaService/VerificaSolicitudDescargaResponse")]
        Task<RespuestaVerificaSolicitudDescMasTercero> VerificaSolicitudDescargaAsync(
          VerificaSolicitudDescargaMasivaTercero solicitud);
    }
}
