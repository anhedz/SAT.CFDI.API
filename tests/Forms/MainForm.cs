using Jaeger.SAT.CFDI.Services;
using Jaeger.SAT.CFDI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaeger.Repositorio.Forms {
    public partial class MainForm : Form {
        Timer timer;
        private IApiManagerServices _Service;
        private ISolicitante _Solicitante;
        private Color colorInvalido;
        private Color colorValido;
        private Color colorEditable;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            //this._Service = new ManagerServices();
            this.timer = new Timer();
            this.timer.Interval = 1000;
            this.timer.Tick += Timer_Tick;
            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) {
            this.StatusLabel.Text = "checando ..";
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
    }
}
