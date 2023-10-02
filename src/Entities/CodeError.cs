using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
    public class CodeError : ICodeError {
        public CodeError() { }

        public CodeError(int code, string message) { 
            this.Code = code;
            this.Message = message;
        }

        public int Code { get; internal set; }
        
        public string Message { get; internal set; }
    }
}
