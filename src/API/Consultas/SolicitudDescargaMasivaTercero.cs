using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.CFDI.Services.API.Abstracts;
using Jaeger.SAT.CFDI.Services.API.Base;

namespace Jaeger.SAT.CFDI.Services.API.Consultas {
    [GeneratedCode("System.Xml", "4.7.2612.0")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    [Serializable]
    public class SolicitudDescargaMasivaTercero : PropertyChangeImplementation {
        private string[] rfcReceptoresField;

        private SignatureType signatureField;

        private string complementoField;

        private EstadoComprobante estadoComprobanteField;

        private bool estadoComprobanteFieldSpecified;

        private System.DateTime fechaInicialField;

        private bool fechaInicialFieldSpecified;

        private System.DateTime fechaFinalField;

        private bool fechaFinalFieldSpecified;

        private string folioField;

        private string rfcEmisorField;

        private string rfcSolicitanteField;

        private TipoDeComprobante tipoComprobanteField;

        private bool tipoComprobanteFieldSpecified;

        private TipoDescargaMasivaTerceros tipoSolicitudField;

        private string rfcACuentaTercerosField;

        /// <summary>
        /// Contiene el/los RFC’s receptores de los cuales se quiere consultar los CFDIs Importante: El campo RfcReceptor, únicamente permite la captura de 5 registros como máximo
        /// </summary>
        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("RfcReceptor")]
        public string[] RfcReceptores {
            get {
                return this.rfcReceptoresField;
            }
            set {
                this.rfcReceptoresField = value;
                this.OnPropertyChanged();
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", Order = 1)]
        public SignatureType Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// Define el complemento de CFDI a descargar, null es el valor predeterminado y en caso de no declararse, se obtendrán todos los comprobantes sin importar el complemento asociado a los comprobantes
        /// </summary>
        [XmlAttributeAttribute()]
        public string Complemento {
            get {
                return this.complementoField;
            }
            set {
                this.complementoField = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// Define el estao del comprobante: 0=Cancelado, 1=Vigente, Null es el valor predeterminado y en caso de no declararse, se obtendran todos los comprobantes sin importr el estado de los mismos
        /// </summary>
        [XmlAttributeAttribute()]
        public EstadoComprobante EstadoComprobante {
            get {
                return this.estadoComprobanteField;
            }
            set {
                this.estadoComprobanteField = value;
                this.OnPropertyChanged();
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool EstadoComprobanteSpecified {
            get {
                return this.estadoComprobanteFieldSpecified;
            }
            set {
                this.estadoComprobanteFieldSpecified = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// Solo se buscarán CFDI, cuya fecha de emisión sea igual o mayor a la fecha inicial indicada en este parametro
        /// </summary>
        [XmlAttributeAttribute()]
        public System.DateTime FechaInicial {
            get {
                return this.fechaInicialField;
            }
            set {
                this.fechaInicialField = value;
                this.OnPropertyChanged();
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool FechaInicialSpecified {
            get {
                return this.fechaInicialFieldSpecified;
            }
            set {
                this.fechaInicialFieldSpecified = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// Solo se buscarán CFDI, cuya fecha de emisión sea igual o menor a la fecha final indicada en este parámetro
        /// </summary>
        [XmlAttributeAttribute()]
        public System.DateTime FechaFinal {
            get {
                return this.fechaFinalField;
            }
            set {
                this.fechaFinalField = value;
                this.OnPropertyChanged();
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool FechaFinalSpecified {
            get {
                return this.fechaFinalFieldSpecified;
            }
            set {
                this.fechaFinalFieldSpecified = value;
                this.OnPropertyChanged();
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string Folio {
            get {
                return this.folioField;
            }
            set {
                this.folioField = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// Contiene el RFC del emisor del cual se quiere consultar los CFDIs
        /// </summary>
        [XmlAttributeAttribute()]
        public string RfcEmisor {
            get {
                return this.rfcEmisorField;
            }
            set {
                this.rfcEmisorField = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// Contiene el RFC del que está realizando la solicitud de descarga.
        /// </summary>
        [XmlAttributeAttribute()]
        public string RfcSolicitante {
            get {
                return this.rfcSolicitanteField;
            }
            set {
                this.rfcSolicitanteField = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// Define el tipo de comprobante I=Ingreso, E=Egreso, T=Traslado, N=Nomina, P=Pago, Null es el valor predeterminado y en caso de no declararse, se obtendran todos los comprobantes sin importa el tipo de comprobante
        /// </summary>
        [XmlAttributeAttribute()]
        public TipoDeComprobante TipoComprobante {
            get {
                return this.tipoComprobanteField;
            }
            set {
                this.tipoComprobanteField = value;
                this.OnPropertyChanged();
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool TipoComprobanteSpecified {
            get {
                return this.tipoComprobanteFieldSpecified;
            }
            set {
                this.tipoComprobanteFieldSpecified = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// define el tipo de descarga (Metadata o CFDI)
        /// </summary>
        [XmlAttributeAttribute()]
        public TipoDescargaMasivaTerceros TipoSolicitud {
            get {
                return this.tipoSolicitudField;
            }
            set {
                this.tipoSolicitudField = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// Contiene el RFC de la cuenta a tercero del cual se requiere consultar los CFDIs
        /// </summary>
        [XmlAttributeAttribute()]
        public string RfcACuentaTerceros {
            get {
                return this.rfcACuentaTercerosField;
            }
            set {
                this.rfcACuentaTercerosField = value;
                this.OnPropertyChanged();
            }
        }
    }
}
