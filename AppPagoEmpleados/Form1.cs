using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPagoEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //entrada
            MessageBox.Show("Evento del mouse click");
            String nombre = txtNombre.Text;
            int horas = int.Parse(txtHoras.Text);
            double costo = double.Parse(txtCosto.Text);
            //Proceso
            double sueldoBruto = horas * costo;
            //salida
            lblBruto.Text = sueldoBruto.ToString("C");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento de limpiar los controles");
            txtNombre.Text = "";
            txtHoras.Clear();
            lblBruto.Text = "";
            txtNombre.Focus();
        }
    }
}
