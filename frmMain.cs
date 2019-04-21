using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIServiceDemo
{
    public partial class frmMain : Form
    {
        private string BearToken = string.Empty;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            ShowLogoutStatus();
        }

        #region Funciones para actualizar el estado
        private void ShowLogoutStatus()
        {
            this.btnLogin.Text = "Login";
            this.BearToken = string.Empty;
            this.panelStatus.BackColor = Color.DarkRed;
            this.lbTokenStatus.ForeColor = Color.MistyRose;
            this.lbTokenStatus.Text = "token no válido";
            this.lbUserStatus.Text = "Usuario no registrado";
            this.lbUserInfo.Text = "Por favor, pulse sobre el botón de Login para obtener un token de acceso válido";
            this.gbUri.Enabled = false;
            this.gbResultados.Enabled = false;
        }
        private void ShowLoginStatus(string newtoken)
        {
            this.btnLogin.Text = "Logout";
            this.panelStatus.BackColor = Color.DarkGreen;
            this.lbTokenStatus.ForeColor = Color.Lime;
            this.lbTokenStatus.Text = "token válido";
            this.lbUserStatus.Text = "Usuario correctamente registrado";
            this.lbUserInfo.Text = "Enhorabuena, ya dispone de un token de acceso válido para poder obtener información de la WEB API";
            this.gbUri.Enabled = true;
            this.gbResultados.Enabled = true;
            this.BearToken = newtoken;
        }
        #endregion

        #region Botones de opción
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.BearToken))
            {
                using (dlgLogin DialogoLogin = new dlgLogin())
                {
                    DialogResult dlgResultado = DialogoLogin.ShowDialog();
                    if (dlgResultado == DialogResult.OK)
                        ShowLoginStatus(Convert.ToString(DialogoLogin.loginResult.access_token));
                    else
                        ShowLogoutStatus();
                }
            }
            else
                ShowLogoutStatus();
        }
        private async void btnSend_Click(object sender, EventArgs e)
        {
            dynamic result = null;

            WebApiClient conexion = new WebApiClient(Program.WEB_API, this.BearToken);

            if (cmbUri.Text == "GET")
            {
                result = await conexion.GetAsync(txtUrl.Text);
            }

            lbStatusCode.Text = "Status code: " + conexion.status.ToString();
            if (result != null)
            {
                txtResultados.Text = Convert.ToString(result);
            }
            else
            {
                txtResultados.Text = string.Empty;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
