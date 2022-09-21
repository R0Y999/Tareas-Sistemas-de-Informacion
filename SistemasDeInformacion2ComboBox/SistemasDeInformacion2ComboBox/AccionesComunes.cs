using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeInformacion2ComboBox
{
    internal class AccionesComunes
    {
        public static void MensajeAviso(string mensaje)
        {
            MessageBox.Show(mensaje, "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public static void LlenarComboBox(string consulta, ComboBox combo, string id, string nombre)
        {
            combo.Items.Clear();
            DataTable dt;
            dt = Metodos.EjecutarSeleccion(consulta);
            if (dt == null)
            {
                return;
            }
            DataRow dr = dt.NewRow();
            dr[0] = 0;
            dr[1] = "TODOS";
            dt.Rows.InsertAt(dr, 0);
            combo.DataSource = dt;
            combo.DisplayMember = nombre;
            combo.ValueMember = id;
        }
    }
}
