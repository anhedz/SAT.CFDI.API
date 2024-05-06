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
    public class ReferenceType : PropertyChangeImplementation {
        private TransformType[] transformsField;
        private DigestMethodType digestMethodField;
        private byte[] digestValueField;
        private string idField;
        private string uRIField;
        private string typeField;

        [XmlArray(Order = 0)]
        [XmlArrayItem("Transform", IsNullable = false)]
        public TransformType[] Transforms {
            get { return transformsField; }
            set {
                transformsField = value;
                OnPropertyChanged(nameof(Transforms));
            }
        }

        [XmlElement(Order = 1)]
        public DigestMethodType DigestMethod {
            get { return digestMethodField; }
            set {
                digestMethodField = value;
                OnPropertyChanged(nameof(DigestMethod));
            }
        }

        [XmlElement(DataType = "base64Binary", Order = 2)]
        public byte[] DigestValue {
            get { return digestValueField; }
            set {
                digestValueField = value;
                OnPropertyChanged(nameof(DigestValue));
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

        [XmlAttribute(DataType = "anyURI")]
        public string URI {
            get { return uRIField; }
            set {
                uRIField = value;
                OnPropertyChanged(nameof(URI));
            }
        }

        [XmlAttribute(DataType = "anyURI")]
        public string Type {
            get { return typeField; }
            set {
                typeField = value;
                OnPropertyChanged(nameof(Type));
            }
        }
    }
}
