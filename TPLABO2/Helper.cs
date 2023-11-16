using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLABO2
{
    internal class Helper
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader lector;
        string cadenaConexion;

        public Helper()
        {
            cadenaConexion = @"Data Source=DESKTOP-EEU1F57\SQLEXPRESS;Initial Catalog=TP_LABO_2;Integrated Security=True;Encrypt=False";
            cnn = new SqlConnection(cadenaConexion);
            cmd = new SqlCommand();
        }

        public DataTable consultarBD(string nombreSP)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;
        }
    }
}
