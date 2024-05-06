// Este código solo esta presente en el servicio de verificacion.
// Está implementado en el objeto `StatusRequest` disponible desde `VerifyResult::getStatusRequest()`.
// El valor del código se puede obtener con `StatusRequest::getValue(): int`.
// Aunque la descripción no es devuelta como respuesta del servicio, se ha documentado en la clase y se puede obtener con el método `StatusRequest::getMessage(): string`.
// Este objeto también permite la comprobación por *nombre clave*, por lo que puedes usar por ejemplo `StatusRequest::isExpired()` para conocer si se encuentra en el estado `6: Vencida`.  
//| Code | Name       | Descripcion |
//|------|------------|-------------|
//| 1    | Accepted   | Aceptada    |
//| 2    | InProgress | En proceso  |
//| 3    | Finished   | Terminada   |
//| 4    | Failure    | Error       |
//| 5    | Rejected   | Rechazada   |
//| 6    | Expired    | Vencida     |

using System.ComponentModel;
using Jaeger.SAT.API.Services.Entities;

namespace Jaeger.SAT.API.Services.Enums {
    public enum EstadoSolicitudEnum {
        [Description("Aceptada")]
        [StringValueAttribute("1")]
        Accepted = 1,
        [Description("En proceso")]
        [StringValueAttribute("2")]
        InProgress = 2,
        [Description("Terminada")]
        [StringValueAttribute("3")]
        Finished = 3,
        [Description("Error")]
        [StringValueAttribute("4")]
        Error = 4,
        [Description("Rechazada")]
        [StringValueAttribute("5")]
        Rejected = 5,
        [Description("Vencida")]
        [StringValueAttribute("6")]
        Expired = 6,
    }
}
