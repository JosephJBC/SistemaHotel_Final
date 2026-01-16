using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class conexion
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["MiConexion_Joseph"].ConnectionString;

        public SqlConnection Cn { get; set; }

        public string conectar()
        {
            try
            {
                Cn = new SqlConnection();
                Cn.ConnectionString = cadena;
                Cn.Open();
                return "1";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return "0" + ex.Message;
            }
        }

        public string cerrar()
        {
            try
            {
                Cn.Close();
                return "1";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return "0" + ex.Message;
            }
        }
    }
}
