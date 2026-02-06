using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
namespace Controlador
{
    public class Adm_Detalle_De_Reserva
    {
        List<Servicio> listaServicios = new List<Servicio>();
        public Adm_Detalle_De_Reserva()
        {
            LlenarServicio();
        }
        public void LlenarComboServicio(ComboBox cmbServicios)
        {
            cmbServicios.Items.Clear();
            foreach (Servicio servicio in listaServicios)
            {
                cmbServicios.Items.Add("Tipo de servicio: " + servicio.Tipo_Servicio + ", Precio: " +
                    servicio.Precio);
            }
        }
        private void LlenarServicio()
        {
            listaServicios.Clear();
            listaServicios.Add(new Servicio
            {
                Id_Servicio = 1,
                Tipo_Servicio = "Sauna",
                Precio = 10
            });
            listaServicios.Add(new Servicio
            {
                Id_Servicio = 2,
                Tipo_Servicio = "Gimnasio",
                Precio = 5
            });
            listaServicios.Add(new Servicio
            {
                Id_Servicio = 3,
                Tipo_Servicio = "Transporte",
                Precio = 15
            });
            listaServicios.Add(new Servicio
            {
                Id_Servicio = 4,
                Tipo_Servicio = "Piscina",
                Precio = 7
            });
            listaServicios.Add(new Servicio
            {
                Id_Servicio = 5,
                Tipo_Servicio = "Lavanderia",
                Precio = 5
            });
        }
        public Servicio ObtenerServicio(int indice)
        {
            if (indice >= 0 && indice < listaServicios.Count)
            {
                return listaServicios[indice];
            }
            return null; 
        }
        public double ObtenerPrecioServicioPorIndice(int indice)
        {
            if (indice >= 0 && indice < listaServicios.Count)
            {
                return listaServicios[indice].Precio;
            }
            return 0;
        }
    }
}

   

