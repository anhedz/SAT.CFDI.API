using System.ComponentModel;
using Jaeger.SAT.CFDI.Services.Entities;

namespace Jaeger.SAT.CFDI.Services.Enums {
    public enum TipoDescargaEnum {
        [Description("Metadata")]
        [StringValueAttribute("0")] 
        Metadata = 0,
        [Description("CFDI")]
        [StringValueAttribute("1")] 
        CFDI = 1
    }
}
