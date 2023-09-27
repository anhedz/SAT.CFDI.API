using System;
using System.IO;
using Jaeger.SAT.CFDI.API.Consultas;
using Jaeger.SAT.CFDI.API.Descargas;
using Jaeger.SAT.CFDI.Enums;
using Jaeger.SAT.CFDI.API.Verificacion;

namespace Jaeger.SAT.CFDI.API.Contracts {
    public interface IWebServiceSAT {

        string RutaDescarga { get; set; }

        bool GeneraToken();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eTipoDescargaMasivaTerceros">Metadata o CFDI</param>
        /// <param name="eTipoConsultaEnum">Emitido o Recibido</param>
        /// <param name="dFechaInicial">Fecha inicial de la consulta</param>
        /// <param name="dFechaFinal">Fecha final de la consulta</param>
        /// <returns></returns>
        RespuestaSolicitudDescMasTercero Consulta(TipoDescargaMasivaTerceros eTipoDescargaMasivaTerceros, TipoConsultaEnum eTipoConsultaEnum, DateTime dFechaInicial, DateTime dFechaFinal);

        RespuestaVerificaSolicitudDescMasTercero Verifica(string sIdSolicitud);

        RespuestaDescargaMasivaTerceros Descarga(string sIdPaquete, ref Stream sPaquete);

        bool GuardarPaquete(string sIdPaquete, Stream sPaquete);
    }
}
