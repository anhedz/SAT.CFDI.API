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
    public class X509DataType : PropertyChangeImplementation, INotifyPropertyChanged {
        private X509IssuerSerialType x509IssuerSerialField;
        private byte[] x509CertificateField;

        [XmlElement(Order = 0)]
        public X509IssuerSerialType X509IssuerSerial {
            get { return x509IssuerSerialField; }
            set {
                x509IssuerSerialField = value;
                OnPropertyChanged(nameof(X509IssuerSerial));
            }
        }

        [XmlElement(DataType = "base64Binary", Order = 1)]
        public byte[] X509Certificate {
            get { return x509CertificateField; }
            set {
                x509CertificateField = value;
                OnPropertyChanged(nameof(X509Certificate));
            }
        }
    }
}
