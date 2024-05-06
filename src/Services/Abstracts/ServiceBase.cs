using System;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using Jaeger.SAT.API.Services.Entities;
using Jaeger.SAT.API.Services.Helpers;
using Jaeger.SAT.API.Services.Interfaces;
using Jaeger.SAT.API.WebService.Base;

namespace Jaeger.SAT.API.Services.Abstracts {
    public abstract class ServiceBase : Base, IServiceBase, IBase {
        #region declaraciones
        private string _Token;
        private string _urlEndpointAddres;
        #endregion

        public ServiceBase() : base() { }

        protected internal ServiceBase AddURL(string url) {
            _urlEndpointAddres = url;
            return this;
        }

        #region propiedades
        /// <summary>
        /// URL del servicio
        /// </summary>
        public string URL {
            get { return _urlEndpointAddres; }
            set { _urlEndpointAddres = value; }
        }

        /// <summary>
        /// identificador de autenticacion del servicio
        /// </summary>
        public string Token {
            get { return _Token; }
            set { _Token = value; }
        }

        public ICodeError CodeError { get; internal set; }
        #endregion

        /// <summary>
        /// endpoint del servicio
        /// </summary>
        internal virtual EndpointAddress GetEndpointAddress() {
            return new EndpointAddress(URL);
        }

        /// <summary>
        /// se sobre escribe el metodo por modo de seguridad para evitar el error 
        /// [Genera Token] Error: An error occurred when verifying security for the message.
        /// </summary>
        /// <returns>BasicHttpBinding</returns>
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
                var x509Certificate2 = new X509Certificate2(Solicitante.GetBytes(), Solicitante.PasswordKey, X509KeyStorageFlags.DefaultKeySet);
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
                CodeError = new CodeError(0, "[Generar Token Consulta SignatureType] Error: " + ex.Message);
                LogErrorService.Write("[Generar Token Consulta SignatureType] Error: " + ex.Message, ex.StackTrace);
            }
            return signatureType;
        }
    }
}
