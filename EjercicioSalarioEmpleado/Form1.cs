using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioSalarioEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcularSalario_Click(object sender, EventArgs e)
        {
            double horastrabajadas = double.Parse(txthorastrabajadas.Text);
            double valorhora = double.Parse(txtValorHora.Text);
            double total = horastrabajadas * valorhora;

            if(total > 750000) {
                MessageBox.Show("El empleadogana mas del Minimo");
            } else {
                total = (total * 0.20) + total;
                }
            lblTotalSalario.Text = "$"+Convert.ToDecimal(total).ToString("N0");
            lblTotalSalario.Visible = true;


        }
    }
}
