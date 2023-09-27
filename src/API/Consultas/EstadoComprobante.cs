using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Jaeger.SAT.CFDI.Services.API.Consultas {
    /// <remarks/>
    [GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    public enum EstadoComprobante {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Cancelado,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Vigente,
    }
}
