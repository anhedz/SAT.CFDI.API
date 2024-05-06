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
    public class SignatureType : PropertyChangeImplementation, INotifyPropertyChanged {
        private SignedInfoType signedInfoField;
        private byte[] signatureValueField;
        private KeyInfoType keyInfoField;
        private ObjectType[] objectField;
        private string idField;

        [XmlElement(Order = 0)]
        public SignedInfoType SignedInfo {
            get { return signedInfoField; }
            set {
                signedInfoField = value;
                OnPropertyChanged(nameof(SignedInfo));
            }
        }

        [XmlElement(DataType = "base64Binary", Order = 1)]
        public byte[] SignatureValue {
            get { return signatureValueField; }
            set {
                signatureValueField = value;
                OnPropertyChanged(nameof(SignatureValue));
            }
        }

        [XmlElement(Order = 2)]
        public KeyInfoType KeyInfo {
            get { return keyInfoField; }
            set {
                keyInfoField = value;
                OnPropertyChanged(nameof(KeyInfo));
            }
        }

        [XmlElement("Object", Order = 3)]
        public ObjectType[] Object {
            get { return objectField; }
            set {
                objectField = value;
                OnPropertyChanged(nameof(Object));
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
