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
    public class SignedInfoType : PropertyChangeImplementation, INotifyPropertyChanged {
        private CanonicalizationMethodType canonicalizationMethodField;
        private SignatureMethodType signatureMethodField;
        private ReferenceType referenceField;
        private string idField;

        [XmlElement(Order = 0)]
        public CanonicalizationMethodType CanonicalizationMethod {
            get { return canonicalizationMethodField; }
            set {
                canonicalizationMethodField = value;
                OnPropertyChanged(nameof(CanonicalizationMethod));
            }
        }

        [XmlElement(Order = 1)]
        public SignatureMethodType SignatureMethod {
            get { return signatureMethodField; }
            set {
                signatureMethodField = value;
                OnPropertyChanged(nameof(SignatureMethod));
            }
        }

        [XmlElement(Order = 2)]
        public ReferenceType Reference {
            get { return referenceField; }
            set {
                referenceField = value;
                OnPropertyChanged(nameof(Reference));
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
