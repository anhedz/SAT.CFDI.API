namespace Jaeger.SAT.CFDI.Services.Interfaces {
    public interface IApiManagerServices : IBase {
        string Version { get; }

        IApiManagerServices AddSolicitud(ISolicitud solicitud);

        string Token { get; }

        ISolicitud Solicitud { get; }

        ICodeError CodeError { get; }

        bool Autenticacion();

        IQueryResponse Consulta();

        IVerifyResponse Verifica();

        IVerifyResponse Descargar();
    }
}
