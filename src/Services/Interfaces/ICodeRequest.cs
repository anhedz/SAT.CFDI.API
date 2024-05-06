using Jaeger.SAT.API.Services.Enums;

namespace Jaeger.SAT.API.Services.Interfaces {
    /// <summary>
    /// Codigos de status de solicitud
    /// </summary>
    public interface ICodeRequest {
        CodEstatusEnum Code { get; }
        string Message { get; }
    }
}
