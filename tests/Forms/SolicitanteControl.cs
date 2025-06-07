using System;
using System.Windows.Forms;
using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.Repositorio.Forms {
    public partial class SolicitudControl : UserControl {
        public SolicitudControl() {
            InitializeComponent();
        }

        private void SolicitudControl_Load(object sender, EventArgs e) {
            this.TipoSolicitud.DataSource = Enum.GetValues(typeof(Jaeger.SAT.API.Services.Enums.TipoConsultaEnum));
            this.TipoDescarga.DataSource = Enum.GetValues(typeof(Jaeger.SAT.API.Services.Enums.TipoDescargaEnum));
            this.EstadoComprobante.DataSource = Enum.GetValues(typeof(Jaeger.SAT.API.Services.Enums.EstadoComprobanteEnum));
            this.TipoDeComprobante.DataSource = Enum.GetValues(typeof(Jaeger.SAT.API.Services.Enums.TipoDeComprobante));
            this.TipoComplemento.DataSource = Enum.GetValues(typeof(Jaeger.SAT.API.Services.Enums.ComplementoEnum));
            this.FechaInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 1);
            this.FechaFinal.Value = DateTime.Now;

            this.HoraInicial.Value = this.FechaInicial.Value;
            this.HoraFinal.Value = this.FechaFinal.Value;
        }

        public ISolicitud GetSolicitud() {
            var solicitud = new SAT.API.Services.Entities.Solicitud {
                RfcACuentaTerceros = this.RFCTerceros.Text,
                Estado = (Jaeger.SAT.API.Services.Enums.EstadoComprobanteEnum)this.EstadoComprobante.SelectedItem,
                TipoConsulta = (Jaeger.SAT.API.Services.Enums.TipoConsultaEnum)this.TipoSolicitud.SelectedItem,
                FechaInicial = this.FechaInicial.Value.Date + this.HoraInicial.Value.TimeOfDay,
                FechaFinal = this.FechaFinal.Value.Date + this.HoraFinal.Value.TimeOfDay,
                ReceptorRFC = this.FiltrarRFC.Text.Trim(),
                TipoDeComprobante = (SAT.API.Services.Enums.TipoDeComprobante)this.TipoDeComprobante.SelectedItem,
            };
            return solicitud;
        }
    }
}
