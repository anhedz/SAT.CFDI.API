using Jaeger.SAT.CFDI.Services.Enums;

namespace Jaeger.SAT.CFDI.Services.Interfaces {
    public interface ICodeRequest {
        CodEstatusEnum Code { get; }
        string Message { get; }
    }
}
