using System.ComponentModel;
using Jaeger.SAT.API.Services.Entities;

namespace Jaeger.SAT.API.Services.Enums {
    /// <summary>
    /// Codigos de status de solicitud
    /// </summary>
    public enum CodEstatusEnum {
        /// <summary>
        /// 300 Usuario No Válido
        /// </summary>
        [Description("300 Usuario No Válido")]
        [StringValueAttribute("300")]
        UsuarioNoValido = 300,
        /// <summary>
        /// XML Mal Formado
        /// </summary>
        [Description("Xml Mal Formado")]
        [StringValueAttribute("301")]
        XmlMalFormado = 301,
        /// <summary>
        /// PFX Incorrecto
        /// </summary>
        //[Description("PFX Incorrecto")]
        //[StringValueAttribute("302")]
        //PFXIncorrecto = 302,
        /// <summary>
        /// Sello Mal Formado
        /// </summary>
        [Description("Sello Mal Formado")]
        SelloMalFormado = 302,
        /// <summary>
        /// Sello no corresponde con RfcSolicitante
        /// </summary>
        [Description("Sello no corresponde con RfcSolicitante")]
        [StringValueAttribute("303")]
        SelloNoCorresponse = 303,
        /// <summary>
        /// El certificado puede ser invalido por múltiples razones como son el tipo, la vigencia, etc.
        /// </summary>
        [Description("Certificado Revocado o Caduco")]
        [StringValueAttribute("304")]
        CertificadoRevocado = 304,
        /// <summary>
        /// Certificado Inválido El certificado puede ser invalido por múltiples razones como son el tipo, la vigencia, etc.
        /// </summary>
        [Description("Certificado Inválido")]
        [StringValueAttribute("305")]
        CertificadoInvalido = 305,
        /// <summary>
        /// Error no controlado: Reintentar más tarde la petición
        /// </summary>
        [Description("Error no controlado: Reintentar más tarde la petición")]
        [StringValueAttribute("404")]
        NoControlado = 404,
        /// <summary>
        /// Solicitud de descarga recibida con éxito
        /// </summary>
        [Description("Solicitud de descarga recibida con éxito")]
        [StringValueAttribute("5000")]
        SolicitudAceptada = 5000,
        /// <summary>
        /// Tercero no autorizado El solicitante no tiene autorización de descarga de xml de los contribuyentes
        /// </summary>
        [Description("Tercero no autorizado")]
        [StringValueAttribute("5001")]
        TerceroNoAutorizado = 5001,
        /// <summary>
        /// Se han agotado las solicitudes de por vida. Se ha alcanzado el límite de solicitudes, con el mismo criterio
        /// </summary>
        [Description("Se han agotado las solicitudes de por vida")]
        [StringValueAttribute("5002")]
        SolicitudAgotada = 5002,
        /// <summary>
        /// Tope máximo: Indica que se está superando el tope máximo de CFDI o Metadata
        /// </summary>
        [Description("Tope máximo: Indica que se está superando el tope máximo de CFDI o Metadata")]
        [StringValueAttribute("5003")]
        MaximumLimitReaded = 5003,
        /// <summary>
        /// Sin informacion
        /// </summary>
        [Description("Sin Información")]
        [StringValueAttribute("5004")]
        SinInformacion = 5004,
        /// <summary>
        /// Ya se tiene una solicitud registrada. Ya existe una solicitud activa con los mismos criterios
        /// </summary>
        [Description("Ya se tiene una solicitud registrada")]
        [StringValueAttribute("5005")]
        SolicitudExistente = 5005,
        /// <summary>
        /// Error interno en el proceso
        /// </summary>
        [Description("Error interno en el proceso")]
        [StringValueAttribute("5006")]
        ErrorInterno = 5006,
        /// <summary>
        /// No se encontró el paquete SAT o caduco a las 72hrs.
        /// </summary>
        [Description("No se encontró el paquete SAT o caduco a las 72hrs.")]
        [StringValueAttribute("5007")]
        NoEncontrado = 5007,
        /// <summary>
        /// Se alcanzaron las 2 descargas permitidas por solicitud
        /// </summary>
        [Description("Se alcanzaron las 2 descargas permitidas por solicitud")]
        [StringValueAttribute("5008")]
        DescargaPermitida = 5008
    }
}
