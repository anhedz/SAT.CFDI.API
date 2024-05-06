using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.API.WebService.Abstracts;

namespace Jaeger.SAT.API.WebService.Descargas {
    [GeneratedCode("System.Xml", "4.7.2612.0")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    [Serializable]
    public class RespuestaDescargaMasivaTerceros : PropertyChangeImplementation {
        private string idSolicitudField;
        private string codEstatusField;
        private string mensajeField;

        [XmlAttribute()]
        public string IdSolicitud {
            get {
                return idSolicitudField;
            }
            set {
                idSolicitudField = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// obtener o establecer el codigo de status
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
        /// obtener o establecer la descripcion del mensaje
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
