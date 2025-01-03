using System;

namespace Jaeger.SAT.API.Services.Entities {
    /// <summary>
    ///     Token de autorizacion para autenticar peticiones con el web service de descarga masiva de CFDIs del SAT
    /// </summary>
    public sealed class AccessToken {
        private AccessToken(string value) {
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///     Valor del Token tomado del resultado de la peticion de autenticacion
        /// </summary>
        public string Value { get; }

        public bool IsValid { get { return !string.IsNullOrWhiteSpace(Value); } }

        public static AccessToken CreateInstance(string token) {
            return new AccessToken(token);
        }

        public static AccessToken CreateEmpty() {
            return new AccessToken(string.Empty);
        }
    }
}
