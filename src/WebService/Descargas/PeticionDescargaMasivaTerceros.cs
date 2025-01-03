using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.API.WebService.Abstracts;
using Jaeger.SAT.API.WebService.Base;

namespace Jaeger.SAT.API.WebService.Descargas {
    /// <summary>
    ///     Peticion de descarga.
    /// </summary>
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

        /// <summary>
        ///     IdPaquete - Contiene el identificador del paquete que se desea descargar.
        /// </summary>
        [XmlAttribute]
        public string IdPaquete {
            get { return idPaqueteField; }
            set {
                idPaqueteField = value;
                OnPropertyChanged(nameof(IdPaquete));
            }
        }

        /// <summary>
        ///     RfcSolicitante - Contiene el RFC del solicitante que genero la petición de solicitud de descarga masiva.
        /// </summary>
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
