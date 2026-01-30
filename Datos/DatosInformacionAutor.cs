using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosInformacionAutor
    {
        public InformacionAutor ConsultarInformacion(SqlConnection cn)
        {
            InformacionAutor info = null;
            String comando = "SELECT Nombre_Sistema, Duenio, Direccion, Correo, Telefono, Ruta_Foto FROM Informacion_Autor";
            SqlCommand cmd = new SqlCommand(comando, cn);
            SqlDataReader reader = null;

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    info = new InformacionAutor(
                        reader["Nombre_Sistema"].ToString(),
                        reader["Duenio"].ToString(),
                        reader["Direccion"].ToString(),
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
