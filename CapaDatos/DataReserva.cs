using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataReserva
    {
        public void IngresarReserva(Reserva objReserva)
        {
            using (var contexto = new MyPetEntities())
            {
                contexto.Reservas.Add(objReserva);
                contexto.SaveChanges();
            }
        }
        public List<Reserva> ActualizarReserva(string dni)
        {
            MyPetEntities contexto = new MyPetEntities();
            var resultado = (from alguien in contexto.Reservas
                             where (alguien.CodCliente.Equals(dni))
                             select alguien).ToList();
            return resultado;

        }

        public bool ReservaExiste(DateTime fecha, string hora, string local)
        {

            //debe validar fecha, hora y local
            bool t=false;
            var contexto = new MyPetEntities();

            foreach (Reserva nuevaReserva in contexto.Reservas)
            {
                if (nuevaReserva.Hora == hora && nuevaReserva.Fecha.Value.Day == fecha.Day && nuevaReserva.Fecha.Value.Month == fecha.Month && nuevaReserva.Fecha.Value.Year == fecha.Year && nuevaReserva.Local == local)
                {
                    t= true;
                }
                else
                {
                    t= false;
                }

            }

            return t;


        }

        public List<ServicioSegunMascota> ListarServicioSegunTipo(string local, string servicio, DateTime fecha)
        {
            List<ServicioSegunMascota> lista = new List<ServicioSegunMascota>();

            MyPetEntities contexto = new MyPetEntities();

            var resultado = from mascota in contexto.Mascotas
                            join reserv in contexto.Reservas on mascota.Codigo equals reserv.CodMascota
                            where (reserv.Servicio.Equals(servicio))
                            where (reserv.Local.Equals(local))
                            where (reserv.Fecha.Value.Month == (fecha.Month))
                            group mascota by mascota.Tipo into newGroup
                            orderby newGroup.Key
                            select newGroup;


            foreach (var resr in resultado)
            {
                ServicioSegunMascota obj = new ServicioSegunMascota();
                obj.TipoMascota = resr.Key;

                obj.cant_reserva = resr.Count();
                if (obj.TipoMascota == "Conejo")
                {
                    if (servicio == "Hospedaje")
                    {
                        obj.dinero = obj.cant_reserva * 30;
                    }

                    if (servicio == "Baños/cortes")
                    {
                        obj.dinero = obj.cant_reserva * 35;
                    }
                    if (servicio == "Tratamientos")
                    {
                        obj.dinero = obj.cant_reserva * 32; ;
                    }
                }
                if (obj.TipoMascota == "Perro")
                {
                    if (servicio == "Hospedaje")
                    {
                        obj.dinero = obj.cant_reserva * 15;
                    }

                    if (servicio == "Baños/cortes")
                    {
                        obj.dinero = obj.cant_reserva * 30;
                    }
                    if (servicio == "Tratamientos")
                    {
                        obj.dinero = obj.cant_reserva * 25;
                    }
                }

                if (obj.TipoMascota == "Gato")
                {
                    if (servicio == "Hospedaje")
                    {
                        obj.dinero = obj.cant_reserva * 15;
                    }

                    if (servicio == "Baños/cortes")
                    {
                        obj.dinero = obj.cant_reserva * 25;
                    }
                    if (servicio == "Tratamientos")
                    {
                        obj.dinero = obj.cant_reserva * 20;
                    }

                }

                lista.Add(obj);
            }
           
            return lista;
        } 
           
           
        

        public int PonerPrecioServicio(string tipo,string servicio)
        {
            int precio = 0;
            if(tipo=="Conejo")
            {
                if(servicio=="Hospedaje")
                {
                    precio =23;
                }

                if (servicio == "Baños/cortes")
                {
                    precio = 35;
                }
                if (servicio == "Tratamientos")
                {
                    precio = 32;
                }
            }

            if (tipo == "Perro")
            {
                if (servicio == "Hospedaje")
                {
                    precio = 15;
                }

                if (servicio == "Baños/cortes")
                {
                    precio = 30;
                }
                if (servicio == "Tratamientos")
                {
                    precio = 25;
                }
            }

            if (tipo == "Gato")
            {
                if (servicio == "Hospedaje")
                {
                    precio = 15;
                }

                if (servicio == "Baños/cortes")
                {
                    precio = 35;
                }
                if (servicio == "Tratamientos")
                {
                    precio = 20;
                }
            }

            return precio;
        }

        public List<Servicios_Por_Día_Semana> ListarServicio_PorDia(string local, DateTime fecha)
        {
            List<Servicios_Por_Día_Semana> lista = new List<Servicios_Por_Día_Semana>();

            MyPetEntities contexto = new MyPetEntities();
            var resultado = from reserv in contexto.Reservas
                            join Mascota in contexto.Mascotas on reserv.CodMascota equals Mascota.Codigo
                            where (reserv.Local.Equals(local))
                            //where (reserv.Fecha.Value.Month == (6))
                            //where (reserv.Fecha.Value.Year == (2022))
                            where (reserv.Fecha.Value.Month == fecha.Month)
                            where (reserv.Fecha.Value.Year == fecha.Year)
                            group reserv by reserv.DiaSemana into newGroup
                            orderby newGroup.Key
                            select newGroup;


            foreach (var resr in resultado)
            {

                Servicios_Por_Día_Semana obj = new Servicios_Por_Día_Semana();

                

                obj.dia_semana = resr.Key;


                foreach (Reserva objreserva in resr)
                {
                    if (obj.dia_semana.Equals("lunes") || obj.dia_semana.Equals("Monday"))
                    {

                        obj.Cantidad_Servicio++;

                    }
                    if (obj.dia_semana.Equals("martes") || obj.dia_semana.Equals("Tuesday"))
                    {
                        obj.Cantidad_Servicio++;
                    }

                    if (obj.dia_semana.Equals("miércoles") || obj.dia_semana.Equals("Wednesday"))
                    {
                        obj.Cantidad_Servicio++;

                    }

                    if (obj.dia_semana.Equals("jueves") || obj.dia_semana.Equals("Thursday"))
                    {
                        obj.Cantidad_Servicio++;
                    }

                    if (obj.dia_semana.Equals("viernes") || obj.dia_semana.Equals("Friday"))
                    {
                        obj.Cantidad_Servicio++;
                    }

                    if (obj.dia_semana.Equals("sabado") || obj.dia_semana.Equals("Saturday"))
                    {
                        obj.Cantidad_Servicio++;
                    }

                    if (obj.dia_semana.Equals("domingo") || obj.dia_semana.Equals("Sunday"))
                    {
                        obj.Cantidad_Servicio++;
                    }
                }






                lista.Add(obj);



            }

            return lista;
        }

    }


}
