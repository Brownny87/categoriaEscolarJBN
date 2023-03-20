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
    public partial class calcDias : Form
    {
        public calcDias()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime fechaIni = dateTimePicker1.Value;
            DateTime fechaFin = dateTimePicker2.Value;

            TimeSpan difDias = fechaFin.Subtract(fechaIni);

            boxDifDias.Text = "Entre las fechas seleccionadas hay " + difDias.Days.ToString() + " Dias";
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            boxDifDias.Text = "";
        }
    }
}
