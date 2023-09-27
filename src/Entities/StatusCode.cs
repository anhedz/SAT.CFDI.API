using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
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

        public int Code {
            get { return this._Code; }
        }

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
