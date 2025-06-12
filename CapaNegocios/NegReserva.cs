using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocios
{
    public class NegReserva
    {
        DataReserva objDataReserva = new DataReserva();
        public void IngresarReserva(Reserva objReserva)
        {
            objDataReserva.IngresarReserva(objReserva);
        }
        public List<Reserva> ActualizarReserva(string dni)
        {
            return objDataReserva.ActualizarReserva(dni);
        }

        public bool ReservaExiste(DateTime fecha, string hora, string local)
        {

            return objDataReserva.ReservaExiste(fecha, hora, local);

        }
        public List<ServicioSegunMascota> ListarServicioSegunTipo(string local, string servicio, DateTime fecha)
        {

            return objDataReserva.ListarServicioSegunTipo(local,servicio,fecha);
        }

        public int PonerPrecioServicio(string tipo,string servicio)
        {
            return objDataReserva.PonerPrecioServicio(tipo, servicio);
        }

        public List<Servicios_Por_Día_Semana> ListarServicio_PorDia(string local, DateTime fecha)
        {
            return objDataReserva.ListarServicio_PorDia(local, fecha);
        }

    }
}
