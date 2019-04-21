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
    public partial class dlgLogin : Form
    {
        public dynamic loginResult { get; set; }

        public dlgLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Debe especificar una dirección de correo electrónico válida para poder continuar");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Debe introducir su contraseña para poder continuar");
                return;
            }

            WebApiClient conexion = new WebApiClient(Program.WEB_API);
            this.loginResult = await conexion.Login(txtEmail.Text, txtPassword.Text, Convert.ToInt32(txtCooperativaId.Value));

            if (this.loginResult == null)
                this.DialogResult = DialogResult.Retry;
            else
                this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
