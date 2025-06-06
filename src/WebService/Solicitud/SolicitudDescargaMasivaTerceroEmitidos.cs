using Jaeger.SAT.API.WebService.Base;

namespace Jaeger.SAT.API.WebService.Solicitud {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    public partial class SolicitudDescargaMasivaTerceroEmitidos : object, System.ComponentModel.INotifyPropertyChanged {

        private string[] rfcReceptoresField;

        private SignatureType signatureField;

        private string complementoField;

        private string estadoComprobanteField;

        private System.DateTime fechaInicialField;

        private System.DateTime fechaFinalField;

        private string rfcEmisorField;

        private string rfcSolicitanteField;

        private string tipoComprobanteField;

        private TipoDescargaMasivaTerceros tipoSolicitudField;

        private string rfcACuentaTercerosField;

        /// <summary>
        /// Contiene el/los RFC’s receptores de los cuales se quiere consultar los CFDIs 
        /// Importante: El campo RfcReceptor, únicamente permite la captura de 5 registros como máximo.
        /// </summary>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RfcReceptor")]
        public string[] RfcReceptores {
            get {
                return this.rfcReceptoresField;
            }
            set {
                this.rfcReceptoresField = value;
                this.RaisePropertyChanged("RfcReceptores");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", Order = 1)]
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
        /// Define el complemento de CFDI a descargar: 
        ///- null 
        ///- acreditamientoieps10 
        ///- aerolineas 
        ///- certificadodedestruccion 
        ///- cfdiregistrofiscal 
        ///- comercioexterior10 
        ///- comercioexterior11 
        ///- comprobante 
        ///- consumodecombustibles 
        ///- consumodecombustibles11 
        ///- detallista 
        ///- divisas 
        ///- donat11 
        ///- ecc11 
        ///- ecc12 
        ///- gastoshidrocarburos10 
        ///- iedu 
        ///- implocal 
        ///- ine11 
        ///- ingresoshidrocarburos 
        ///- leyendasfisc 
        ///- nomina11 
        ///- nomina12 
        ///- notariospublicos 
        ///- obrasarteantiguedades 
        ///- pagoenespecie 
        ///- pagos10 
        ///- pfic 
        ///- renovacionysustitucionvehiculos 
        ///- servicioparcialconstruccion 
        ///- spei 
        ///- terceros11 
        ///- turistapasajeroextranjero 
        ///- valesdedespensa 
        ///- vehiculousado 
        ///- ventavehiculos11
        ///* null es el valor predeterminado y en caso de no declararse, se obtendrán todos los comprobantes sin importar el complemento asociado a los comprobantes.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Complemento {
            get {
                return this.complementoField;
            }
            set {
                this.complementoField = value;
                this.RaisePropertyChanged("Complemento");
            }
        }

        /// <summary>
        /// Dato opcional que define el estado del comprobante: Todos, Cancelado, Vigente
        /// En caso de que no se proporcione, se considerara Vigente como valor por defecto.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EstadoComprobante {
            get {
                return this.estadoComprobanteField;
            }
            set {
                this.estadoComprobanteField = value;
                this.RaisePropertyChanged("EstadoComprobante");
            }
        }

        /// <summary>
        /// Solo se buscarán CFDI, cuya fecha de emisión sea igual o mayor a la fecha inicial indicada en este parámetro (obligatorio).
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime FechaInicial {
            get {
                return this.fechaInicialField;
            }
            set {
                this.fechaInicialField = value;
                this.RaisePropertyChanged("FechaInicial");
            }
        }

        /// <summary>
        /// Solo se buscarán CFDI, cuya fecha de emisión sea igual o menor a la fecha final indicada en este parámetro. (obligatorio)
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime FechaFinal {
            get {
                return this.fechaFinalField;
            }
            set {
                this.fechaFinalField = value;
                this.RaisePropertyChanged("FechaFinal");
            }
        }

        /// <summary>
        /// Contiene el RFC del emisor del cual se quiere consultar los CFDIs
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RfcEmisor {
            get {
                return this.rfcEmisorField;
            }
            set {
                this.rfcEmisorField = value;
                this.RaisePropertyChanged("RfcEmisor");
            }
        }

        /// <summary>
        /// El RFC Solicitante corresponde al contribuyente que está realizando la solicitud de descarga.
        /// Este parámetro es opcional, pero en caso de proporcionarse debe coincidir con el RFC Emisor.
        /// Parámetro Opcional. 
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
        /// Define el tipo de comprobante: null, I = Ingreso, E = Egreso, T = Traslado, N = Nomina, P = Pago  
        /// *null es el valor predeterminado y en caso de no declararse, se obtendrán todos los comprobantes sin importar el tipo comprobante.Los valores aceptados son: I, E, T, N y P.
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TipoComprobante {
            get {
                return this.tipoComprobanteField;
            }
            set {
                this.tipoComprobanteField = value;
                this.RaisePropertyChanged("TipoComprobante");
            }
        }

        /// <summary>
        /// Define el tipo de descarga (Obligatorio).
        /// - Metadata
        /// - CFDI
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TipoDescargaMasivaTerceros TipoSolicitud {
            get {
                return this.tipoSolicitudField;
            }
            set {
                this.tipoSolicitudField = value;
                this.RaisePropertyChanged("TipoSolicitud");
            }
        }

        /// <summary>
        /// Contiene el RFC del a cuenta a tercero del cual se quiere consultar los CFDIs
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RfcACuentaTerceros {
            get {
                return this.rfcACuentaTercerosField;
            }
            set {
                this.rfcACuentaTercerosField = value;
                this.RaisePropertyChanged("RfcACuentaTerceros");
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
