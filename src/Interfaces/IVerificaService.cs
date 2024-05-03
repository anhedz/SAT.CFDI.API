namespace Jaeger.SAT.CFDI.Services.Interfaces {
    public interface IVerificaService : IServiceBase, IBase {
        IVerificaService AddIdSolicitud(string idSolicitud);
        IVerificaService AddToken(string token);
        IVerifyResponse Execute();
        IVerifyResponse Test();
    }
}
