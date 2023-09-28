using System.ComponentModel;
using Jaeger.SAT.CFDI.Services.Entities;

namespace Jaeger.SAT.CFDI.Services.Enums {
    public enum EstadoComprobanteEnum {
        /// <summary>
        /// Todos (NULL)
        /// </summary>
        [Description("Todos")]
        [StringValueAttribute("-1")]
        Todos = -1,
        /// <summary>
        /// Cancelado = 0
        /// </summary>
        [Description("Cancelado")]
        [StringValueAttribute("0")]
        Cancelado = 0,
        /// <summary>
        /// Vigente = 1
        /// </summary>
        [Description("Vigente")]
        [StringValueAttribute("1")]
        Vigente = 1
    }
}
