namespace Jaeger.Repositorio.Forms {
    partial class SolicitudControl {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.SolicitudGroupBox = new System.Windows.Forms.GroupBox();
            this.lblTipoSolicitud = new System.Windows.Forms.Label();
            this.TipoDescarga = new System.Windows.Forms.ComboBox();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.HoraFinal = new System.Windows.Forms.DateTimePicker();
            this.HoraInicial = new System.Windows.Forms.DateTimePicker();
            this.lblTipo = new System.Windows.Forms.Label();
            this.EstadoComprobante = new System.Windows.Forms.ComboBox();
            this.lblRFCTerceros = new System.Windows.Forms.Label();
            this.TipoComplemento = new System.Windows.Forms.ComboBox();
            this.RFCTerceros = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTipoComplemento = new System.Windows.Forms.Label();
            this.lblFiltrarRFC = new System.Windows.Forms.Label();
            this.TipoSolicitud = new System.Windows.Forms.ComboBox();
            this.FiltrarRFC = new System.Windows.Forms.TextBox();
            this.FechaInicial = new System.Windows.Forms.DateTimePicker();
            this.FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoDeComprobante = new System.Windows.Forms.ComboBox();
            this.SolicitudGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolicitudGroupBox
            // 
            this.SolicitudGroupBox.Controls.Add(this.lblTipoSolicitud);
            this.SolicitudGroupBox.Controls.Add(this.TipoDescarga);
            this.SolicitudGroupBox.Controls.Add(this.lblFechaFinal);
            this.SolicitudGroupBox.Controls.Add(this.lblFechaInicial);
            this.SolicitudGroupBox.Controls.Add(this.HoraFinal);
            this.SolicitudGroupBox.Controls.Add(this.HoraInicial);
            this.SolicitudGroupBox.Controls.Add(this.lblTipo);
            this.SolicitudGroupBox.Controls.Add(this.TipoDeComprobante);
            this.SolicitudGroupBox.Controls.Add(this.EstadoComprobante);
            this.SolicitudGroupBox.Controls.Add(this.lblRFCTerceros);
            this.SolicitudGroupBox.Controls.Add(this.TipoComplemento);
            this.SolicitudGroupBox.Controls.Add(this.label1);
            this.SolicitudGroupBox.Controls.Add(this.RFCTerceros);
            this.SolicitudGroupBox.Controls.Add(this.lblEstado);
            this.SolicitudGroupBox.Controls.Add(this.lblTipoComplemento);
            this.SolicitudGroupBox.Controls.Add(this.lblFiltrarRFC);
            this.SolicitudGroupBox.Controls.Add(this.TipoSolicitud);
            this.SolicitudGroupBox.Controls.Add(this.FiltrarRFC);
            this.SolicitudGroupBox.Controls.Add(this.FechaInicial);
            this.SolicitudGroupBox.Controls.Add(this.FechaFinal);
            this.SolicitudGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SolicitudGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SolicitudGroupBox.Name = "SolicitudGroupBox";
            this.SolicitudGroupBox.Size = new System.Drawing.Size(288, 316);
            this.SolicitudGroupBox.TabIndex = 4;
            this.SolicitudGroupBox.TabStop = false;
            this.SolicitudGroupBox.Text = "Solicitud";
            // 
            // lblTipoSolicitud
            // 
            this.lblTipoSolicitud.AutoSize = true;
            this.lblTipoSolicitud.Location = new System.Drawing.Point(12, 48);
            this.lblTipoSolicitud.Name = "lblTipoSolicitud";
            this.lblTipoSolicitud.Size = new System.Drawing.Size(95, 13);
            this.lblTipoSolicitud.TabIndex = 32;
            this.lblTipoSolicitud.Text = "Tipo de Descarga:";
            // 
            // TipoDescarga
            // 
            this.TipoDescarga.Location = new System.Drawing.Point(113, 44);
            this.TipoDescarga.Name = "TipoDescarga";
            this.TipoDescarga.Size = new System.Drawing.Size(166, 21);
            this.TipoDescarga.TabIndex = 33;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(12, 100);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(65, 13);
            this.lblFechaFinal.TabIndex = 21;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Location = new System.Drawing.Point(12, 74);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(70, 13);
            this.lblFechaInicial.TabIndex = 16;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // HoraFinal
            // 
            this.HoraFinal.CustomFormat = "HH:mm:ss";
            this.HoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraFinal.Location = new System.Drawing.Point(186, 96);
            this.HoraFinal.Name = "HoraFinal";
            this.HoraFinal.ShowUpDown = true;
            this.HoraFinal.Size = new System.Drawing.Size(93, 20);
            this.HoraFinal.TabIndex = 23;
            this.HoraFinal.TabStop = false;
            this.HoraFinal.Value = new System.DateTime(2021, 5, 17, 18, 3, 59, 132);
            // 
            // HoraInicial
            // 
            this.HoraInicial.CustomFormat = "HH:mm:ss";
            this.HoraInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraInicial.Location = new System.Drawing.Point(186, 70);
            this.HoraInicial.Name = "HoraInicial";
            this.HoraInicial.ShowUpDown = true;
            this.HoraInicial.Size = new System.Drawing.Size(93, 20);
            this.HoraInicial.TabIndex = 20;
            this.HoraInicial.TabStop = false;
            this.HoraInicial.Value = new System.DateTime(2021, 5, 17, 18, 3, 59, 132);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 22);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(125, 13);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Consultar Comprobantes:";
            // 
            // EstadoComprobante
            // 
            this.EstadoComprobante.Location = new System.Drawing.Point(148, 124);
            this.EstadoComprobante.Name = "EstadoComprobante";
            this.EstadoComprobante.Size = new System.Drawing.Size(131, 21);
            this.EstadoComprobante.TabIndex = 25;
            // 
            // lblRFCTerceros
            // 
            this.lblRFCTerceros.AutoSize = true;
            this.lblRFCTerceros.Location = new System.Drawing.Point(12, 259);
            this.lblRFCTerceros.Name = "lblRFCTerceros";
            this.lblRFCTerceros.Size = new System.Drawing.Size(117, 13);
            this.lblRFCTerceros.TabIndex = 30;
            this.lblRFCTerceros.Text = "RFC a cuenta terceros:";
            // 
            // TipoComplemento
            // 
            this.TipoComplemento.Location = new System.Drawing.Point(12, 204);
            this.TipoComplemento.Name = "TipoComplemento";
            this.TipoComplemento.Size = new System.Drawing.Size(267, 21);
            this.TipoComplemento.TabIndex = 27;
            // 
            // RFCTerceros
            // 
            this.RFCTerceros.Location = new System.Drawing.Point(158, 257);
            this.RFCTerceros.MaxLength = 14;
            this.RFCTerceros.Name = "RFCTerceros";
            this.RFCTerceros.Size = new System.Drawing.Size(121, 20);
            this.RFCTerceros.TabIndex = 31;
            this.RFCTerceros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 128);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(122, 13);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = "Estado del comprobante";
            // 
            // lblTipoComplemento
            // 
            this.lblTipoComplemento.AutoSize = true;
            this.lblTipoComplemento.Location = new System.Drawing.Point(12, 184);
            this.lblTipoComplemento.Name = "lblTipoComplemento";
            this.lblTipoComplemento.Size = new System.Drawing.Size(182, 13);
            this.lblTipoComplemento.TabIndex = 26;
            this.lblTipoComplemento.Text = "Tipo de Comprobante (Complemento)";
            // 
            // lblFiltrarRFC
            // 
            this.lblFiltrarRFC.AutoSize = true;
            this.lblFiltrarRFC.Location = new System.Drawing.Point(12, 232);
            this.lblFiltrarRFC.Name = "lblFiltrarRFC";
            this.lblFiltrarRFC.Size = new System.Drawing.Size(65, 13);
            this.lblFiltrarRFC.TabIndex = 28;
            this.lblFiltrarRFC.Text = "RFC Emisor:";
            // 
            // TipoSolicitud
            // 
            this.TipoSolicitud.Location = new System.Drawing.Point(143, 18);
            this.TipoSolicitud.Name = "TipoSolicitud";
            this.TipoSolicitud.Size = new System.Drawing.Size(136, 21);
            this.TipoSolicitud.TabIndex = 19;
            // 
            // FiltrarRFC
            // 
            this.FiltrarRFC.Location = new System.Drawing.Point(158, 231);
            this.FiltrarRFC.MaxLength = 14;
            this.FiltrarRFC.Name = "FiltrarRFC";
            this.FiltrarRFC.Size = new System.Drawing.Size(121, 20);
            this.FiltrarRFC.TabIndex = 29;
            this.FiltrarRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FechaInicial
            // 
            this.FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaInicial.Location = new System.Drawing.Point(87, 70);
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.Size = new System.Drawing.Size(95, 20);
            this.FechaInicial.TabIndex = 18;
            this.FechaInicial.TabStop = false;
            this.FechaInicial.Value = new System.DateTime(2021, 5, 17, 18, 3, 59, 132);
            // 
            // FechaFinal
            // 
            this.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFinal.Location = new System.Drawing.Point(87, 96);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(95, 20);
            this.FechaFinal.TabIndex = 22;
            this.FechaFinal.TabStop = false;
            this.FechaFinal.Value = new System.DateTime(2021, 5, 17, 18, 3, 59, 117);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tipo de comprobante";
            // 
            // TipoDeComprobante
            // 
            this.TipoDeComprobante.Location = new System.Drawing.Point(148, 151);
            this.TipoDeComprobante.Name = "TipoDeComprobante";
            this.TipoDeComprobante.Size = new System.Drawing.Size(131, 21);
            this.TipoDeComprobante.TabIndex = 25;
            // 
            // SolicitudControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SolicitudGroupBox);
            this.Name = "SolicitudControl";
            this.Size = new System.Drawing.Size(288, 316);
            this.Load += new System.EventHandler(this.SolicitudControl_Load);
            this.SolicitudGroupBox.ResumeLayout(false);
            this.SolicitudGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SolicitudGroupBox;
        private System.Windows.Forms.Label lblTipoSolicitud;
        public System.Windows.Forms.ComboBox TipoDescarga;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblFechaInicial;
        public System.Windows.Forms.DateTimePicker HoraFinal;
        public System.Windows.Forms.DateTimePicker HoraInicial;
        private System.Windows.Forms.Label lblTipo;
        public System.Windows.Forms.ComboBox EstadoComprobante;
        private System.Windows.Forms.Label lblRFCTerceros;
        public System.Windows.Forms.ComboBox TipoComplemento;
        public System.Windows.Forms.TextBox RFCTerceros;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTipoComplemento;
        private System.Windows.Forms.Label lblFiltrarRFC;
        public System.Windows.Forms.ComboBox TipoSolicitud;
        public System.Windows.Forms.TextBox FiltrarRFC;
        public System.Windows.Forms.DateTimePicker FechaInicial;
        public System.Windows.Forms.DateTimePicker FechaFinal;
        public System.Windows.Forms.ComboBox TipoDeComprobante;
        private System.Windows.Forms.Label label1;
    }
}
