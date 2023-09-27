using Jaeger.SAT.CFDI.Services.Enums;
using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
    public class CodeRequest : ICodeRequest {
        private CodEstatusEnum _code;

        public CodeRequest(string code) {
            this._code = (CodEstatusEnum)Helpers.StringEnum.Parse(typeof(CodEstatusEnum), code);
        }

        public CodEstatusEnum Code {
            get { return this._code; }
        }

        public string Message {
            get { return this._code.ToString(); }
        }
    }
}
