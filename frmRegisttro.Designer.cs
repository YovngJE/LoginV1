namespace H_P_II_Clase4
{
    partial class frmRegisttro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(83, 25);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(149, 16);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registrar nuevo usuario";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(83, 84);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(86, 118);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(86, 203);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 22);
            this.txtContraseña.TabIndex = 4;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(83, 169);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(79, 16);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(86, 301);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '*';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(100, 22);
            this.txtConfirmarContraseña.TabIndex = 6;
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(83, 267);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(139, 16);
            this.lblConfirmarContraseña.TabIndex = 5;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(86, 371);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(202, 371);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // frmRegisttro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtConfirmarContraseña);
            this.Controls.Add(this.lblConfirmarContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblRegistro);
            this.Name = "frmRegisttro";
            this.Text = "frmRegisttro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtConfirmarContraseña;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button Cancelar;
    }
}