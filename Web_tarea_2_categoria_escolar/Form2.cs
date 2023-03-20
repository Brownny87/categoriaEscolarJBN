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
    public partial class convMon : Form
    {
                
        public convMon()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
                    }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void boxCop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresar solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Tasas de cambio de COP a USD, EUR, CNY

            const double tasaUSD = 0.00027; 
            const double tasaEUR = 0.00020; 
            const double tasaCNY = 0.0014; 
            double cantCop, cantEur, cantUsd, cantCny;

            // convierte texto en Numero double para poder realizar calculos

            cantCop = Convert.ToDouble(boxCop.Text);

            //Convierte el monto ingresado en Cop a cda una de las otras divisas 

            cantUsd = cantCop * tasaUSD;
            cantEur = cantCop * tasaEUR;
            cantCny = cantCop * tasaCNY;
             
            // Muestra los calculos resultantes en cada una de las divisas

            boxUsd.Text = cantUsd.ToString();
            boxEur.Text = cantEur.ToString();
            boxCny.Text = cantCny.ToString();            
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            boxCop.Text = "";
            boxUsd.Text = "";
            boxEur.Text = "";
            boxCny.Text = "";
        }

        
    }
}
