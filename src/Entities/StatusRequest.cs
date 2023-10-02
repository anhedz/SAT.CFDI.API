using System.Collections.Generic;
using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
    public class StatusRequest : IStatusRequest {
        private readonly int _code;
        private readonly Dictionary<int, string> _values =
            new Dictionary<int, string>() {
                { 0, "Error 0" },
                { 1, "Acepatada" },
                { 2, "En Proceso" } ,
                { 3, "Terminada" },
                { 4, "Error" },
                { 5, "Rechazada" },
                { 6, "Vencida" }
            };

        public StatusRequest(int code) {
            this._code = code;
            if (code < 0 || code > 6) {
                _code = 0;
            }
        }

        public int Code {
            get { return this._code; }
        }

        public string Message {
            get { return this._values[this._code]; }
        }
    }
}
