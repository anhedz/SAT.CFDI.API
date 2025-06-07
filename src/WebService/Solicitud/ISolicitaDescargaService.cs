using System.ServiceModel;
using System.CodeDom.Compiler;
using System.Threading.Tasks;

namespace Jaeger.SAT.API.WebService.Solicitud {
    [GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [ServiceContractAttribute(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx", ConfigurationName = "Solicitud.ISolicitaDescargaService")]
    public interface ISolicitaDescargaService {

        [OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aEmitidos", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aEmitidosResponse")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        RespuestaSolicitudDescMasTercero SolicitaDescargaEmitidos(SolicitudDescargaMasivaTerceroEmitidos solicitud);

        [OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aEmitidos", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aEmitidosResponse")]
        Task<RespuestaSolicitudDescMasTercero> SolicitaDescargaEmitidosAsync(SolicitudDescargaMasivaTerceroEmitidos solicitud);

        [OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aRecibidos", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aRecibidosResponse")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        RespuestaSolicitudDescMasTercero SolicitaDescargaRecibidos(SolicitudDescargaMasivaTerceroRecibidos solicitud);

        [OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aRecibidos", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aRecibidosResponse")]
        Task<RespuestaSolicitudDescMasTercero> SolicitaDescargaRecibidosAsync(SolicitudDescargaMasivaTerceroRecibidos solicitud);

        [OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aFolio", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aFolioResponse")]
        [XmlSerializerFormatAttribute(SupportFaults = true)]
        RespuestaSolicitudDescMasTercero SolicitaDescargaFolio(SolicitudDescargaMasivaTerceroFolio solicitud);

        [OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aFolio", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aFolioResponse")]
        Task<RespuestaSolicitudDescMasTercero> SolicitaDescargaFolioAsync(SolicitudDescargaMasivaTerceroFolio solicitud);
    }
}
