using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using Jaeger.SAT.API.Services.Helpers;
using Jaeger.SAT.API.Services.Interfaces;
using Jaeger.SAT.API.WebService.Autenticacion;

namespace Jaeger.SAT.API.Services.Abstracts {
    /// <summary>
    /// servicio de autenticacion
    /// </summary>
    internal abstract class AutenticaService : ServiceBase, IServiceBase, IBase, IAutenticaService {

        public AutenticaService() : base() {
            
        }

        public bool IsAuthenticated {
            get { return !string.IsNullOrEmpty(Token); }
        }

        /// <summary>
        /// generar token de autenticacion
        /// </summary>
        /// <returns>string</returns>
        public string GeneraToken() {
            try {
                var autenticacionClient = new AutenticacionClient(GetBinding(), GetEndpointAddress());
                ServicePointManager.ServerCertificateValidationCallback = (s, certificate, chain, sslPolicyErrors) => true;
                var x509Certificate2 = new X509Certificate2(Solicitante.GetBytes(), Solicitante.PasswordKey, X509KeyStorageFlags.DefaultKeySet);
                autenticacionClient.ClientCredentials.ClientCertificate.Certificate = x509Certificate2;
                Token = autenticacionClient.Autentica();
                LogInfoService.Log("[Genera Token] Autentica", $"[Token]: {Token}");
                return Token;
            } catch (FaultException ex) {
                LogErrorService.Log("[Genera Token] Error: " + ex.Message, ex.StackTrace);
            } catch (Exception ex) {
                LogErrorService.Log("[Genera Token] Error: " + ex.Message, ex.StackTrace);
            }
            return string.Empty;
        }

        /// <summary>
        /// se sobre escribe el metodo por modo de seguridad para evitar el error 
        /// [Genera Token] Error: An error occurred when verifying security for the message.
        /// </summary>
        /// <returns>BasicHttpBinding</returns>
        internal override BasicHttpBinding GetBinding() {
            var binding = new BasicHttpBinding {
                MaxBufferSize = 2147483647,
                MaxReceivedMessageSize = 2147483647,
                CloseTimeout = new TimeSpan(0, 10, 0),
                OpenTimeout = new TimeSpan(0, 10, 0),
                ReceiveTimeout = new TimeSpan(0, 10, 0),
                SendTimeout = new TimeSpan(0, 10, 0)
            };
            binding.Security.Mode = BasicHttpSecurityMode.TransportWithMessageCredential;
            binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.Certificate;
            return binding;
        }
    }
}
