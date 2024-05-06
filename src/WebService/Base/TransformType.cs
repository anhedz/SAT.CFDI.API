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
    public class TransformType : PropertyChangeImplementation, INotifyPropertyChanged {
        private string xPathField;
        private string[] textField;
        private string algorithmField;

        [XmlElement(Order = 0)]
        public string XPath {
            get { return xPathField; }
            set {
                xPathField = value;
                OnPropertyChanged(nameof(XPath));
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
