using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeInformacion2DataGridListView
{
    internal class AccionesComunes
    {
        static ListViewItem obj;
        public static void MensajeAviso(string mensaje)
        {
            MessageBox.Show(mensaje, "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void LlenarComboBox(string consulta, ComboBox combo, string id, string nombre)
        {
            DataTable dt;
            dt = Metodos.EjecutarSeleccion(consulta);
            if (dt == null)
            {
                return;
            }
            DataRow dr = dt.NewRow();
            dr[0] = 0;
            dr[2] = "TODOS";   
            combo.DataSource = dt;
            combo.DisplayMember = nombre;
            combo.ValueMember = id;
            dt.Rows.InsertAt(dr, 0);
            combo.SelectedValue = 0;
        }
        public static object LlenarDataGridView(string consulta, DataGridView dgv)
        {
            dgv.Columns.Clear();
            DataTable dt = new DataTable();
            dt = Metodos.EjecutarSeleccion(consulta);
            dgv.DataSource = dt;
            return dt;
        }
        public static object LlenarListView(string consulta, ListView ltv)
        {
            DataTable dt = new DataTable();
            ltv.View = View.Details;
            dt = Metodos.EjecutarSeleccion(consulta);
            ltv.Clear();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                ltv.Columns.Add(dt.Columns[i].ColumnName, 100);
            }
            for (int i = 0; i < (dt.Rows.Count); i++)
            {
                DataRow fila = dt.Rows[i];

                obj = new ListViewItem(fila[dt.Columns[0].ColumnName].ToString());
                for (int x = 1; x < dt.Columns.Count; x++)
                {
                    obj.SubItems.Add(fila[dt.Columns[x].ColumnName].ToString());
                }
                ltv.Items.Add(obj);
            }
            return dt;
        }
    }
}
