﻿namespace Jaeger.Repositorio.Forms {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Header = new System.Windows.Forms.PictureBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.SolicitudGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTipoSolicitud = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.HoraFinal = new System.Windows.Forms.DateTimePicker();
            this.HoraInicial = new System.Windows.Forms.DateTimePicker();
            this.lblTipo = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.ComboBox();
            this.lblRFCTerceros = new System.Windows.Forms.Label();
            this.TipoComplemento = new System.Windows.Forms.ComboBox();
            this.RFCTerceros = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTipoComplemento = new System.Windows.Forms.Label();
            this.lblFiltrarRFC = new System.Windows.Forms.Label();
            this.SubTipoComprobante = new System.Windows.Forms.ComboBox();
            this.FiltrarRFC = new System.Windows.Forms.TextBox();
            this.FechaInicial = new System.Windows.Forms.DateTimePicker();
            this.FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SolicitanteRFC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckPassword = new System.Windows.Forms.CheckBox();
            this.buttonCER = new System.Windows.Forms.Button();
            this.PathCer = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.lblCertificado = new System.Windows.Forms.Label();
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Verificar = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Header)).BeginInit();
            this.StatusBar.SuspendLayout();
            this.SolicitudGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(800, 40);
            this.Header.TabIndex = 0;
            this.Header.TabStop = false;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.Color.White;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(370, 17);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Servicio de Solicitud de Descarga Masiva de CFDI";
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.ProgressBar});
            this.StatusBar.Location = new System.Drawing.Point(0, 392);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(800, 22);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 2;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Image = global::Jaeger.Repositorio.Properties.Resources.cancel_16px;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(100, 17);
            this.StatusLabel.Text = "Esperanding ...";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 16);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // SolicitudGroupBox
            // 
            this.SolicitudGroupBox.Controls.Add(this.button1);
            this.SolicitudGroupBox.Controls.Add(this.lblTipoSolicitud);
            this.SolicitudGroupBox.Controls.Add(this.comboBox1);
            this.SolicitudGroupBox.Controls.Add(this.lblFechaFinal);
            this.SolicitudGroupBox.Controls.Add(this.lblFechaInicial);
            this.SolicitudGroupBox.Controls.Add(this.HoraFinal);
            this.SolicitudGroupBox.Controls.Add(this.HoraInicial);
            this.SolicitudGroupBox.Controls.Add(this.lblTipo);
            this.SolicitudGroupBox.Controls.Add(this.Estado);
            this.SolicitudGroupBox.Controls.Add(this.lblRFCTerceros);
            this.SolicitudGroupBox.Controls.Add(this.TipoComplemento);
            this.SolicitudGroupBox.Controls.Add(this.RFCTerceros);
            this.SolicitudGroupBox.Controls.Add(this.lblEstado);
            this.SolicitudGroupBox.Controls.Add(this.lblTipoComplemento);
            this.SolicitudGroupBox.Controls.Add(this.lblFiltrarRFC);
            this.SolicitudGroupBox.Controls.Add(this.SubTipoComprobante);
            this.SolicitudGroupBox.Controls.Add(this.FiltrarRFC);
            this.SolicitudGroupBox.Controls.Add(this.FechaInicial);
            this.SolicitudGroupBox.Controls.Add(this.FechaFinal);
            this.SolicitudGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SolicitudGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SolicitudGroupBox.Name = "SolicitudGroupBox";
            this.SolicitudGroupBox.Size = new System.Drawing.Size(290, 320);
            this.SolicitudGroupBox.TabIndex = 3;
            this.SolicitudGroupBox.TabStop = false;
            this.SolicitudGroupBox.Text = "Solicitud";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTipoSolicitud
            // 
            this.lblTipoSolicitud.AutoSize = true;
            this.lblTipoSolicitud.Location = new System.Drawing.Point(12, 74);
            this.lblTipoSolicitud.Name = "lblTipoSolicitud";
            this.lblTipoSolicitud.Size = new System.Drawing.Size(95, 13);
            this.lblTipoSolicitud.TabIndex = 32;
            this.lblTipoSolicitud.Text = "Tipo de Descarga:";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(113, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(12, 126);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(65, 13);
            this.lblFechaFinal.TabIndex = 21;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Location = new System.Drawing.Point(12, 100);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(70, 13);
            this.lblFechaInicial.TabIndex = 16;
            this.lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // HoraFinal
            // 
            this.HoraFinal.CustomFormat = "HH:mm:ss";
            this.HoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraFinal.Location = new System.Drawing.Point(186, 122);
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
            this.HoraInicial.Location = new System.Drawing.Point(186, 96);
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
            this.lblTipo.Location = new System.Drawing.Point(12, 48);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(125, 13);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Consultar Comprobantes:";
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(148, 152);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(131, 21);
            this.Estado.TabIndex = 25;
            // 
            // lblRFCTerceros
            // 
            this.lblRFCTerceros.AutoSize = true;
            this.lblRFCTerceros.Location = new System.Drawing.Point(12, 252);
            this.lblRFCTerceros.Name = "lblRFCTerceros";
            this.lblRFCTerceros.Size = new System.Drawing.Size(117, 13);
            this.lblRFCTerceros.TabIndex = 30;
            this.lblRFCTerceros.Text = "RFC a cuenta terceros:";
            // 
            // TipoComplemento
            // 
            this.TipoComplemento.Location = new System.Drawing.Point(12, 196);
            this.TipoComplemento.Name = "TipoComplemento";
            this.TipoComplemento.Size = new System.Drawing.Size(267, 21);
            this.TipoComplemento.TabIndex = 27;
            // 
            // RFCTerceros
            // 
            this.RFCTerceros.Location = new System.Drawing.Point(158, 250);
            this.RFCTerceros.MaxLength = 14;
            this.RFCTerceros.Name = "RFCTerceros";
            this.RFCTerceros.Size = new System.Drawing.Size(121, 20);
            this.RFCTerceros.TabIndex = 31;
            this.RFCTerceros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 154);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(122, 13);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = "Estado del comprobante";
            // 
            // lblTipoComplemento
            // 
            this.lblTipoComplemento.AutoSize = true;
            this.lblTipoComplemento.Location = new System.Drawing.Point(12, 177);
            this.lblTipoComplemento.Name = "lblTipoComplemento";
            this.lblTipoComplemento.Size = new System.Drawing.Size(182, 13);
            this.lblTipoComplemento.TabIndex = 26;
            this.lblTipoComplemento.Text = "Tipo de Comprobante (Complemento)";
            // 
            // lblFiltrarRFC
            // 
            this.lblFiltrarRFC.AutoSize = true;
            this.lblFiltrarRFC.Location = new System.Drawing.Point(12, 225);
            this.lblFiltrarRFC.Name = "lblFiltrarRFC";
            this.lblFiltrarRFC.Size = new System.Drawing.Size(65, 13);
            this.lblFiltrarRFC.TabIndex = 28;
            this.lblFiltrarRFC.Text = "RFC Emisor:";
            // 
            // SubTipoComprobante
            // 
            this.SubTipoComprobante.Location = new System.Drawing.Point(143, 44);
            this.SubTipoComprobante.Name = "SubTipoComprobante";
            this.SubTipoComprobante.Size = new System.Drawing.Size(136, 21);
            this.SubTipoComprobante.TabIndex = 19;
            // 
            // FiltrarRFC
            // 
            this.FiltrarRFC.Location = new System.Drawing.Point(158, 224);
            this.FiltrarRFC.MaxLength = 14;
            this.FiltrarRFC.Name = "FiltrarRFC";
            this.FiltrarRFC.Size = new System.Drawing.Size(121, 20);
            this.FiltrarRFC.TabIndex = 29;
            this.FiltrarRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FechaInicial
            // 
            this.FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaInicial.Location = new System.Drawing.Point(87, 96);
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.Size = new System.Drawing.Size(95, 20);
            this.FechaInicial.TabIndex = 18;
            this.FechaInicial.TabStop = false;
            this.FechaInicial.Value = new System.DateTime(2021, 5, 17, 18, 3, 59, 132);
            // 
            // FechaFinal
            // 
            this.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFinal.Location = new System.Drawing.Point(87, 122);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(95, 20);
            this.FechaFinal.TabIndex = 22;
            this.FechaFinal.TabStop = false;
            this.FechaFinal.Value = new System.DateTime(2021, 5, 17, 18, 3, 59, 117);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(304, 352);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(296, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Solicitante";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SolicitanteRFC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CheckPassword);
            this.groupBox1.Controls.Add(this.buttonCER);
            this.groupBox1.Controls.Add(this.PathCer);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.lblCertificado);
            this.groupBox1.Controls.Add(this.lblPassword1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 320);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Certificado";
            // 
            // SolicitanteRFC
            // 
            this.SolicitanteRFC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolicitanteRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SolicitanteRFC.Location = new System.Drawing.Point(6, 157);
            this.SolicitanteRFC.MaxLength = 14;
            this.SolicitanteRFC.Name = "SolicitanteRFC";
            this.SolicitanteRFC.Size = new System.Drawing.Size(104, 20);
            this.SolicitanteRFC.TabIndex = 23;
            this.SolicitanteRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "RFC del solicitante:";
            // 
            // CheckPassword
            // 
            this.CheckPassword.Location = new System.Drawing.Point(225, 100);
            this.CheckPassword.Name = "CheckPassword";
            this.CheckPassword.Size = new System.Drawing.Size(89, 18);
            this.CheckPassword.TabIndex = 22;
            this.CheckPassword.Text = "ver caracteres";
            this.CheckPassword.CheckStateChanged += new System.EventHandler(this.CheckPassword_ToggleStateChanged);
            // 
            // buttonCER
            // 
            this.buttonCER.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCER.Location = new System.Drawing.Point(246, 70);
            this.buttonCER.Name = "buttonCER";
            this.buttonCER.Size = new System.Drawing.Size(29, 23);
            this.buttonCER.TabIndex = 19;
            this.buttonCER.Text = "...";
            this.buttonCER.Click += new System.EventHandler(this.ButtonCER_Click);
            // 
            // PathCer
            // 
            this.PathCer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathCer.Location = new System.Drawing.Point(6, 44);
            this.PathCer.Name = "PathCer";
            this.PathCer.Size = new System.Drawing.Size(269, 20);
            this.PathCer.TabIndex = 17;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(6, 98);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(213, 20);
            this.Password.TabIndex = 21;
            // 
            // lblCertificado
            // 
            this.lblCertificado.Location = new System.Drawing.Point(6, 22);
            this.lblCertificado.Name = "lblCertificado";
            this.lblCertificado.Size = new System.Drawing.Size(283, 18);
            this.lblCertificado.TabIndex = 18;
            this.lblCertificado.Text = "Certificado en formato PFX:";
            // 
            // lblPassword1
            // 
            this.lblPassword1.Location = new System.Drawing.Point(6, 79);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(154, 18);
            this.lblPassword1.TabIndex = 20;
            this.lblPassword1.Text = "Contraseña:*";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SolicitudGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(296, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Solicitud";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(296, 326);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Verificar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Verificar);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 320);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // Verificar
            // 
            this.Verificar.Location = new System.Drawing.Point(209, 291);
            this.Verificar.Name = "Verificar";
            this.Verificar.Size = new System.Drawing.Size(75, 23);
            this.Verificar.TabIndex = 30;
            this.Verificar.Text = "Verificar";
            this.Verificar.UseVisualStyleBackColor = true;
            this.Verificar.Click += new System.EventHandler(this.Verificar_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Location = new System.Drawing.Point(6, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(267, 21);
            this.comboBox2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tipo de Comprobante (Complemento)";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(296, 326);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Descargar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(296, 326);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Descargar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(282, 248);
            this.dataGridView1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tipo de Comprobante (Complemento)";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(304, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 105);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Respuesta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(304, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(496, 247);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logger";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(490, 228);
            this.textBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.Header);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio de Solicitud de Descarga Masiva de CFDI (Tester)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Header)).EndInit();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.SolicitudGroupBox.ResumeLayout(false);
            this.SolicitudGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Header;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.GroupBox SolicitudGroupBox;
        private System.Windows.Forms.Label lblTipoSolicitud;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.Label lblFechaInicial;
        public System.Windows.Forms.DateTimePicker HoraFinal;
        public System.Windows.Forms.DateTimePicker HoraInicial;
        private System.Windows.Forms.Label lblTipo;
        public System.Windows.Forms.ComboBox Estado;
        private System.Windows.Forms.Label lblRFCTerceros;
        public System.Windows.Forms.ComboBox TipoComplemento;
        public System.Windows.Forms.TextBox RFCTerceros;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTipoComplemento;
        private System.Windows.Forms.Label lblFiltrarRFC;
        public System.Windows.Forms.ComboBox SubTipoComprobante;
        public System.Windows.Forms.TextBox FiltrarRFC;
        public System.Windows.Forms.DateTimePicker FechaInicial;
        public System.Windows.Forms.DateTimePicker FechaFinal;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox CheckPassword;
        private System.Windows.Forms.Button buttonCER;
        public System.Windows.Forms.TextBox PathCer;
        public System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label lblCertificado;
        private System.Windows.Forms.Label lblPassword1;
        public System.Windows.Forms.TextBox SolicitanteRFC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Verificar;
    }
}