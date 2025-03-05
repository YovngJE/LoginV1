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
    public partial class Form2 : Form
    {
        string nombrerecibido;
        public Form2(string valor)
        {
            InitializeComponent();
            lblMsgRec.Text = valor;
          lblMsgRec.Text= "Bienvenido " +valor;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblMsgRec_Click(object sender, EventArgs e)
        {

        }
    }
}
