﻿using System;
using System.IO;
using System.ServiceModel.Channels;
using System.ServiceModel;
using System.Web;
using Jaeger.SAT.CFDI.Services.Abstracts;
using Jaeger.SAT.CFDI.Services.API.Descargas;
using Jaeger.SAT.CFDI.Services.Interfaces;
using Jaeger.SAT.CFDI.Services.Helpers;

namespace Jaeger.SAT.CFDI.Services {
    public class DescargaService : ServiceBase, IServiceBase, IBase, IDescargaService {
        protected internal string _IdPackage;

        public DescargaService() : base() {
            this.AddURL("https://cfdidescargamasiva.clouda.sat.gob.mx/DescargaMasivaService.svc");
        }

        public void AddIdPaquete(string idPaquete) {
            this._IdPackage = idPaquete;
        }

        public IDescargaService AddToken(string token) {
            this.Token = token;
            return this;
        }

        public RespuestaDescargaMasivaTerceros Execute(ref Stream sPaquete) {
            var descargaMasivaTerceros = new RespuestaDescargaMasivaTerceros();
            try {
                var tercerosServiceClient = new DescargaMasivaTercerosServiceClient(GetBinding(), GetEndpointAddress());
                using (new OperationContextScope(tercerosServiceClient.InnerChannel)) {
                    HttpRequestMessageProperty requestMessageProperty = new HttpRequestMessageProperty();
                    requestMessageProperty.Headers["Authorization"] = "WRAP access_token=\"" + HttpUtility.UrlDecode(Token) + "\"";
                    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestMessageProperty;
                    descargaMasivaTerceros = tercerosServiceClient.Descargar(this.Request(), out sPaquete);
                }
            } catch (Exception ex) {
                LogErrorService.Write("[Descarga Solicitud (Peticiones)] Error: " + ex.Message, ex.StackTrace);
            }
            return descargaMasivaTerceros;
        }

        internal PeticionDescargaMasivaTerceros Request() {
            return new PeticionDescargaMasivaTerceros() {
                IdPaquete = _IdPackage,
                RfcSolicitante = this.Solicitante.RFC,
                Signature = CreateDigest()
            };
        }
    }
}
