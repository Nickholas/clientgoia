namespace APIServiceDemo
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelUser = new System.Windows.Forms.Panel();
            this.lbUserInfo = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lbTokenStatus = new System.Windows.Forms.Label();
            this.lbUserStatus = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cmbUri = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.gbUri = new System.Windows.Forms.GroupBox();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbStatusCode = new System.Windows.Forms.Label();
            this.panelUser.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.gbUri.SuspendLayout();
            this.gbResultados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUser
            // 
            this.panelUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUser.BackColor = System.Drawing.SystemColors.Control;
            this.panelUser.Controls.Add(this.lbUserInfo);
            this.panelUser.Controls.Add(this.panelStatus);
            this.panelUser.Controls.Add(this.lbUserStatus);
            this.panelUser.Controls.Add(this.btnLogin);
            this.panelUser.Location = new System.Drawing.Point(13, 11);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(1306, 148);
            this.panelUser.TabIndex = 0;
            // 
            // lbUserInfo
            // 
            this.lbUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserInfo.Location = new System.Drawing.Point(31, 79);
            this.lbUserInfo.Name = "lbUserInfo";
            this.lbUserInfo.Size = new System.Drawing.Size(1059, 25);
            this.lbUserInfo.TabIndex = 3;
            this.lbUserInfo.Text = "label1";
            // 
            // panelStatus
            // 
            this.panelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStatus.BackColor = System.Drawing.Color.DarkRed;
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Controls.Add(this.lbTokenStatus);
            this.panelStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelStatus.Location = new System.Drawing.Point(1109, 16);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(173, 45);
            this.panelStatus.TabIndex = 2;
            // 
            // lbTokenStatus
            // 
            this.lbTokenStatus.ForeColor = System.Drawing.Color.MistyRose;
            this.lbTokenStatus.Location = new System.Drawing.Point(4, 9);
            this.lbTokenStatus.Name = "lbTokenStatus";
            this.lbTokenStatus.Size = new System.Drawing.Size(164, 23);
            this.lbTokenStatus.TabIndex = 0;
            this.lbTokenStatus.Text = "token no válido";
            this.lbTokenStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserStatus
            // 
            this.lbUserStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserStatus.Location = new System.Drawing.Point(31, 22);
            this.lbUserStatus.Name = "lbUserStatus";
            this.lbUserStatus.Size = new System.Drawing.Size(1059, 40);
            this.lbUserStatus.TabIndex = 1;
            this.lbUserStatus.Text = "Usuario no registrado";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.Location = new System.Drawing.Point(1109, 79);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(173, 47);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(202, 75);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(888, 31);
            this.txtUrl.TabIndex = 1;
            // 
            // cmbUri
            // 
            this.cmbUri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUri.FormattingEnabled = true;
            this.cmbUri.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.cmbUri.Location = new System.Drawing.Point(16, 74);
            this.cmbUri.Name = "cmbUri";
            this.cmbUri.Size = new System.Drawing.Size(165, 33);
            this.cmbUri.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(1114, 70);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(168, 42);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // gbUri
            // 
            this.gbUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUri.Controls.Add(this.btnSend);
            this.gbUri.Controls.Add(this.cmbUri);
            this.gbUri.Controls.Add(this.txtUrl);
            this.gbUri.Location = new System.Drawing.Point(13, 178);
            this.gbUri.Name = "gbUri";
            this.gbUri.Size = new System.Drawing.Size(1305, 151);
            this.gbUri.TabIndex = 6;
            this.gbUri.TabStop = false;
            this.gbUri.Text = "Petición";
            // 
            // gbResultados
            // 
            this.gbResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResultados.Controls.Add(this.lbStatusCode);
            this.gbResultados.Controls.Add(this.txtResultados);
            this.gbResultados.Location = new System.Drawing.Point(13, 341);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(1305, 377);
            this.gbResultados.TabIndex = 7;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Resultados";
            // 
            // txtResultados
            // 
            this.txtResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultados.Location = new System.Drawing.Point(16, 63);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultados.Size = new System.Drawing.Size(1266, 293);
            this.txtResultados.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1091, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(191, 42);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(13, 724);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 98);
            this.panel1.TabIndex = 9;
            // 
            // lbStatusCode
            // 
            this.lbStatusCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatusCode.Location = new System.Drawing.Point(16, 29);
            this.lbStatusCode.Name = "lbStatusCode";
            this.lbStatusCode.Size = new System.Drawing.Size(1266, 23);
            this.lbStatusCode.TabIndex = 1;
            this.lbStatusCode.Text = "Status code:";
            this.lbStatusCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 894);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbUri);
            this.Controls.Add(this.panelUser);
            this.Name = "frmMain";
            this.Text = "WEB API GOIA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelUser.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.gbUri.ResumeLayout(false);
            this.gbUri.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ComboBox cmbUri;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbUserStatus;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lbUserInfo;
        private System.Windows.Forms.GroupBox gbUri;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbTokenStatus;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbStatusCode;
    }
}

