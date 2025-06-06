using System.ComponentModel;

namespace Jaeger.SAT.API.Services.Enums {
    /// <summary>
    /// tipo de consulta Emitidos = 1, Recibidos = 2, Folio = 3
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
        Recibidos = 2,
        /// <summary>
        /// folio fiscal XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX
        /// </summary>
        [Description("Folio")]
        Folio = 3,
    }
}
