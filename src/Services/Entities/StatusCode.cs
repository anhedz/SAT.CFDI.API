using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.Services.Entities {
    /// <summary>
    /// Estado de la Solicitud
    /// Defines "CodEstatus" and "Mensaje"
    /// </summary>
    public class StatusCode : IStatusCode {
        #region declaraciones
        private readonly int _Code;
        private readonly string _Message;
        #endregion

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="code">codigo numerico</param>
        /// <param name="message">mensaje o descripcion</param>
        public StatusCode(string code, string message) {
            if (!string.IsNullOrEmpty(code)) {
                _Code = int.Parse(code);
            } else {
                _Code = 0;
            }
            if (!string.IsNullOrEmpty(message)) {
                _Message = message;
            }
        }

        /// <summary>
        ///  Contains the value of "CodEstatus"
        /// </summary>
        public int Code {
            get { return _Code; }
        }

        /// <summary>
        ///  Contains the value of "Mensaje"
        /// </summary>
        public string Message {
            get { return _Message; }
        }

        /// <summary>
        /// The only success code is "5000: Solicitud recibida con éxito"
        /// </summary>
        /// <returns>true when "CodEstatus" is success</returns>
        public bool IsAccepted() {
            return _Code == 5000;
        }

        public override string ToString() {
            return string.Format("{0} - {1}", _Code, _Message);
        }
    }
}
