using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Jaeger.SAT.API.WebService.Consultas {
    /// <remarks/>
    [GeneratedCode("System.Xml", "4.8.4084.0")]
    [Serializable()]
    [XmlType(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    public enum EstadoComprobante {

        /// <remarks/>
        [XmlEnum("0")]
        Cancelado,

        /// <remarks/>
        [XmlEnum("1")]
        Vigente,
    }
}
