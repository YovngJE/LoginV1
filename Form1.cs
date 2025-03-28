using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace H_P_II_Clase4
{
    public partial class formPrinci : Form
    {
        
        private int intentosFallidos = 0;
        private const int MAX_INTENTOS = 3;
        public formPrinci()
        {
            InitializeComponent();
            Conexion();
        }

        public void Conexion()
        {
            
            

            // Crear conexión a SQLite
            SQLiteConnection conexion_sqlite = new SQLiteConnection($"Data Source=database.db;Version=3;Compress=True; New= True;");
            conexion_sqlite.Open();

            // Crear comando SQL
            SQLiteCommand cmd_sqlite = conexion_sqlite.CreateCommand();

            // Crear la tabla si no existe
            cmd_sqlite.CommandText = "CREATE TABLE  tblUser (id INTEGER PRIMARY KEY, name VARCHAR(100) UNIQUE, pass VARCHAR(100) );";
            cmd_sqlite.ExecuteNonQuery();


            cmd_sqlite.CommandText = @"
            INSERT INTO tblUser (name, pass) VALUES ('YE', '123');
            INSERT INTO tblUser (name, pass) VALUES ('Trainer', '102458J');
            INSERT INTO tblUser (name, pass) VALUES ('Blackie', 'Perea17');
            INSERT INTO tblUser (name, pass) VALUES ('Jeni', '1025');
             ";

            cmd_sqlite.ExecuteNonQuery();

            // Cerrar conexión
            conexion_sqlite.Close();
        }

        public bool ValidarUsuario(string contraseña,string usuario) {
            SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source=database.db;Version=3;");
            sQLiteConnection.Open();

            SQLiteCommand conexion_sql =new SQLiteCommand("SELECT pass FROM tblUser WHERE name = @usuario", sQLiteConnection);
            conexion_sql.Parameters.Add("@usuario", usuario);

            object result = conexion_sql.ExecuteScalar();
            if (result != null)
            {
                string contraseñaAlmacenada = result.ToString();
                return contraseñaAlmacenada == contraseña;
            }
            return false;
        }

        public bool UsuarioExiste(string usuario)
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source=database.db;Version=3;");
            sQLiteConnection.Open();
            using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM tblUser WHERE name = @usuario", sQLiteConnection))
            {
                cmd.Parameters.Add("@usuario", usuario);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }


        private void BntOK_Click(object sender, EventArgs e)
        {
           string usuario = txtUser.Text.Trim();
            string contraseña = txtPass.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!UsuarioExiste(usuario))
            {
                MessageBox.Show("El usuario no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarUsuario(contraseña,usuario))
            {
                MessageBox.Show("Inicio de sesion exito!");
                Form2 f = new Form2(txtUser.Text);
                f.Show();
                this.Hide();
            }
            else
            {
                intentosFallidos++;
                MessageBox.Show($"Usuario o contraseña incorrectos. Intento {intentosFallidos} de {MAX_INTENTOS}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (intentosFallidos >= MAX_INTENTOS)
                {
                    MessageBox.Show("Demasiados intentos fallidos. Intente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BntOK.Enabled = false; // Deshabilita el botón de login
                }
            }

           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            
            frmRegisttro frm = new frmRegisttro();
            if (frm.ShowDialog() == DialogResult.OK) // Solo limpia si el usuario se registró
            {
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus(); // Pone el cursor en el campo de usuario
            }
        }

        private void lblMensajeRegistro_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
