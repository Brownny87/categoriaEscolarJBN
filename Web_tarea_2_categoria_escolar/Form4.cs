using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_tarea_2_categoria_escolar
{
    public partial class convTemp : Form
    {
        public convTemp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void montoCop_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            double cantCel, cantFah, cantKel;
            
            cantCel = Convert.ToDouble(boxCel.Text);
            
            cantFah = (cantCel * 1.8) + 32;
            cantKel = cantCel + 273.15;

            boxFah.Text = cantFah.ToString();
            boxKel.Text = cantKel.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            boxCel.Text = "";
            boxFah.Text = "";
            boxKel.Text = "";
        }

        private void boxCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresar solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void convTemp_Load(object sender, EventArgs e)
        {

        }
    }
}
