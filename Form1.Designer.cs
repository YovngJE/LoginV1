namespace H_P_II_Clase4
{
    partial class formPrinci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrinci));
            this.lgbLogin = new System.Windows.Forms.Label();
            this.BntOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblMensajeRegistro = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lgbLogin
            // 
            this.lgbLogin.AutoSize = true;
            this.lgbLogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgbLogin.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lgbLogin.Location = new System.Drawing.Point(50, 20);
            this.lgbLogin.Name = "lgbLogin";
            this.lgbLogin.Size = new System.Drawing.Size(145, 54);
            this.lgbLogin.TabIndex = 0;
            this.lgbLogin.Text = "LOGIN";
            // 
            // BntOK
            // 
            this.BntOK.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BntOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BntOK.FlatAppearance.BorderSize = 0;
            this.BntOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.BntOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BntOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BntOK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntOK.ForeColor = System.Drawing.Color.White;
            this.BntOK.Location = new System.Drawing.Point(50, 235);
            this.BntOK.Name = "BntOK";
            this.BntOK.Size = new System.Drawing.Size(300, 35);
            this.BntOK.TabIndex = 4;
            this.BntOK.Text = "Iniciar Sesión";
            this.BntOK.UseVisualStyleBackColor = false;
            this.BntOK.Click += new System.EventHandler(this.BntOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(50, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(296, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Salir";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUser.Location = new System.Drawing.Point(50, 110);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(300, 30);
            this.txtUser.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(50, 190);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(300, 22);
            this.txtPass.TabIndex = 7;
            // 
            // lblMensajeRegistro
            // 
            this.lblMensajeRegistro.AutoSize = true;
            this.lblMensajeRegistro.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeRegistro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMensajeRegistro.Location = new System.Drawing.Point(65, 360);
            this.lblMensajeRegistro.Name = "lblMensajeRegistro";
            this.lblMensajeRegistro.Size = new System.Drawing.Size(159, 23);
            this.lblMensajeRegistro.TabIndex = 9;
            this.lblMensajeRegistro.Text = "¿No tienes cuenta?";
            this.lblMensajeRegistro.Click += new System.EventHandler(this.lblMensajeRegistro_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRegistro.Location = new System.Drawing.Point(230, 355);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(109, 28);
            this.lblRegistro.TabIndex = 10;
            this.lblRegistro.Text = "Registrate";
            this.lblRegistro.Click += new System.EventHandler(this.lblRegistro_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.DarkKhaki;
            this.panelLogin.Controls.Add(this.lblContraseña);
            this.panelLogin.Controls.Add(this.lblUsuario);
            this.panelLogin.Controls.Add(this.lblRegistro);
            this.panelLogin.Controls.Add(this.lblMensajeRegistro);
            this.panelLogin.Controls.Add(this.txtPass);
            this.panelLogin.Controls.Add(this.txtUser);
            this.panelLogin.Controls.Add(this.btnCancel);
            this.panelLogin.Controls.Add(this.BntOK);
            this.panelLogin.Controls.Add(this.lgbLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(400, 403);
            this.panelLogin.TabIndex = 11;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblContraseña.Location = new System.Drawing.Point(50, 160);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(97, 23);
            this.lblContraseña.TabIndex = 12;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsuario.Location = new System.Drawing.Point(55, 80);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 23);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario";
            // 
            // panelImagen
            // 
            this.panelImagen.Controls.Add(this.pictureBox1);
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelImagen.Location = new System.Drawing.Point(406, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(376, 403);
            this.panelImagen.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::H_P_II_Clase4.Properties.Resources.Logos1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // formPrinci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formPrinci";
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lgbLogin;
        private System.Windows.Forms.Button BntOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblMensajeRegistro;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
    }
}

