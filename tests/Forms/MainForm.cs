using System;
using System.Drawing;
using System.Windows.Forms;
using Jaeger.SAT.API.Services.Interfaces;

namespace Jaeger.Repositorio.Forms {
    public partial class MainForm : Form {
        Timer timer;
        private IManagerServices _Service;
        private ISolicitante _Solicitante;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            

            this.timer = new Timer {
                Interval = 1000
            };
            this.timer.Tick += Timer_Tick;
            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) {
            this.StatusLabel.Text = "checando ...";
            if (this._Service == null) {
                this.StatusLabel.Image = Properties.Resources.cancel_16px;
            } else {
                this.StatusLabel.Image = Properties.Resources.checked_16;
            }
        }

        private void ButtonCER_Click(object sender, EventArgs e) {
            var openFileDialog = new OpenFileDialog() {
                Title = "Buscar archivo del certificado *.pfx",
                DefaultExt = ".cer",
                Filter = "Archivo PFX (*.pfx)|*.pfx",
                FilterIndex = 1,
                FileName = ""
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                this.PathCer.Text = openFileDialog.FileName;
            }
        }

        private void CheckPassword_ToggleStateChanged(object sender, EventArgs args) {
            if (!this.CheckPassword.Checked) {
                this.Password.PasswordChar = '*';
                this.Password.PasswordChar = '*';
            } else {
                this.Password.PasswordChar = '\0';
            }
        }

        private void Verificar_Click(object sender, EventArgs e) {
            var s0 = new SAT.API.CFDI.Services.ManagerServices(null);
            s0.Verifica();
        }

        private void CrearSolicitud_Click(object sender, EventArgs e) {
            this._Solicitante = new SAT.API.Services.Entities.Solicitante {
                RFC = this.SolicitanteRFC.Text.Trim(),
                PasswordKey = this.Password.Text.Trim(),
                B64PFX = this.PathCer.Text.Trim()
            };

            this._Service = new Jaeger.SAT.API.CFDI.Services.ManagerServices(this._Solicitante);
            this._Service.AddSolicitante(this._Solicitante);
            this._Service.AddSolicitud(this.Solicitud.GetSolicitud());
            this._Service.Autenticacion();
            this._Service.Consulta();
        }
    }
}
