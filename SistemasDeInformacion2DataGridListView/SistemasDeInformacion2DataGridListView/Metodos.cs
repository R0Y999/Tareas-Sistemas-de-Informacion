using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeInformacion2DataGridListView
{
    internal class Metodos
    {
        static SqlConnection cnx;
        static string cadena = "Server=DESKTOP-M1DAVVI\\SQLEXPRESS;Database=Restaurante;Trusted_Connection=True;";
        public static DataTable dt;
        private static void Conectar()
        {
            cnx = new SqlConnection(cadena);
            cnx.Open();
        }
        private static void Desconectar()
        {
            cnx.Close();
            cnx = null;
        }
        public static int EjecutarConsulta(string consulta)
        {
            int filasAfectadas = 0;
            Conectar();
            SqlCommand cmd = new SqlCommand(consulta, cnx);
            filasAfectadas = cmd.ExecuteNonQuery();
            Desconectar();
            return filasAfectadas;
        }
        public static object EjecutarEscalar(string consulta)
        {
            dt = new DataTable();
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnx);
            da.Fill(dt);
            Desconectar();
            return dt.NewRow();
        }
        public static DataTable EjecutarSeleccion(string consulta)
        {
            dt = new DataTable();
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnx);
            da.Fill(dt);
            Desconectar();
            return dt;
        }
    }
}
