using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasDeInformacion2DataGridListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            string id = "id_usuario";
            string nombre = "nombres_usuario";
            int registrosafectados = 0;
            registrosafectados = Metodos.EjecutarConsulta(txtConsulta.Text);
            AccionesComunes.MensajeAviso("Registros Afectados" + registrosafectados);
            AccionesComunes.LlenarComboBox(txtConsulta.Text, cmbDatos, id, nombre);
        }

        private void cmbDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = cmbDatos.SelectedValue.ToString();
        }

        private void btnDataGrid_Click(object sender, EventArgs e)
        {
            AccionesComunes.LlenarDataGridView(txtConsulta.Text, dgvDatos);
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            AccionesComunes.LlenarListView(txtConsulta.Text, ltvDatos);
        }
    }
}
