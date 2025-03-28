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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisttro));
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtConfirmarContraseña = new System.Windows.Forms.TextBox();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.panelRegistrarUsuario = new System.Windows.Forms.Panel();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRegistrarUsuario.SuspendLayout();
            this.panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblRegistro.Location = new System.Drawing.Point(50, 20);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(251, 54);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "REGÍSTRATE";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsuario.Location = new System.Drawing.Point(55, 80);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 23);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(50, 110);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(300, 30);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(50, 190);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(300, 30);
            this.txtContraseña.TabIndex = 4;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblContraseña.Location = new System.Drawing.Point(50, 160);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(101, 23);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtConfirmarContraseña
            // 
            this.txtConfirmarContraseña.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarContraseña.Location = new System.Drawing.Point(52, 270);
            this.txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            this.txtConfirmarContraseña.PasswordChar = '*';
            this.txtConfirmarContraseña.Size = new System.Drawing.Size(300, 30);
            this.txtConfirmarContraseña.TabIndex = 6;
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContraseña.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(50, 240);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(182, 23);
            this.lblConfirmarContraseña.TabIndex = 5;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrar.Location = new System.Drawing.Point(50, 315);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(300, 35);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.IndianRed;
            this.Cancelar.FlatAppearance.BorderSize = 0;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(50, 368);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(300, 35);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // panelRegistrarUsuario
            // 
            this.panelRegistrarUsuario.BackColor = System.Drawing.Color.DarkKhaki;
            this.panelRegistrarUsuario.Controls.Add(this.Cancelar);
            this.panelRegistrarUsuario.Controls.Add(this.btnRegistrar);
            this.panelRegistrarUsuario.Controls.Add(this.txtConfirmarContraseña);
            this.panelRegistrarUsuario.Controls.Add(this.lblConfirmarContraseña);
            this.panelRegistrarUsuario.Controls.Add(this.txtContraseña);
            this.panelRegistrarUsuario.Controls.Add(this.lblContraseña);
            this.panelRegistrarUsuario.Controls.Add(this.txtUsuario);
            this.panelRegistrarUsuario.Controls.Add(this.lblUsuario);
            this.panelRegistrarUsuario.Controls.Add(this.lblRegistro);
            this.panelRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRegistrarUsuario.Location = new System.Drawing.Point(-1, 1);
            this.panelRegistrarUsuario.Name = "panelRegistrarUsuario";
            this.panelRegistrarUsuario.Size = new System.Drawing.Size(400, 403);
            this.panelRegistrarUsuario.TabIndex = 9;
            // 
            // panelImagen
            // 
            this.panelImagen.Controls.Add(this.pictureBox1);
            this.panelImagen.Location = new System.Drawing.Point(400, 1);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(381, 408);
            this.panelImagen.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::H_P_II_Clase4.Properties.Resources.Logos1;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmRegisttro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.panelImagen);
            this.Controls.Add(this.panelRegistrarUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegisttro";
            this.Text = "Registrarse";
            this.panelRegistrarUsuario.ResumeLayout(false);
            this.panelRegistrarUsuario.PerformLayout();
            this.panelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panelRegistrarUsuario;
        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}