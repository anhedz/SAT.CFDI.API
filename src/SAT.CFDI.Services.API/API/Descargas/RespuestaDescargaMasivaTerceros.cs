using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.CFDI.Services.API.Abstracts;

namespace Jaeger.SAT.CFDI.Services.API.Descargas {
    [GeneratedCode("System.Xml", "4.7.2612.0")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    [Serializable]
    public class RespuestaDescargaMasivaTerceros : PropertyChangeImplementation {
        private string idSolicitudField;
        private string codEstatusField;
        private string mensajeField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IdSolicitud {
            get {
                return this.idSolicitudField;
            }
            set {
                this.idSolicitudField = value;
                this.OnPropertyChanged();
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
