using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.CFDI.Services.API.Abstracts;

namespace Jaeger.SAT.CFDI.Services.API.Verificacion {
    [GeneratedCode("System.Xml", "4.7.2612.0")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    [Serializable]
    public class RespuestaVerificaSolicitudDescMasTercero : PropertyChangeImplementation, INotifyPropertyChanged {
        private string[] idsPaquetesField;
        private string codEstatusField;
        private int estadoSolicitudField;
        private string codigoEstadoSolicitudField;
        private int numeroCFDIsField;
        private string mensajeField;

        /// <summary>
        /// obtener o establecer los identificadores de los paquetes que componen la solicitud de descarga. Solo se devuelve cuando la solicitud posee un status finalizado
        /// </summary>
        [XmlElement("IdsPaquetes", Order = 0)]
        public string[] IdsPaquetes {
            get { return idsPaquetesField; }
            set {
                idsPaquetesField = value;
                OnPropertyChanged(nameof(IdsPaquetes));
            }
        }

        /// <summary>
        /// obtener o establecer codigo de estatis de la peticion de verificacion
        /// </summary>
        [XmlAttribute]
        public string CodEstatus {
            get { return codEstatusField; }
            set {
                codEstatusField = value;
                OnPropertyChanged(nameof(CodEstatus));
            }
        }

        /// <summary>
        /// obtener o establecer el numero correspondiente al estado de la solicitud de descarga (Aceptada = 1, EnProceso = 2, Terminada = 3, Error = 4, Rechazada = 5, Vencida = 6)
        /// </summary>
        [XmlAttribute]
        public int EstadoSolicitud {
            get { return estadoSolicitudField; }
            set {
                estadoSolicitudField = value;
                OnPropertyChanged(nameof(EstadoSolicitud));
            }
        }

        /// <summary>
        /// obtener o establecer codigo de estado de la solicitud de descarga, los cuales pueden ser 5000, 5002, 5003, 5004 o 5005
        /// </summary>
        [XmlAttribute]
        public string CodigoEstadoSolicitud {
            get { return codigoEstadoSolicitudField; }
            set {
                codigoEstadoSolicitudField = value;
                OnPropertyChanged(nameof(CodigoEstadoSolicitud));
            }
        }

        /// <summary>
        /// obtener o establecer numero de CFDIs que conforman la solicitud de descarga consultada
        /// </summary>
        [XmlAttribute]
        public int NumeroCFDIs {
            get { return numeroCFDIsField; }
            set {
                numeroCFDIsField = value;
                OnPropertyChanged(nameof(NumeroCFDIs));
            }
        }

        /// <summary>
        /// obtener o establecer descripcion del codigo estatus correspondiente a la peticion de verificacion
        /// </summary>
        [XmlAttribute]
        public string Mensaje {
            get { return mensajeField; }
            set {
                mensajeField = value;
                OnPropertyChanged(nameof(Mensaje));
            }
        }
    }
}
