using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.CFDI.Services.API.Abstracts;

namespace Jaeger.SAT.CFDI.Services.API.Consultas {
    [GeneratedCode("System.Xml", "4.7.2612.0")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    [Serializable]
    public class RespuestaSolicitudDescMasTercero : PropertyChangeImplementation {
        private string idSolicitudField;
        private string codEstatusField;
        private string mensajeField;

        [XmlAttribute]
        public string IdSolicitud {
            get { return idSolicitudField; }
            set {
                idSolicitudField = value;
                OnPropertyChanged(nameof(IdSolicitud));
            }
        }

        [XmlAttribute]
        public string CodEstatus {
            get { return codEstatusField; }
            set {
                codEstatusField = value;
                OnPropertyChanged(nameof(CodEstatus));
            }
        }

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
