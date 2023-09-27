using System.ComponentModel;

namespace Jaeger.SAT.CFDI.Services.Enums {
    /// <summary>
    /// tipo de consulta Emitidos = 1 o Recibidos = 2
    /// </summary>
    public enum TipoConsultaEnum {
        /// <summary>
        /// comprobantes emitidos
        /// </summary>
        [Description("Emitidos")]
        Emitidos = 1,
        /// <summary>
        /// comprobantes recibidos
        /// </summary>
        [Description("Recibidos")]
        Recibidos = 2
    }
}
