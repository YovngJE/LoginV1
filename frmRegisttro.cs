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
            string nombre = txtUsuario.Text.Trim();
            string pass = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SQLiteConnection conexion = ConexionBD.Instancia.ObtenerConexion())
                {
                    // Verificar si el usuario ya existe
                    string verificarQuery = "SELECT COUNT(*) FROM tblUser WHERE name = @name";
                    using (SQLiteCommand verificarCmd = new SQLiteCommand(verificarQuery, conexion))
                    {
                        verificarCmd.Parameters.Add("@name", nombre);
                        int existe = Convert.ToInt32(verificarCmd.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show("El usuario ya existe. Intente con otro nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insertar nuevo usuario
                    string insertQuery = "INSERT INTO tblUser (name, pass) VALUES (@name, @pass)";
                    using (SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, conexion))
                    {
                        insertCmd.Parameters.Add("@name", nombre);
                        insertCmd.Parameters.Add("@pass", pass);
                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Registro exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar usuario:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
