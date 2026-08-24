using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1_Controles
{
    public partial class Pract1 : Form
    {
        public Pract1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAño_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAño_Click(object sender, EventArgs e)
        {

        }

        private void lblMes_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDia.Text) || String.IsNullOrWhiteSpace(txtMes.Text) || String.IsNullOrWhiteSpace(txtAño.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos requeridos");

            }
            else
            {
                lblOutput.Text = "La fecha es:";
                lblOutput.Text = lblOutput.Text + ":" + txtDia.Text + "/" + txtMes.Text + "/" + txtAño.Text;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrara la ventana");
            MessageBox.Show("Cerrando");
            this.Close();
        }
    }
}
