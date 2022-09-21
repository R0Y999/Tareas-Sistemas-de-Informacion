using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeInformacion2ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            cmbDatos.Items.Add("TODOS");
            string id = "id_Usuarios";
            string nombre = "nombre_Usuario";
            int registrosafectados = 0;
            registrosafectados = Metodos.EjecutarConsulta(txtConsulta.Text);
            AccionesComunes.MensajeAviso("Registros Afectados" + registrosafectados);
            AccionesComunes.LlenarComboBox(txtConsulta.Text, cmbDatos, id, nombre);
        }

        private void cmbDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = cmbDatos.SelectedValue.ToString();
        }
    }
}
