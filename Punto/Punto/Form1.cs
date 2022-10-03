using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            PuntoX a, b;
            a = new PuntoX(Convert.ToDecimal(txtPuntoA.Text));
            b = new PuntoX(Convert.ToDecimal(txtPuntoB.Text));
            decimal d = a.calcularDistancia(b);
            MessageBox.Show("La resta es: " + d);
        }

        private void btnCalcularBidimencional_Click(object sender, EventArgs e)
        {
            PuntoX a, b, c, d;
            a = new PuntoX(Convert.ToDecimal(txtPuntoA.Text));
            b = new PuntoX(Convert.ToDecimal(txtPuntoB.Text));
            c = new PuntoX(Convert.ToDecimal(txtPuntoC.Text));
            d = new PuntoX(Convert.ToDecimal(txtPuntoD.Text));
            decimal f = a.calcularDistanciaBidimencional(b, c, d);
            MessageBox.Show("La distancia entre los dos puntos es: " + f);
        }
    }
}
