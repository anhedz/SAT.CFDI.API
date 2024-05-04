using System.Security.Cryptography.X509Certificates;
using Jaeger.SAT.CFDI.Services.API.Base;

namespace Jaeger.SAT.CFDI.Services.Helpers {
    /// <summary>
    /// new Signer().AddBytes(this.Solicitante.GetBytes()).AddPassword(this.Solicitante.PasswordKey).Signature()
    /// </summary>
    internal class Signer {
        #region declaraciones
        private byte[] _Bytes;
        private string _Password;
        #endregion

        public Signer() { }

        public Signer(byte[] bytes, string password) {
            this._Bytes = bytes;
            this._Password = password;
        }

        public Signer(string path, string password) {
            if (System.IO.File.Exists(path)) {
                this._Bytes = System.IO.File.ReadAllBytes(path);
            }
            this._Password = password;
        }

        public Signer AddBytes(byte[] bytes) {
            this._Bytes = bytes;
            return this;
        }

        /// <summary>
        /// Agregar password
        /// </summary>
        public Signer AddPassword(string password) {
            this._Password = password;
            return this;
        }

        public SignatureType Build() {
            X509Certificate2 x509Certificate2 = new X509Certificate2(this._Bytes, this._Password, X509KeyStorageFlags.DefaultKeySet);
            SignatureType signatureType = new SignatureType() {
                SignedInfo = new SignedInfoType() {
                    CanonicalizationMethod = new CanonicalizationMethodType() {
                        Algorithm = "Algorithm"
                    },
                    SignatureMethod = new SignatureMethodType() {
                        Algorithm = "Algorithm"
                    }
                }
            };

            SignedInfoType signedInfo = signatureType.SignedInfo;
            ReferenceType referenceType = new ReferenceType() {
                DigestMethod = new DigestMethodType() {
                    Algorithm = "Algorithm"
                },
                DigestValue = x509Certificate2.GetCertHash()
            };
            
            signedInfo.Reference = referenceType;
            signatureType.SignatureValue = x509Certificate2.GetPublicKey();
            KeyInfoType keyInfoType = new KeyInfoType();
            X509DataType x509DataType = new X509DataType();
            X509IssuerSerialType x509IssuerSerialType = new X509IssuerSerialType() {
                X509IssuerName = x509Certificate2.IssuerName.Name,
                X509SerialNumber = x509Certificate2.GetSerialNumberString()
            };
            
            x509DataType.X509IssuerSerial = x509IssuerSerialType;
            x509DataType.X509Certificate = x509Certificate2.RawData;
            keyInfoType.X509Data = x509DataType;
            signatureType.KeyInfo = keyInfoType;

            return signatureType;
        }
    }
}
