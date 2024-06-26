﻿using System;
using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.Services.Entities {
    /// <summary>
    /// Informacion del Solicitante
    /// </summary>
    public class Solicitante : ISolicitante {
        public Solicitante() { }

        /// <summary>
        /// obtener o establecer registro federal de contribuyentes
        /// </summary>
        public string RFC { get; set; }

        /// <summary>
        /// obtener o establecer password
        /// </summary>
        public string PasswordKey { get; set; }

        /// <summary>
        /// obtener o establecer contenido del certificado en formato PFX
        /// </summary>
        public string B64PFX { get; set; }

        public byte[] GetBytes() {
            return Convert.FromBase64String(B64PFX);
        }
    }
}
