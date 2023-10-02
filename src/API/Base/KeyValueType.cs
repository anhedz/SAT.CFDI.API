using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using Jaeger.SAT.CFDI.Services.API.Abstracts;

namespace Jaeger.SAT.CFDI.Services.API.Base {
    [GeneratedCode("System.Xml", "4.7.2612.0")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [Serializable]
    public class KeyValueType : PropertyChangeImplementation {
        private RSAKeyValueType rSAKeyValueField;
        private string[] textField;

        [XmlElement(Order = 0)]
        public RSAKeyValueType RSAKeyValue {
            get { return rSAKeyValueField; }
            set {
                rSAKeyValueField = value;
                OnPropertyChanged(nameof(RSAKeyValue));
            }
        }

        [XmlText]
        public string[] Text {
            get { return textField; }
            set {
                textField = value;
                OnPropertyChanged(nameof(Text));
            }
        }
    }
}
