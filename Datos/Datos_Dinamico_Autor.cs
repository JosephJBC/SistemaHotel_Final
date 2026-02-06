using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosDinamicoAutor
    {
        public Informacion_Autor ConsultarInformacion(SqlConnection cn)
        {
            Informacion_Autor info = null;
            String comando = "SELECT Nombre_Sistema, Duenio, Descripcion, Correo, Telefono, Ruta_Foto FROM Autor";
            SqlCommand cmd = new SqlCommand(comando, cn);
            SqlDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    info = new Informacion_Autor(
                        reader["Nombre_Sistema"].ToString(),
                        reader["Duenio"].ToString(),
                        reader["Descripcion"].ToString(),
                        reader["Correo"].ToString(),
                        reader["Telefono"].ToString(),
                        reader["Ruta_Foto"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar informacion del autor: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();
            }

            return info;
        }
    }
}
