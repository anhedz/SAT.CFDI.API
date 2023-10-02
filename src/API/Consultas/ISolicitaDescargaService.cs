using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Jaeger.SAT.CFDI.Services.API.Consultas {
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(ConfigurationName = "Consultas.ISolicitaDescargaService", Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    public interface ISolicitaDescargaService {
        [OperationContract(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarga", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescargaResponse")]
        [XmlSerializerFormat(SupportFaults = true)]
        RespuestaSolicitudDescMasTercero SolicitaDescarga(SolicitudDescargaMasivaTercero solicitud);

        [OperationContract(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarga", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescargaResponse")]
        Task<RespuestaSolicitudDescMasTercero> SolicitaDescargaAsync(SolicitudDescargaMasivaTercero solicitud);
    }
}
