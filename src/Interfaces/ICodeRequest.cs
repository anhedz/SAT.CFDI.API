using Jaeger.SAT.CFDI.Services.Enums;

namespace Jaeger.SAT.CFDI.Services.Interfaces {
    /// <summary>
    /// Codigos de status de solicitud
    /// </summary>
    public interface ICodeRequest {
        CodEstatusEnum Code { get; }
        string Message { get; }
    }
}
