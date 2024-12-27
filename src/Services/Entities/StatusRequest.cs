using System.Collections.Generic;
using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.Services.Entities {
    /// <summary>
    /// Estado de la Solicitud
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
            _code = code;
            if (code < 0 || code > 6) {
                _code = 0;
            }
        }

        #region propiedades
        /// <summary>
        /// Contains the "EstadoSolicitud" value
        /// obtener el numero correspondiente al estado de la solicitud de descarga, Estados de la solicitud: Aceptada=1, EnProceso=2, Terminada=3, Error=4, Rechazada=5, Vencida=6
        /// </summary>
        public int Code {
            get { return _code; }
        }

        /// <summary>
        /// Contains the "EstadoSolicitud" value
        /// modo texto
        /// </summary>
        public string Message {
            get { return _values[_code]; }
        }
        #endregion

        #region metodos publicos
        /// <summary>
        /// Solicitud Acepatada
        /// </summary>
        public bool IsAccepted() {
            return _code == 1;
        }

        /// <summary>
        /// Solicitud En Proceso
        /// </summary>
        public bool IsInProgress() {
            return _code == 2;
        }

        /// <summary>
        /// Solicitud Terminada
        public bool IsFinished() {
            return _code == 3;
        }

        /// <summary>
        /// Solicitud Notifica error
        /// </summary>
        public bool IsFailure() {
            return _code == 4;
        }

        /// <summary>
        /// Solicitud Rechazada
        /// </summary>
        public bool IsRejected() {
            return Code == 5;
        }

        /// <summary>
        /// Solicitud Vencida
        /// </summary>
        public bool IsExpired() {
            return _code == 6;
        }
        #endregion

        public Enums.EstadoSolicitudEnum GetEstado() {
            switch (_code) {
                case 1:
                    return Enums.EstadoSolicitudEnum.Accepted;
                case 2:
                    return Enums.EstadoSolicitudEnum.InProgress;
                case 3:
                    return Enums.EstadoSolicitudEnum.Finished;
                case 4:
                    return Enums.EstadoSolicitudEnum.Error;
                case 5:
                    return Enums.EstadoSolicitudEnum.Rejected;
                case 6:
                    return Enums.EstadoSolicitudEnum.Expired;
                default:
                    return Enums.EstadoSolicitudEnum.Unknown;
            }
        }
    }
}
