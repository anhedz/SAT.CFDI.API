using System;

namespace Jaeger.SAT.CFDI.Services.Builder {
    public class SolicitudBuilder : ISolicitudBuilder {
        public ISolicitudFechaInicialBuilder FechaInicial(DateTime fechaInicial) {
            throw new NotImplementedException();
        }

        public ISolicitudUUIDBuilder FolioFiscal(string uuid) {
            throw new NotImplementedException();
        }
    }
}
