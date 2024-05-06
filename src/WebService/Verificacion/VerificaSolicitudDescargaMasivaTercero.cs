using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.API.WebService.Abstracts;
using Jaeger.SAT.API.WebService.Base;

namespace Jaeger.SAT.API.WebService.Verificacion {
    [GeneratedCode("System.Xml", "4.7.2612.0")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    [Serializable]
    public class VerificaSolicitudDescargaMasivaTercero : PropertyChangeImplementation {
        private SignatureType signatureField;
        private string idSolicitudField;
        private string rfcSolicitanteField;

        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#", Order = 0)]
        public SignatureType Signature {
            get { return signatureField; }
            set {
                signatureField = value;
                OnPropertyChanged(nameof(Signature));
            }
        }

        [XmlAttribute]
        public string IdSolicitud {
            get { return idSolicitudField; }
            set {
                idSolicitudField = value;
                OnPropertyChanged(nameof(IdSolicitud));
            }
        }

        [XmlAttribute]
        public string RfcSolicitante {
            get { return rfcSolicitanteField; }
            set {
                rfcSolicitanteField = value;
                OnPropertyChanged(nameof(RfcSolicitante));
            }
        }
    }
}
