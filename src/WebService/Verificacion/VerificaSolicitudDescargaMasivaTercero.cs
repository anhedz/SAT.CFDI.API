using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.API.WebService.Abstracts;
using Jaeger.SAT.API.WebService.Base;

namespace Jaeger.SAT.API.WebService.Verificacion {
    /// <summary>
    /// Peticion de verificacion.
    /// </summary>
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

        /// <summary>
        /// IdSolicitud - Contiene el Identificador de la solicitud que se pretende consultar.
        /// </summary>
        [XmlAttribute]
        public string IdSolicitud {
            get { return idSolicitudField; }
            set {
                idSolicitudField = value;
                OnPropertyChanged(nameof(IdSolicitud));
            }
        }

        /// <summary>
        /// RfcSolicitante - Contiene el RFC del solicitante que genero la petición de solicitud de descarga masiva.
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
