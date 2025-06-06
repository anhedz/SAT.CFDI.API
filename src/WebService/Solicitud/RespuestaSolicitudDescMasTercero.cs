namespace Jaeger.SAT.API.WebService.Solicitud {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    public partial class RespuestaSolicitudDescMasTercero : object, System.ComponentModel.INotifyPropertyChanged {

        private string idSolicitudField;

        private string rfcSolicitanteField;

        private string codEstatusField;

        private string mensajeField;

        /// <summary>
        /// Contiene el resultado de la petición con el código de respuesta y los UUID de los CFDIs de los cuales se solicitó la descarga, pero se encuentran en espera de una confirmación por parte del receptor.
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
        /// Contiene el RFC que realizo la solicitud. 
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
        /// Código de estatus de la solicitud
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodEstatus {
            get {
                return this.codEstatusField;
            }
            set {
                this.codEstatusField = value;
                this.RaisePropertyChanged("CodEstatus");
            }
        }

        /// <summary>
        /// Pequeña descripción del código estatus 
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Mensaje {
            get {
                return this.mensajeField;
            }
            set {
                this.mensajeField = value;
                this.RaisePropertyChanged("Mensaje");
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
