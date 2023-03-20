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
    public partial class calc : Form
    {
        double numero1 = 0, numero2 = 0;
        char operador;

        public calc()
        {
            InitializeComponent();
        }

        private void calc_Load(object sender, EventArgs e)
        {

        }
        private void agregarNumero (string numero)
        {
            if (boxResultado.Text == "0") 
                boxResultado.Text = "";
            boxResultado.Text += numero;
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(boxResultado.Text);
            if (operador == '+')
            {
                boxResultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(boxResultado.Text);
            }
            else if (operador == '-')
            {
                boxResultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(boxResultado.Text);
            }
            else if (operador == '*')
            {
                boxResultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(boxResultado.Text);
            }
            else if (operador == '/')
            {
                if(boxResultado.Text != "0")
                { 
                boxResultado.Text = (numero1 / numero2).ToString();
                numero1 = Convert.ToDouble(boxResultado.Text);
                }
                else
                {
                    MessageBox.Show("No se puede Dividir por Cero");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(boxResultado.Text.Length > 1)
            {
                boxResultado.Text = boxResultado.Text.Substring(0, boxResultado.Text.Length - 1);
            }
            else
            {
                boxResultado.Text = "0";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operador = '\0';
            boxResultado.Text = "0";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            boxResultado.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!boxResultado.Text.Contains("."))
            {
                boxResultado.Text += ",";
            }
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(boxResultado.Text);
            numero1 *= -1;
            boxResultado.Text = numero1.ToString();
        }

        private void clickoperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            numero1 = Convert.ToDouble(boxResultado.Text);
            operador = Convert.ToChar(boton.Tag);

            if (operador == '²')
            {
                numero1 = Math.Pow(numero1, 2);
                boxResultado.Text=numero1.ToString();
            }
            else if (operador == '√')
            {
                numero1 = Math.Sqrt(numero1);
                boxResultado.Text = numero1.ToString();
            }
            else { 
            
            boxResultado.Text = "0";
            }
        }
    }
}
