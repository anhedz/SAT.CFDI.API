using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
    /// <summary>
    /// Defines "CodEstatus" and "Mensaje"
    /// </summary>
    public class StatusCode : IStatusCode {
        private readonly int _Code;
        private readonly string _Message;

        public StatusCode(string code, string message) {
            if (!string.IsNullOrEmpty(code)) {
                this._Code = int.Parse(code);
            } else {
                this._Code = 0;
            }
            if (!string.IsNullOrEmpty(message)) {
                this._Message = message;
            }
        }

        /// <summary>
        ///  Contains the value of "CodEstatus"
        /// </summary>
        public int Code {
            get { return this._Code; }
        }

        /// <summary>
        ///  Contains the value of "Mensaje"
        /// </summary>
        public string Message {
            get { return this._Message; }
        }

        /// <summary>
        /// The only success code is "5000: Solicitud recibida con éxito"
        /// </summary>
        /// <returns>true when "CodEstatus" is success</returns>
        public bool IsAccepted() {
            return this._Code == 5000;
        }

        public override string ToString() {
            return string.Format("{0} - {1}", this._Code, this._Message);
        }
    }
}
