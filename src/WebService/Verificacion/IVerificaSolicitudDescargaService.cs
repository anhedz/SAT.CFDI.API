namespace Jaeger.SAT.API.WebService.Verificacion
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx", ConfigurationName = "Verificacion.IVerificaSolicitudDescargaService")]
    public interface IVerificaSolicitudDescargaService {

        [System.ServiceModel.OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/IVerificaSolicitudDescargaService/Verifi" +
            "caSolicitudDescarga", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/IVerificaSolicitudDescargaService/Verifi" +
            "caSolicitudDescargaResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        RespuestaVerificaSolicitudDescMasTercero VerificaSolicitudDescarga(VerificaSolicitudDescargaMasivaTercero solicitud);

        [System.ServiceModel.OperationContractAttribute(Action = "http://DescargaMasivaTerceros.sat.gob.mx/IVerificaSolicitudDescargaService/Verifi" +
            "caSolicitudDescarga", ReplyAction = "http://DescargaMasivaTerceros.sat.gob.mx/IVerificaSolicitudDescargaService/Verifi" +
            "caSolicitudDescargaResponse")]
        System.Threading.Tasks.Task<RespuestaVerificaSolicitudDescMasTercero> VerificaSolicitudDescargaAsync(VerificaSolicitudDescargaMasivaTercero solicitud);
    }
}
