using Jaeger.SAT.API.Services.Entities;
using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.Services.Helpers {
    internal static class Extensions {
        /// <summary>
        /// convertir objeto RespuestaSolicitudDescMasTercero a IQueryResponse
        /// </summary>
        public static IQueryResponse ToTraslate(this WebService.Consultas.RespuestaSolicitudDescMasTercero respuesta) {
            return new QueryResponse()
                .AddIdSolicitud(respuesta.IdSolicitud)
                .AddXML(XmlSerializerService.SerializeObject(respuesta))
                .AddStatusCode(new StatusCode(respuesta.CodEstatus, respuesta.Mensaje));
        }

        public static IQueryResponse ToTraslate(this WebService.Solicitud.RespuestaSolicitudDescMasTercero respuesta) {
            return new QueryResponse()
                .AddIdSolicitud(respuesta.IdSolicitud)
                .AddXML(XmlSerializerService.SerializeObject(respuesta))
                .AddStatusCode(new StatusCode(respuesta.CodEstatus, respuesta.Mensaje));
        }
    }
}
