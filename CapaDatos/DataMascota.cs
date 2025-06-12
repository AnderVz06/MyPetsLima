using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataMascota
    {
        public string IngresarMascota(Mascota objMascota)
        {
            using (var contexto = new MyPetEntities())
            {
                contexto.Mascotas.Add(objMascota);
                contexto.SaveChanges();
                return "Se registro exisamente una mascota";
            }
        }
        public List<Mascota> ActualizarMascota()
        {
            var contexto = new MyPetEntities();
            return contexto.Mascotas.ToList<Mascota>();
        }
        public List<Mascota> ListarMascotaDeUnCliente(string dni)
        {
            MyPetEntities contexto = new MyPetEntities();
            var resultado = (from alguien in contexto.Mascotas
                             where (alguien.CodigoCliente.Equals(dni))
                             select alguien).ToList();
            return resultado;
        }

        public void ModificarFechaMascota(int id, DateTime fecha)
        {
            using (var contexto = new MyPetEntities())
            {
                var mod = contexto.Mascotas.Find(id);
    
                mod.FechaVacuna = fecha.AddMonths(3);
                contexto.SaveChanges();
            }
        }
        public void ListaTemporal(MascotaControl objMascotaControl)
        {
            using (var contexto = new MyPetEntities())
            {
                contexto.MascotaControl.Add(objMascotaControl);
                contexto.SaveChanges();
            }
        }
        public void BorrarListaTemporal()
        {
            using (var contexto = new MyPetEntities())
            {
               
                    var eliminar = contexto.MascotaControl.Remove(contexto.MascotaControl.Find(0));
                    contexto.SaveChanges();
                
            }
        }
        public MascotaControl ListarControlMascota()
        {
            MyPetEntities contexto = new MyPetEntities();
            return contexto.MascotaControl.Find(0);
        }
        public bool ListaExiste()
        {
            MyPetEntities contexto = new MyPetEntities();
            if(contexto.MascotaControl.Find(0)==null)
            {
                return false;
            }
            else
            {
                return true;
            }
                
        }

       public List<Entity_NumMascotas_Tipo_Local> Mascotas_Tipo_Locals(string local, DateTime fecha)
        {
            List<Entity_NumMascotas_Tipo_Local> lista = new List<Entity_NumMascotas_Tipo_Local>();
            MyPetEntities contexto = new MyPetEntities();

            var resultado = from locl in contexto.Local
                            join mascota in contexto.Mascotas on locl.codigoMascota equals mascota.Codigo
                            where (mascota.Local.Equals(local))
                            where (mascota.FechaRegistro.Value.Year.Equals(fecha.Year))
                            group mascota by mascota.Tipo into nuevoGrupo
                            orderby nuevoGrupo.Key
                            select nuevoGrupo;

            foreach(var res in resultado)
            {
                Entity_NumMascotas_Tipo_Local obj = new Entity_NumMascotas_Tipo_Local();
                obj.tipoMascota = res.Key;
                obj.cantidad_tipo = res.Count();

                lista.Add(obj);
            }

            return lista;
        }
        

    }
}
