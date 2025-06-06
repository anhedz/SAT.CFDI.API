using Jaeger.SAT.API.WebService.Base;

namespace Jaeger.SAT.API.WebService.Solicitud {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    public partial class SolicitudDescargaMasivaTerceroFolio : object, System.ComponentModel.INotifyPropertyChanged {

        private SignatureType signatureField;

        private string rfcSolicitanteField;

        private string folioField;

        /// <summary>
        /// Firma de la petición realizada con el certificado de tipo E.FIRMA.
        /// La petición debe ordenarse alfabéticamente para que pueda realizarse correctamente la validación de la firma.
        /// Atributos: 
        /// 1. Folio
        /// 2. RfcSolicitante
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
        /// Contiene el RFC del que está realizando la solicitud de descarga.
        /// Debe corresponder con el contribuyente que está realizando la solicitud de descarga.
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

        /// <summary>
        /// Folio Fiscal con formato: XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX (Obligatorio).
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Folio {
            get {
                return this.folioField;
            }
            set {
                this.folioField = value;
                this.RaisePropertyChanged("Folio");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
