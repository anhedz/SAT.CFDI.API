using System;
using Jaeger.SAT.API.Services.Enums;

namespace Jaeger.SAT.API.Services.Interfaces {
    /// <summary>
    /// solicitud de descarga de CFDIs o Metadata
    /// </summary>
    public interface ISolicitud {
        /// <summary>
        /// obtener o establecer Contiene el resultado de la peticion con el codigo de respuesta y los UUID de los CFDIs de los cuales se solicito la descarga, pero se encuentran en espera 
        /// de una confirmación por parte del receptor
        /// </summary>
        string IdSolicitud { get; set; }

        /// <summary>
        /// tipo de consulta Emitidos = 1 o Recibidos = 2
        /// </summary>
        TipoConsultaEnum TipoConsulta { get; set; }

        /// <summary>
        /// obtener o establecer tipo de descarga Metadata o CFDI
        /// </summary>
        TipoDescargaEnum Tipo { get; set; }

        /// <summary>
        /// obtener o establecer tipo de comprobante I = Ingreso, E = Egreso, T = Traslado, N = Nomina, P = Pago, 
        /// predeterminado y en caso de no declararse, se obtendrán todos los comprobantes sin importar el tipo comprobante
        /// </summary>
        TipoDeComprobante TipoDeComprobante { get; set; }

        /// <summary>
        /// * Null es el valor predeterminado y en caso de no declararse, se obtendrán todos los comprobantes sin importar el estado de los mismos.
        /// </summary>
        EstadoComprobanteEnum Estado { get; set; }

        /// <summary>
        /// obtener o establecer fecha inicial de la consulta
        /// Solo se buscarán CFDI, cuya  fecha de emisión sea igual o mayor a la fecha inicial indicada en este parametro. 
        /// Parametro obligatorio. Este parametro no debe declararse en caso de realizar una consulta por el folio fiscal (UUID).
        /// </summary>
        DateTime FechaInicial { get; set; }

        /// <summary>
        /// obtener o establecer fecha final de la consulta
        /// Solo se buscaran CFDI, cuya fecha de emision sea igual o menor a la fecha final indicada en este parametro. 
        /// Parámetro obligatorio. Este parámetro no debe declararse en caso de realizar una consulta por el folio fiscal (UUID).
        /// </summary>
        DateTime FechaFinal { get; set; }

        /// <summary>
        /// obtener o establecer RFC's de recetptores 
        /// </summary>
        string ReceptorRFC { get; set; }

        /// <summary>
        /// obtener o establecer el RFC del emisor del cual se requerie consultar los CFDI's, este parametro no debe declararse en caso de realizar una consulta de folio fiscal
        /// </summary>
        string EmisorRFC { get; set; }

        /// <summary>
        /// obtener o establecer RFC del a cuenta a tercero del cual se requiere consultar los CFDI's
        /// </summary>
        string RfcACuentaTerceros { get; set; }

        /// <summary>
        /// obtener o establecer el complemento de CFDI a descargar
        /// </summary>
        string Complemento { get; set; }

        /// <summary>
        /// folio fiscal en formato XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX
        /// Parametro obligatorio. En caso de utilizarse este parametro no deben declararse los siguientes criterios de busqueda: FechaInicial, FechaFinal, RfcEmisor y RfcSolicitante
        /// </summary>
        string UUID { get; set; }
    }
}
