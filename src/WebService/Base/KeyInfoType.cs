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
    public class KeyInfoType : PropertyChangeImplementation {
        private X509DataType x509DataField;
        private string keyNameField;
        private KeyValueType keyValueField;
        private string[] textField;
        private string idField;

        [XmlElement(Order = 0)]
        public X509DataType X509Data {
            get { return x509DataField; }
            set {
                x509DataField = value;
                OnPropertyChanged(nameof(X509Data));
            }
        }

        [XmlElement(Order = 1)]
        public string KeyName {
            get { return keyNameField; }
            set {
                keyNameField = value;
                OnPropertyChanged(nameof(KeyName));
            }
        }

        [XmlElement(Order = 2)]
        public KeyValueType KeyValue {
            get { return keyValueField; }
            set {
                keyValueField = value;
                OnPropertyChanged(nameof(KeyValue));
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

        [XmlAttribute(DataType = "ID")]
        public string Id {
            get { return idField; }
            set {
                idField = value;
                OnPropertyChanged(nameof(Id));
            }
        }
    }
}
