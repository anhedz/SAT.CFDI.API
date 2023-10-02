using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using Jaeger.SAT.CFDI.Services.API.Abstracts;

namespace Jaeger.SAT.CFDI.Services.API.Base {
    [GeneratedCode("System.Xml", "4.7.2612.0")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [Serializable]
    public class CanonicalizationMethodType : PropertyChangeImplementation {
        private XmlNode[] anyField;
        private string algorithmField;

        [XmlText]
        [XmlAnyElement(Order = 0)]
        public XmlNode[] Any {
            get { return anyField; }
            set {
                anyField = value;
                OnPropertyChanged(nameof(Any));
            }
        }

        [XmlAttribute(DataType = "anyURI")]
        public string Algorithm {
            get { return algorithmField; }
            set {
                algorithmField = value;
                OnPropertyChanged(nameof(Algorithm));
            }
        }
    }
}
