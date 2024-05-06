using System.ComponentModel;
using Jaeger.SAT.API.Services.Entities;

namespace Jaeger.SAT.API.Services.Enums {
    public enum TipoDeComprobante {
        [Description("Todos")]
        [StringValueAttribute("")]
        Todos,
        /// <summary>
        /// I = Ingreso
        /// </summary>
        [Description("Ingreso")]
        [StringValueAttribute("")]
        Ingreso,

        /// <summary>
        /// E = Egreso
        /// </summary>
        [Description("Egreso")]
        [StringValueAttribute("")]
        Egreso,

        /// <summary>
        /// T = Traslado
        /// </summary>
        [Description("Traslado")]
        [StringValueAttribute("")]
        Traslado,

        /// <summary>
        /// N = Nomina
        /// </summary>
        [Description("Nómina")]
        [StringValueAttribute("")]
        Nomina,

        /// <summary>
        /// P = Pagos
        /// </summary>
        [Description("Pagos")]
        [StringValueAttribute("")]
        Pagos,
    }
}
