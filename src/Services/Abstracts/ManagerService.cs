using System;
using Jaeger.SAT.API.Services.Entities;
using Jaeger.SAT.API.Services.Helpers;
using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.SAT.API.Services.Abstracts {
    public abstract class ManagerService : ManagerServiceBase, IBase, IManagerServices {
        #region declaraciones
        protected internal ISolicitud _Solicitud;
        protected internal bool _IsAutenticate = false;
        protected internal DateTime _LastUpdateTime = DateTime.Now;
        #endregion

        public ManagerService(ISolicitante solicitante) : base() {
            this.Token = null;
            this.Solicitante = solicitante;
            this.FactoryAutentica();
            this._IsAutenticate = false;
            this._AutenticaService.AddConfiguration(this.Configuration).AddSolicitante(solicitante);
            this._LastUpdateTime = DateTime.Now;
        }

        public ISolicitud Solicitud {
            get { return this._Solicitud; }
        }

        public IManagerServices AddSolicitud(ISolicitud solicitud) {
            this._Solicitud = solicitud;
            return this;
        }

        public bool Autenticacion() {
            if (!string.IsNullOrEmpty(this.Token)) {
                if (!(this._LastUpdateTime > DateTime.Now)) {
                    this.CodeError = new CodeError(0, "Token expirado");
                    LogInfoService.Log("Autenticacion", $"Token expirado {this._LastUpdateTime:dd-MM-yyyyThh:mm:ss}");
                } else {
                    return true;
                }
            }

            this.Token = this._AutenticaService.GeneraToken();
            this._LastUpdateTime = DateTime.Now.AddMinutes(4);
            LogInfoService.Log("Autenticacion", $"Token expira en: {this._LastUpdateTime:dd-MM-yyyyThh:mm:ss}");
            if (string.IsNullOrEmpty(this.Token)) {
                this.Token = null;
                this.CodeError = new CodeError(0, "Error de autenticación");
                LogErrorService.Write("Autenticacion", $"Error de autenticación {this._LastUpdateTime:dd-MM-yyyyThh:mm:ss}");
                this._IsAutenticate = false;
                return false;
            }

            this._IsAutenticate = true;
            return this._IsAutenticate;
        }

        protected abstract void FactoryAutentica();
        protected abstract void FactoryConsulta();
        protected abstract void FactoryVerifica();
        protected abstract void FactoryDescarga();

        public IQueryResponse Consulta() {
            if (this._ConsultaService == null) {
                this.FactoryConsulta();
                this._ConsultaService.AddConfiguration(this.Configuration).AddSolicitante(this.Solicitante);
            }

            if (string.IsNullOrEmpty(this.Token)) {
                if (this.Autenticacion() == false) {
                    this.CodeError = new CodeError(0, "Error de autenticación");
                }
            }
            // crear solicitud
            IQueryResponse _SolicitudResponse = this._ConsultaService.AddToken(this.Token).AddSolicitud(this._Solicitud).Execute();
            // agregamos version del proveedor del servicio
            _SolicitudResponse.AddServiceProvider(this.Version);
            return _SolicitudResponse;
        }

        public IVerifyResponse Verifica() {
            if (this._VerificaService == null) {
                this.FactoryVerifica();
                this._VerificaService.AddConfiguration(this.Configuration).AddSolicitante(this.Solicitante);
            }

            if (string.IsNullOrEmpty(this.Token)) {
                if (this.Autenticacion() == false) {
                    LogErrorService.Write("No se puede autenticar", "");
                    Console.WriteLine("No se puede autenticar");
                }
            }

            IVerifyResponse _VerifyResponse = this._VerificaService
                    .AddIdSolicitud(this._Solicitud.IdSolicitud)
                    .AddToken(this.Token).Execute();

            return _VerifyResponse;
        }

        public IDownloadResponse Descargar(string package) {
            if (this._DescargaService == null) {
                this.FactoryDescarga();
                this._DescargaService.AddConfiguration(this.Configuration).AddSolicitante(this.Solicitante);
            }

            if (this.Autenticacion() == false) {
                Console.WriteLine("No se puede autenticar");
                LogErrorService.Write("No se puede autenticar", "");
                return null;
            }

            this._DescargaService.AddToken(this.Token);

            this._DescargaService.AddIdPaquete(package);
            
            var responseDescarga = this._DescargaService.Execute();

            return responseDescarga;
        }
    }
}
