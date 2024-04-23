using Jaeger.SAT.CFDI.Services.API.Consultas;
using Jaeger.SAT.CFDI.Services.Entities;
using Jaeger.SAT.CFDI.Services.Interfaces;

namespace Jaeger.SAT.CFDI.Services.Helpers {
    public static class Extensions {
        /// <summary>
        /// convertir objeto RespuestaSolicitudDescMasTercero a IQueryResponse
        /// </summary>
        public static IQueryResponse ToTraslate(this RespuestaSolicitudDescMasTercero respuesta) {
            return new QueryResponse()
                .AddIdSolicitud(respuesta.IdSolicitud)
                .AddXML(XmlSerializerService.SerializeObject(respuesta))
                .AddStatusCode(new StatusCode(respuesta.CodEstatus, respuesta.Mensaje));
        }
    }
}
