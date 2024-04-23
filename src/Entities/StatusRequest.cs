using System.Collections.Generic;
using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
    /// <summary>
    /// Estado de Solicitud
    /// </summary>
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

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="code">codigo de status de la solicitud</param>
        public StatusRequest(int code) {
            this._code = code;
            if (code < 0 || code > 6) {
                _code = 0;
            }
        }

        /// <summary>
        /// Contains the "EstadoSolicitud" value
        /// obtener el numero correspondiente al estado de la solicitud de descarga, Estados de la solicitud: Aceptada=1, EnProceso=2, Terminada=3, Error=4, Rechazada=5, Vencida=6
        /// </summary>
        public int Code {
            get { return this._code; }
        }

        /// <summary>
        /// Contains the "EstadoSolicitud" value
        /// modo texto
        /// </summary>
        public string Message {
            get { return this._values[this._code]; }
        }

        /// <summary>
        /// Solicitud Acepatada
        /// </summary>
        public bool IsAccepted() {
            return this._code == 1;
        }

        /// <summary>
        /// Solicitud En Proceso
        /// </summary>
        public bool IsInProgress() {
            return this._code == 2;
        }

        /// <summary>
        /// Solicitud Terminada
        public bool IsFinished() {
            return (this._code == 3);
        }

        /// <summary>
        /// Solicitud Notifica error
        /// </summary>
        public bool IsFailure() {
            return ((this._code == 4));
        }

        /// <summary>
        /// Solicitud Rechazada
        /// </summary>
        public bool IsRejected() {
            return this.Code == 5;
        }

        /// <summary>
        /// Solicitud Vencida
        /// </summary>
        public bool IsExpired() {
            return this._code == 6;
        }
    }
}
