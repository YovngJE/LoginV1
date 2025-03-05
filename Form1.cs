using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_P_II_Clase4
{
    public partial class formPrinci : Form
    {
        string contrseña = "123";
        string user="Perea";
        int intentosF=0;
        public formPrinci()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BntOK_Click(object sender, EventArgs e)
        {
            if (contrseña == txtPass.Text && user == txtUser.Text)
            {
                Form2 f = new Form2(txtUser.Text);
                f.Show();
            }
            else
            { 
                intentosF++;
                if (intentosF>=3)
                {
                    MessageBox.Show("Demasiados intentos fallidos. El formulario se cerrará.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}
