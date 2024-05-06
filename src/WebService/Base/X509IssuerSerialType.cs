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
    public class X509IssuerSerialType : PropertyChangeImplementation {
        private string x509IssuerNameField;
        private string x509SerialNumberField;

        [XmlElement(Order = 0)]
        public string X509IssuerName {
            get { return x509IssuerNameField; }
            set {
                x509IssuerNameField = value;
                OnPropertyChanged(nameof(X509IssuerName));
            }
        }

        [XmlElement(DataType = "integer", Order = 1)]
        public string X509SerialNumber {
            get { return x509SerialNumberField; }
            set {
                x509SerialNumberField = value;
                OnPropertyChanged(nameof(X509SerialNumber));
            }
        }
    }
}
