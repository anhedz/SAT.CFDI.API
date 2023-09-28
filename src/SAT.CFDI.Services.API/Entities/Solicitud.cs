using System;
using Jaeger.SAT.CFDI.Services.Enums;
using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Entities {
    public class Solicitud : ISolicitud {
        public Solicitud() { }
        
        public string IdSolicitud { get; set; }

        public TipoConsultaEnum TipoConsulta { get; set; }

        /// <summary>
        /// obtener o establecer tipo de descarga Metadata o CFDI
        /// </summary>
        public TipoDescargaEnum Tipo { get; set; }

        /// <summary>
        /// obtener o establecer tipo de comprobante I = Ingreso, E = Egreso, T = Traslado, N = Nomina, P = Pago, 
        /// predeterminado y en caso de no declararse, se obtendrán todos los comprobantes sin importar el tipo comprobante
        /// </summary>
        public TipoDeComprobante TipoDeComprobante { get; set; }

        /// <summary>
        /// * Null es el valor predeterminado y en caso de no declararse, se obtendrán todos los comprobantes sin importar el estado de los mismos.
        /// </summary>
        public EstadoComprobanteEnum Estado { get; set; }

        /// <summary>
        /// obtener o establecer fecha inicial de la consulta
        /// Solo se buscarán CFDI, cuya  fecha de emisión sea igual o mayor a la fecha inicial indicada en este parametro. 
        /// Parametro obligatorio. Este parametro no debe declararse en caso de realizar una consulta por el folio fiscal (UUID).
        /// </summary>
        public DateTime FechaInicial { get; set; }

        /// <summary>
        /// obtener o establecer fecha final de la consulta
        /// Solo se buscaran CFDI, cuya fecha de emision sea igual o menor a la fecha final indicada en este parametro. 
        /// Parámetro obligatorio. Este parámetro no debe declararse en caso de realizar una consulta por el folio fiscal (UUID).
        /// </summary>
        public DateTime FechaFinal { get; set; }

        /// <summary>
        /// obtener o establecer RFC's de recetptores 
        /// </summary>
        public string ReceptorRFC { get; set; }

        /// <summary>
        /// obtener o establecer el RFC del emisor del cual se requerie consultar los CFDI's, este parametro no debe declararse en caso de realizar una consulta de folio fiscal
        /// </summary>
        public string EmisorRFC { get; set; }

        /// <summary>
        /// obtener o establecer RFC del a cuenta a tercero del cual se requiere consultar los CFDI's
        /// </summary>
        public string RfcACuentaTerceros { get; set; }

        /// <summary>
        /// obtener o establecer el complemento de CFDI a descargar
        /// </summary>
        public string Complemento { get; set; }

        /// <summary>
        /// folio fiscal en formato XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX
        /// Parametro obligatorio. En caso de utilizarse este parametro no deben declararse los siguientes criterios de busqueda: FechaInicial, FechaFinal, RfcEmisor y RfcSolicitante
        /// </summary>
        public string UUID { get; set; }
    }
}
