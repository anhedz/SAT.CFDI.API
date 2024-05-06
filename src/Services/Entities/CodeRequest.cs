using Jaeger.SAT.API.Services.Enums;
using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.Services.Entities {
    public class CodeRequest : ICodeRequest {
        private readonly CodEstatusEnum _code;

        public CodeRequest(string code) {
            if (code != null) {
                _code = (CodEstatusEnum)Helpers.StringEnum.Parse(typeof(CodEstatusEnum), code);
            } else {
                _code = CodEstatusEnum.ErrorInterno;
            }
        }

        public CodEstatusEnum Code {
            get { return _code; }
        }

        public string Message {
            get { return _code.ToString(); }
        }
    }
}
