using System;
using System.IO;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Web;
using Jaeger.SAT.API.Services.Helpers;
using Jaeger.SAT.API.Services.Interfaces;
using Jaeger.SAT.API.WebService.Descargas;
using Jaeger.SAT.API.Services.Entities;

namespace Jaeger.SAT.API.Services.Abstracts {
    /// <summary>
    /// Es un servicio web que permite realizar solicitudes de descarga de CFDIs o Metadata por un rango de fechas, para que la petición sea aceptada debe ser 
    /// realizada por el emisor o receptor de los CFDIs de los cuales se quiere descargar.
    /// </summary>
    internal abstract class DescargaService : ServiceBase, IServiceBase, IBase, IDescargaService {
        #region
        protected internal string _IdPackage;
        #endregion

        /// <summary>
        /// constructor
        /// </summary>
        public DescargaService() : base() { }

        /// <summary>
        /// Agregar identificador de paquete
        /// </summary>
        /// <param name="idPaquete">idpaquete</param>
        public void AddIdPaquete(string idPaquete) {
            _IdPackage = idPaquete;
        }

        /// <summary>
        /// Agregar token
        /// </summary>
        /// <param name="token">token</param>
        /// <returns>IDescargaService</returns>
        public IDescargaService AddToken(string token) {
            Token = token;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sPaquete"></param>
        /// <returns></returns>
        public RespuestaDescargaMasivaTerceros Execute(ref Stream sPaquete) {
            var descargaMasivaTerceros = new RespuestaDescargaMasivaTerceros();
            try {
                var tercerosServiceClient = new DescargaMasivaTercerosServiceClient(GetBinding(), GetEndpointAddress());
                using (new OperationContextScope(tercerosServiceClient.InnerChannel)) {
                    HttpRequestMessageProperty requestMessageProperty = new HttpRequestMessageProperty();
                    requestMessageProperty.Headers["Authorization"] = "WRAP access_token=\"" + HttpUtility.UrlDecode(Token) + "\"";
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessageProperty;
                    descargaMasivaTerceros = tercerosServiceClient.Descargar(Request(), out sPaquete);
                    var responseXML = XmlSerializerService.SerializeObject(descargaMasivaTerceros);
                    LogInfoService.Log("[Descarga Solicitud (Response)] Response:", responseXML);
                }
            } catch (Exception ex) {
                LogErrorService.Write("[Descarga Solicitud (Response)] Error: " + ex.Message, ex.StackTrace);
            }
            return descargaMasivaTerceros;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IDownloadResponse Execute() {
            Stream stream = null;
            var responseDescarga = this.Execute(ref stream);
            IDownloadResponse downloadResponse = new SolicitudDescarga()
                            .AddIdPackage(this._IdPackage)
                            .AddStatusCode(new StatusCode(responseDescarga.CodEstatus, responseDescarga.Mensaje));
            // escribir
            LogErrorService.Write(responseDescarga.Mensaje, responseDescarga.CodEstatus);
            // si la solicitud de descarga es aceptada procedemos a descargar el paquete
            if (downloadResponse.StatusCode.IsAccepted()) {
                var pathZip = this.ProcessFile(stream, this._IdPackage);
                downloadResponse.AddPath(pathZip);
            } else {
                LogErrorService.Log("APIManager-Descargar", $"No se pudo descargar el paquete: {this._IdPackage} StatusCode: {downloadResponse.StatusCode.Code}, mensaje: {downloadResponse.StatusCode.Message}");
            }
            return downloadResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal PeticionDescargaMasivaTerceros Request() {
            var request = new PeticionDescargaMasivaTerceros() {
                IdPaquete = _IdPackage,
                RfcSolicitante = Solicitante.RFC,
                Signature = CreateDigest()
            };
            LogInfoService.Log("[Descarga Solicitud (Request)]:", XmlSerializerService.SerializeObject(request));
            return request;
        }

        /// <summary>
        /// procesar archivo de descarga
        /// </summary>
        /// <param name="package">Strean</param>
        /// <param name="fileName">Ruta completa para almacerna el archivo</param>
        /// <returns>ruta del archivo</returns>
        internal string ProcessFile(Stream package, string fileName) {
            // si el directorio no existe lo creamos
            if (!Directory.Exists(this.Configuration.PathDownload)) {
                Directory.CreateDirectory(this.Configuration.PathDownload);
            }

            try {
                // nombre a asignar al nuevo archivo
                var filezip = Path.Combine(this.Configuration.PathDownload, fileName + ".zip");
                // si existe entonces hacemos un backup del archivo existente para no eliminar
                if (File.Exists(filezip)) {
                    var renamefilezip = Path.Combine(this.Configuration.PathDownload, fileName + "_back_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".zip");
                    File.Copy(filezip, renamefilezip);
                }
                // si por alguna razon el archivo esta en uso, creamos uno diferente para no perder la descarga
                if (FileService.IsFileinUse(filezip)) {
                    filezip = Path.Combine(this.Configuration.PathDownload, fileName + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".zip");
                }

                using (FileStream fileStream = File.Create(filezip)) {
                    package.CopyTo(fileStream);
                    fileStream.Close();
                }
                return filezip;
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                LogErrorService.Write(ex.Message, ex.StackTrace);
            }
            return string.Empty;
        }
    }
}
