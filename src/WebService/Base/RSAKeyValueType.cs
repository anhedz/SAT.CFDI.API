using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.API.WebService.Abstracts;

namespace Jaeger.SAT.API.WebService.Base {
    [GeneratedCode("System.Xml", "4.7.2612.0")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [Serializable]
    public class RSAKeyValueType : PropertyChangeImplementation {
        private byte[] modulusField;
        private byte[] exponentField;

        [XmlElement(DataType = "base64Binary", Order = 0)]
        public byte[] Modulus {
            get { return modulusField; }
            set {
                modulusField = value;
                OnPropertyChanged(nameof(Modulus));
            }
        }

        [XmlElement(DataType = "base64Binary", Order = 1)]
        public byte[] Exponent {
            get { return exponentField; }
            set {
                exponentField = value;
                OnPropertyChanged(nameof(Exponent));
            }
        }
    }
}
