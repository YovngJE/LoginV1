using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;
namespace H_P_II_Clase4
{
    public partial class frmRegisttro : Form
    {
        public frmRegisttro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string confirmacion = txtConfirmarContraseña.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(confirmacion))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contraseña != confirmacion)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SQLiteConnection conexion = null;
            SQLiteCommand cmdCheckcd = null;
            SQLiteCommand cmd = null;

            try
            {
                conexion = new SQLiteConnection("Data Source=database.db;Version=3;");
                conexion.Open();

                cmdCheckcd = new SQLiteCommand("SELECT COUNT(*) FROM tblUser WHERE name = @usuario", conexion);
                cmdCheckcd.Parameters.Add("@usuario", usuario);

                int count = Convert.ToInt32(cmdCheckcd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("El usuario ya existe. Intente con otro nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmd = new SQLiteCommand("INSERT INTO tblUser (name, pass) VALUES (@usuario, @pass)", conexion);
                cmd.Parameters.Add("@usuario", usuario);
                cmd.Parameters.Add("@pass", contraseña);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuario registrado exitosamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cmdCheckcd != null) cmdCheckcd.Dispose();
                if (cmd != null) cmd.Dispose();
                if (conexion != null) conexion.Close();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelRegistrarUsuario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
