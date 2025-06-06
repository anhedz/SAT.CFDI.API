namespace Jaeger.SAT.API.WebService.Solicitud {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx", ConfigurationName = "Solicitud.ISolicitaDescargaService")]
    public interface ISolicitaDescargaService {

        [System.ServiceModel.OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aEmitidos", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aEmitidosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        RespuestaSolicitudDescMasTercero SolicitaDescargaEmitidos(SolicitudDescargaMasivaTerceroEmitidos solicitud);

        [System.ServiceModel.OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aEmitidos", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aEmitidosResponse")]
        System.Threading.Tasks.Task<RespuestaSolicitudDescMasTercero> SolicitaDescargaEmitidosAsync(SolicitudDescargaMasivaTerceroEmitidos solicitud);

        [System.ServiceModel.OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aRecibidos", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aRecibidosResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        RespuestaSolicitudDescMasTercero SolicitaDescargaRecibidos(SolicitudDescargaMasivaTerceroRecibidos solicitud);

        [System.ServiceModel.OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aRecibidos", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aRecibidosResponse")]
        System.Threading.Tasks.Task<RespuestaSolicitudDescMasTercero> SolicitaDescargaRecibidosAsync(SolicitudDescargaMasivaTerceroRecibidos solicitud);

        [System.ServiceModel.OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aFolio", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aFolioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        RespuestaSolicitudDescMasTercero SolicitaDescargaFolio(SolicitudDescargaMasivaTerceroFolio solicitud);

        [System.ServiceModel.OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aFolio", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/ISolicitaDescargaService/SolicitaDescarg" +
            "aFolioResponse")]
        System.Threading.Tasks.Task<RespuestaSolicitudDescMasTercero> SolicitaDescargaFolioAsync(SolicitudDescargaMasivaTerceroFolio solicitud);
    }
}
