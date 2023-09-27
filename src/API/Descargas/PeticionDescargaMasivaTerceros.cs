using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.CFDI.Services.API.Abstracts;
using Jaeger.SAT.CFDI.Services.API.Base;

namespace Jaeger.SAT.CFDI.Services.API.Descargas {
    [GeneratedCode("System.Xml", "4.7.2612.0")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    [Serializable]
    public class PeticionDescargaMasivaTerceros : PropertyChangeImplementation {
        private SignatureType signatureField;
        private string idPaqueteField;
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
        public string IdPaquete {
            get { return idPaqueteField; }
            set {
                idPaqueteField = value;
                OnPropertyChanged(nameof(IdPaquete));
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
