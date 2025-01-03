using Jaeger.SAT.API.Services.Enums;
using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.Services.Entities {
    /// <summary>
    /// codigo de solicitud
    /// </summary>
    public class CodeRequest : ICodeRequest {
        #region declaraciones
        private readonly CodEstatusEnum _code;
        #endregion

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="code">indice de codigo</param>
        public CodeRequest(string code) {
            if (code != null) {
                _code = (CodEstatusEnum)Helpers.StringEnum.Parse(typeof(CodEstatusEnum), code);
            } else {
                _code = CodEstatusEnum.ErrorInterno;
            }
        }

        /// <summary>
        /// obtener codigo de enumeracion
        /// </summary>
        public CodEstatusEnum Code {
            get { return _code; }
        }

        /// <summary>
        /// obtener mensaje
        /// </summary>
        public string Message {
            get { return _code.ToString(); }
        }
    }
}
