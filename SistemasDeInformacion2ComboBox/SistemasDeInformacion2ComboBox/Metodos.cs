using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemasDeInformacion2ComboBox
{
    internal class Metodos
    {
        static SqlConnection cnx;
        static string cadena = "Server=localhost;Database=Restaurante;Trusted_Connection=True;";
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
            cnx.Open();
            SqlCommand cmd = new SqlCommand(consulta, cnx);
            filasAfectadas = cmd.ExecuteNonQuery();
            cnx.Close();
            return filasAfectadas;
        }
        public static object EjecutarEscalar(string consulta)
        {
            dt = new DataTable();
            cnx.Open();
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnx);
            da.Fill(dt);
            cnx.Close();
            return dt.NewRow();
        }
        public static DataTable EjecutarSeleccion(string consulta)
        {
            dt = new DataTable();
            cnx.Open();
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnx);
            da.Fill(dt);
            cnx.Close();
            return dt;
        }
    }
}
