# SAT.CFDI.API
***************************************************************************************************
*** API DE TERCEROS PARA DESCARGA MASIVA DE COMPROBANTES
***************************************************************************************************

Introducción

El “Servicio de descarga masiva de CFDI” es un sistema electrónico integral desarrollado por el 
Servicio de Administración Tributaria (SAT), en el cual se ha ampliado la capacidad de servicio 
para realizar descargas masivas de archivos XML, así como de la información de los metadatos 
(datos de resumen en archivos .txt) de los CFDI y CFDI de retenciones e información de pagos, 
mismos que se podrán consultar en el Portal del SAT por Internet, con el fin de que los 
contribuyentes recuperen sus comprobantes emitidos o recibidos.


El servicio de solicitud de descarga masiva se diseñó para permitir realizar una 
petición de descarga de CFDIs o Metadata por emisor y receptor. Esto mediante 
un servicio publicado en la página del SAT desde internet, siendo que este 
servicio solo puede ser consumido por los emisores y receptores, con lo cual se 
protege esta información.
El presente documento contiene la información necesaria para conocer y utilizar 
los siguientes elementos que forman parte del Servicio de Solicitud de Descarga 
Masiva.


* Consulta/Query
    - CodEstatus: Código de estado de la llamada.
    - Mensaje: Pequeña descripcion del código de estado.
    
* Verificación/Verify
    - CodEstatus: Código de estado de la llamada.
    - Mensaje: Pequeña descripcion del código de estado.
    - CodigoEstadoSolicitud: `CodeRequest` Estado de la solicitud de la descarga.
    - EstadoSolicitud: `StatusRequest` número correspondiente al estado de la solicitud de descarga.
    
* Descarga/Download
    - CodEstatus: Código de estado de la llamada.
    - Mensaje: Pequeña descripcion del código de estado.


Respuestas de lo servicios:

| Servicio          | Code | Descripción                                                                             |
|-------------------|------|-----------------------------------------------------------------------------------------|
| All               | 300  | Usuario no válido                                                                       |
| All               | 301  | XML mal formado                                                                         |
| All               | 302  | Sello mal formado                                                                       |
| All               | 303  | Sello no corresponde con RfcSolicitante                                                 |
| All               | 304  | Certificado revocado o caduco                                                           |
| All               | 305  | Certificado inválido                                                                    |
| All               | 5000 | Solicitud recibida con éxito                                                            |
| Query             | 5001 | Tercero no autorizado                                                                   |
| Query             | 5002 | Se agotó las solicitudes de por vida: Máximo para solicitudes con los mismos parámetros |
| Verify & download | 5004 | No se encontró la solicitud                                                             |
| Query             | 5005 | Solicitud duplicada: Si existe una solicitud vigente con los mismos parámetros          |
| Query             | 5006 | Error interno en el proceso                                                             |
| Verify & download | 404  | Error no controlado: Reintentar más tarde la petición                                   |