using System.ComponentModel;
using Jaeger.SAT.API.Services.Entities;

namespace Jaeger.SAT.API.Services.Enums {
    public enum TipoDescargaEnum {
        [Description("Metadata")]
        [StringValueAttribute("0")]
        Metadata = 0,
        [Description("CFDI")]
        [StringValueAttribute("1")]
        CFDI = 1
    }
}
