using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.Services.Entities {
    public class CodeError : ICodeError {
        public CodeError() { }

        public CodeError(int code, string message) {
            Code = code;
            Message = message;
        }

        public int Code { get; internal set; }

        public string Message { get; internal set; }
    }
}
