using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Jaeger.SAT.CFDI.Services.API.Descargas {
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = true, WrapperName = "PeticionDescargaMasivaTercerosEntrada", WrapperNamespace = "http://DescargaMasivaTerceros.sat.gob.mx")]
    public class PeticionDescargaMasivaTercerosEntrada {
        [MessageBodyMember(Namespace = "http://DescargaMasivaTerceros.sat.gob.mx", Order = 0)]
        public PeticionDescargaMasivaTerceros peticionDescarga;

        public PeticionDescargaMasivaTercerosEntrada() {
        }

        public PeticionDescargaMasivaTercerosEntrada(PeticionDescargaMasivaTerceros peticionDescarga) { 
            this.peticionDescarga = peticionDescarga; 
        }
    }
}
