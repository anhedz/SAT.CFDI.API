using System;

namespace Jaeger.SAT.CFDI.Services.Builder {
    public interface ISolicitudBuilder {
        /// <summary>
        /// Solo se buscarán CFDI, cuya fecha de emisión sea igual o mayor a la fecha inicial indicada en este parámetro Parámetro obligatorio.Este parámetro no debe declararse en caso de realizar una consulta por el folio fiscal (UUID).
        /// </summary>
        /// <param name="fechaInicial"></param>
        ISolicitudFechaInicialBuilder FechaInicial(DateTime fechaInicial);
        ISolicitudUUIDBuilder FolioFiscal(string uuid);
    }

    public interface ISolicitudFechaInicialBuilder {
        /// <summary>
        /// Solo se buscarán CFDI, cuya fecha de emisión sea igual o menor a la fecha final indicada en este parámetro. Parámetro obligatorio. Este parámetro no debe declararse en caso de realizar una consulta por el folio fiscal (UUID)
        /// </summary>
        /// <param name="fechaFinal"></param>
        /// <returns></returns>
        ISolicitudFechaFinalBuilder FechaFinal(DateTime fechaFinal);
    }

    public interface ISolicitudFechaFinalBuilder {
        /// <summary>
        /// Contiene el/los RFCs receptores de los cuales se quiere consultar los CFDIs Importante: El campo RfcReceptor, únicamente permite la captura de 5 registros como máximo.
        /// </summary>
        /// <param name="receptor"></param>
        /// <returns></returns>
        ISolicitudReceptorRFCBuilder ReceptorRFC(string receptor);
    }

    public interface ISolicitudReceptorRFCBuilder {
        /// <summary>
        /// Contiene el RFC del emisor del cual se quiere consultar los CFDI. Parámetro obligatorio.Este parámetro no debe declararse en caso de realizar una consulta por el folio fiscal (UUID).
        /// </summary>
        /// <param name="emisor"></param>
        /// <returns></returns>
        ISolicitudEmisorRFCBuilder EmisorRFC(string emisor);
    }

    public interface ISolicitudEmisorRFCBuilder {
        ISolicitudTipoSolicitudBuilder Tipo();
    }

    public interface ISolicitudTipoSolicitudBuilder {
    }

    public interface ISolicitudTipoComprobanteBuilder {
    }

    public interface ISolicitudEstadoComprobanteBuilder {
    }

    public interface ISolicitudRfcACuentaTercerosBuilder {
    }

    public interface ISolicitudComplementoBuilder {
    }

    public interface ISolicitudUUIDBuilder {
    }

    public class SolicitudBuilder : ISolicitudBuilder {
        public ISolicitudFechaInicialBuilder FechaInicial(DateTime fechaInicial) {
            throw new NotImplementedException();
        }

        public ISolicitudUUIDBuilder FolioFiscal(string uuid) {
            throw new NotImplementedException();
        }
    }
}
