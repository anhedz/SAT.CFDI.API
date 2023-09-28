using Jaeger.SAT.CFDI.Helpers;
using System;

namespace Jaeger.SAT.CFDI.API.Abstracts {
    public abstract class WebServiceBase {
        private byte[] sArchivoPFX;
        private string _PasswordKey;
        private string _RfcSolicitante;

        protected WebServiceBase(byte[] sArchivoPFX, string passwordKey, string rfcSolicitante) {
            try {
                this.sArchivoPFX = sArchivoPFX;
                _PasswordKey = passwordKey;
                _RfcSolicitante = rfcSolicitante;
            } catch (Exception ex) {
                LogErrorService.EscribirLog("[Web Service SAT] Error: " + ex.Message, ex.StackTrace);
            }
        }

        public byte[] PFX {
            get { return sArchivoPFX; }
            set { sArchivoPFX = value; }
        }

        public string PasswordKey {
            get { return _PasswordKey; }
            set { _PasswordKey = value; }
        }

        public string RfcSolicitante {
            get { return _RfcSolicitante; }
            set { _RfcSolicitante = value; }
        }
    }
}
