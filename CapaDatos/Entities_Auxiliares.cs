using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Entity_NumMascotas_Tipo_Local
    {
        public string tipoMascota { get; set; }
        public int cantidad_tipo { get; set; }

    }

    public class ServicioSegunMascota
    {
        public string TipoMascota { get; set; }
        public int cant_reserva { get; set; }

        public int dinero { get; set; }
    }

    public class VacunasSegunMascota
    {
        public string nombreVacuna { get; set; }
        public int porcentaje { get; set; }
        public int cant_vacuna { get; set; }
        
    }


    public class Servicios_Por_Día_Semana
    {
        public int Cantidad_Servicio { get; set; }
        public DateTime fecha { get; set; }
       
        public string dia_semana { get; set; }
        public void dia()
        {

            dia_semana = fecha.DayOfWeek.ToString();

        }
    }
}

