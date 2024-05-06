using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.ServiceModel;

namespace Jaeger.SAT.API.WebService.Descargas {
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = true, WrapperName = "RespuestaDescargaMasivaTercerosSalida", WrapperNamespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    public class RespuestaDescargaMasivaTercerosSalida {

        [MessageHeader(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
        public RespuestaDescargaMasivaTerceros respuesta;

        [MessageBodyMember(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx", Order = 0)]
        public Stream Paquete;

        public RespuestaDescargaMasivaTercerosSalida() {
        }

        public RespuestaDescargaMasivaTercerosSalida(RespuestaDescargaMasivaTerceros respuesta, Stream Paquete) {
            this.respuesta = respuesta;
            this.Paquete = Paquete;
        }
    }
}
