using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.API.WebService.Abstracts;
using Jaeger.SAT.API.WebService.Base;

namespace Jaeger.SAT.API.WebService.Consultas {
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

        private DateTime fechaInicialField;

        private bool fechaInicialFieldSpecified;

        private DateTime fechaFinalField;

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
        [XmlArray(Order = 0)]
        [XmlArrayItem("RfcReceptor")]
        public string[] RfcReceptores {
            get {
                return rfcReceptoresField;
            }
            set {
                rfcReceptoresField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        [XmlElement(Namespace = "http://www.w3.org/2000/09/xmldsig#", Order = 1)]
        public SignatureType Signature {
            get {
                return signatureField;
            }
            set {
                signatureField = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Define el complemento de CFDI a descargar, null es el valor predeterminado y en caso de no declararse, se obtendrán todos los comprobantes sin importar el complemento asociado a los comprobantes
        /// </summary>
        [XmlAttribute()]
        public string Complemento {
            get {
                return complementoField;
            }
            set {
                complementoField = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Define el estao del comprobante: 0=Cancelado, 1=Vigente, Null es el valor predeterminado y en caso de no declararse, se obtendran todos los comprobantes sin importr el estado de los mismos
        /// </summary>
        [XmlAttribute()]
        public EstadoComprobante EstadoComprobante {
            get {
                return estadoComprobanteField;
            }
            set {
                estadoComprobanteField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool EstadoComprobanteSpecified {
            get {
                return estadoComprobanteFieldSpecified;
            }
            set {
                estadoComprobanteFieldSpecified = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Solo se buscarán CFDI, cuya fecha de emisión sea igual o mayor a la fecha inicial indicada en este parametro
        /// </summary>
        [XmlAttribute()]
        public DateTime FechaInicial {
            get {
                return fechaInicialField;
            }
            set {
                fechaInicialField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool FechaInicialSpecified {
            get {
                return fechaInicialFieldSpecified;
            }
            set {
                fechaInicialFieldSpecified = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Solo se buscarán CFDI, cuya fecha de emisión sea igual o menor a la fecha final indicada en este parámetro
        /// </summary>
        [XmlAttribute()]
        public DateTime FechaFinal {
            get {
                return fechaFinalField;
            }
            set {
                fechaFinalField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool FechaFinalSpecified {
            get {
                return fechaFinalFieldSpecified;
            }
            set {
                fechaFinalFieldSpecified = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string Folio {
            get {
                return folioField;
            }
            set {
                folioField = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Contiene el RFC del emisor del cual se quiere consultar los CFDIs
        /// </summary>
        [XmlAttribute()]
        public string RfcEmisor {
            get {
                return rfcEmisorField;
            }
            set {
                rfcEmisorField = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Contiene el RFC del que está realizando la solicitud de descarga.
        /// </summary>
        [XmlAttribute()]
        public string RfcSolicitante {
            get {
                return rfcSolicitanteField;
            }
            set {
                rfcSolicitanteField = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Define el tipo de comprobante I=Ingreso, E=Egreso, T=Traslado, N=Nomina, P=Pago, Null es el valor predeterminado y en caso de no declararse, se obtendran todos los comprobantes sin importa el tipo de comprobante
        /// </summary>
        [XmlAttribute()]
        public TipoDeComprobante TipoComprobante {
            get {
                return tipoComprobanteField;
            }
            set {
                tipoComprobanteField = value;
                OnPropertyChanged();
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool TipoComprobanteSpecified {
            get {
                return tipoComprobanteFieldSpecified;
            }
            set {
                tipoComprobanteFieldSpecified = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// define el tipo de descarga (Metadata o CFDI)
        /// </summary>
        [XmlAttribute()]
        public TipoDescargaMasivaTerceros TipoSolicitud {
            get {
                return tipoSolicitudField;
            }
            set {
                tipoSolicitudField = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Contiene el RFC de la cuenta a tercero del cual se requiere consultar los CFDIs
        /// </summary>
        [XmlAttribute()]
        public string RfcACuentaTerceros {
            get {
                return rfcACuentaTercerosField;
            }
            set {
                rfcACuentaTercerosField = value;
                OnPropertyChanged();
            }
        }
    }
}
