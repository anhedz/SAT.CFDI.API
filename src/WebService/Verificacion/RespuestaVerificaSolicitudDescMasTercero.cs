namespace Jaeger.SAT.API.WebService.Verificacion {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    public partial class RespuestaVerificaSolicitudDescMasTercero : object, System.ComponentModel.INotifyPropertyChanged {

        private string[] idsPaquetesField;

        private string codEstatusField;

        private int estadoSolicitudField;

        private string codigoEstadoSolicitudField;

        private int numeroCFDIsField;

        private string mensajeField;

        /// <summary>
        /// Contiene los identificadores de los paquetes que componen la solicitud de descarga masiva.Solo se devuelve cuando la solicitud posee un estatus de finalizado.  
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("IdsPaquetes", Order = 0)]
        public string[] IdsPaquetes {
            get {
                return this.idsPaquetesField;
            }
            set {
                this.idsPaquetesField = value;
                this.RaisePropertyChanged("IdsPaquetes");
            }
        }

        /// <summary>
        /// Código de estatus de la petición de verificación. 
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
        /// Contiene el número correspondiente al estado de la solicitud de descarga.
        /// Estados de la solicitud:
        ///  Aceptada = 1 
        ///  En Proceso = 2
        ///  Terminada = 3 
        ///  Error = 4 
        ///  Rechazada = 5 
        ///  Vencida = 6 
        /// *Esta sucede 72 horas después de que se generó el paquete de descarga.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int EstadoSolicitud {
            get {
                return this.estadoSolicitudField;
            }
            set {
                this.estadoSolicitudField = value;
                this.RaisePropertyChanged("EstadoSolicitud");
            }
        }

        /// <summary>
        /// Contiene el código de estado de la solicitud de descarga, el cual puede ser 5000, 5001, 5002 o 5005, para más información referente a estos códigos, favor de
        /// consultar el documento Documentación WS Solicitud Descarga Masiva.docx.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodigoEstadoSolicitud {
            get {
                return this.codigoEstadoSolicitudField;
            }
            set {
                this.codigoEstadoSolicitudField = value;
                this.RaisePropertyChanged("CodigoEstadoSolicitud");
            }
        }

        /// <summary>
        /// Número de CFDI que conforman la solicitud de descarga consultada.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int NumeroCFDIs {
            get {
                return this.numeroCFDIsField;
            }
            set {
                this.numeroCFDIsField = value;
                this.RaisePropertyChanged("NumeroCFDIs");
            }
        }

        /// <summary>
        /// Pequeña descripción del código correspondiente a la petición de verificación.
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
