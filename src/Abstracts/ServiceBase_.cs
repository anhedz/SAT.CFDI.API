using System;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using Jaeger.SAT.CFDI.API.Base;
using Jaeger.SAT.CFDI.Helpers;

namespace Jaeger.SAT.CFDI.API.Abstracts {
    public abstract class ServiceBase {
        #region declaraciones
        private byte[] sArchivoPFX;
        private string _PasswordKey;
        private string _Token;
        private string _RfcSolicitante;
        private string _urlEndpointAddres;
        #endregion

        public ServiceBase(string sRfcSolicitante, byte[] sPFX, string sPasswordKey, string sToken) {
            _RfcSolicitante = sRfcSolicitante;
            sArchivoPFX = sPFX;
            _PasswordKey = sPasswordKey;
            _Token = sToken;
        }

        #region declaraciones
        public byte[] PFX {
            get { return sArchivoPFX; }
            set { sArchivoPFX = value; }
        }

        public string PasswordKey {
            get { return _PasswordKey; }
            set { _PasswordKey = value; }
        }

        public string Token {
            get { return _Token; }
            set { _Token = value; }
        }

        public string URL {
            get { return _urlEndpointAddres; }
            set { _urlEndpointAddres = value; }
        }

        public string RfcSolicitante {
            get { return _RfcSolicitante; }
            set { _RfcSolicitante = value; }
        }
        #endregion

        internal virtual EndpointAddress GetEndpointAddress() {
            return new EndpointAddress(URL);
        }

        internal virtual BasicHttpBinding GetBinding() {
            var _Binding = new BasicHttpBinding {
                MaxBufferSize = 2147483647,
                MaxReceivedMessageSize = 2147483647,
                CloseTimeout = new TimeSpan(0, 5, 0),
                OpenTimeout = new TimeSpan(0, 5, 0),
                ReceiveTimeout = new TimeSpan(0, 10, 0),
                SendTimeout = new TimeSpan(0, 5, 0)
            };
            _Binding.Security.Mode = BasicHttpSecurityMode.Transport;
            return _Binding;
        }

        internal virtual SignatureType CreateDigest() {
            var signatureType = new SignatureType();
            try {
                var x509Certificate2 = new X509Certificate2(this.PFX, this.PasswordKey, X509KeyStorageFlags.DefaultKeySet);
                signatureType.SignedInfo = new SignedInfoType {
                    CanonicalizationMethod = new CanonicalizationMethodType()
                };
                signatureType.SignedInfo.CanonicalizationMethod.Algorithm = "Algorithm";
                signatureType.SignedInfo.SignatureMethod = new SignatureMethodType {
                    Algorithm = "Algorithm"
                };
                signatureType.SignedInfo.Reference = new ReferenceType() {
                    DigestMethod = new DigestMethodType() {
                        Algorithm = "Algorithm"
                    },
                    DigestValue = x509Certificate2.GetCertHash()
                };
                signatureType.SignatureValue = x509Certificate2.GetPublicKey();
                signatureType.KeyInfo = new KeyInfoType() {
                    X509Data = new X509DataType() {
                        X509IssuerSerial = new X509IssuerSerialType() {
                            X509IssuerName = x509Certificate2.IssuerName.Name,
                            X509SerialNumber = x509Certificate2.GetSerialNumberString()
                        },
                        X509Certificate = x509Certificate2.RawData
                    }
                };
            } catch (Exception ex) {
                LogErrorService.EscribirLog("[Generar Token Consulta SignatureType] Error: " + ex.Message, ex.StackTrace);
            }
            return signatureType;
        }
    }
}
