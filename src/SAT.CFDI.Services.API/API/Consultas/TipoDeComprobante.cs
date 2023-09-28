using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI.Services.API.Consultas {
    /// <remarks/>
    [GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    public enum TipoDeComprobante {

        /// <summary>
        /// I = Ingreso
        /// </summary>
        I,

        /// <summary>
        /// E = Egreso
        /// </summary>
        E,

        /// <summary>
        /// T = Traslado
        /// </summary>
        T,

        /// <summary>
        /// N = Nomina
        /// </summary>
        N,

        /// <summary>
        /// P = Pagos
        /// </summary>
        P,
    }
}
