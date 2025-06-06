using Jaeger.SAT.API.WebService.Abstracts;
using Jaeger.SAT.API.WebService.Base;

namespace Jaeger.SAT.API.WebService.Verificacion {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    public partial class VerificaSolicitudDescargaMasivaTercero : PropertyChangeImplementation, System.ComponentModel.INotifyPropertyChanged {

        private SignatureType signatureField;

        private string idSolicitudField;

        private string rfcSolicitanteField;

        /// <summary>
        /// Firma de la petición realizada con el certificado de e.firma.
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", Order = 0)]
        public SignatureType Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
                this.RaisePropertyChanged("Signature");
            }
        }

        /// <summary>
        /// Contiene el Identificador de la solicitud que se pretende consultar.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IdSolicitud {
            get {
                return this.idSolicitudField;
            }
            set {
                this.idSolicitudField = value;
                this.RaisePropertyChanged("IdSolicitud");
            }
        }

        /// <summary>
        /// Contiene el RFC del solicitante que generó la petición de solicitud de descarga masiva.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RfcSolicitante {
            get {
                return this.rfcSolicitanteField;
            }
            set {
                this.rfcSolicitanteField = value;
                this.RaisePropertyChanged("RfcSolicitante");
            }
        }
    }
}
