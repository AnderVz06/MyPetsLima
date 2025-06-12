using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataVacuna
    {
        public string IngresarVacuna(Vacuna objVacuna)
        {
            using (var contexto = new MyPetEntities())
            {
                contexto.Vacunas.Add(objVacuna);
                contexto.SaveChanges();
                return "Se registro exisamente una vacuna";
            }
        }
        public List<Vacuna> ActualizarVacuna()
        {
            MyPetEntities contexto = new MyPetEntities();
            var resultado = (from alguien in contexto.Vacunas
                             where (alguien.id < 10)
                             select alguien).ToList();
            return resultado;
            
        }
        public List<Vacuna> ListaVacunaControl(MascotaControl objMascotaControl)
        {
            MyPetEntities contexto = new MyPetEntities();
            List<Vacuna> listado = new List<Vacuna>();
            var resultado = (from alguien in contexto.Vacunas
                             where (alguien.Tipo.Equals(objMascotaControl.tipo))
                             select alguien).ToList();

            foreach(Vacuna obj in resultado)
            {
                if (obj.id < 10)
                    listado.Add(obj);
                     
            }
            
            return listado;
        }
        public List<Vacuna> VacunasDeUnAnimal(int id)
        {
            MyPetEntities contexto = new MyPetEntities();
            var resultado = (from alguien in contexto.Vacunas
                             where (alguien.CodMascota==id)
                             select alguien).ToList();
            return resultado;
        }

       public bool VacunaExiste(int codMasc, string nom)
        {
            bool res = false;
            MyPetEntities contexto = new MyPetEntities();
            var resultado = (from alguien in contexto.Vacunas
                             where (alguien.CodMascota == codMasc)
                             select alguien).ToList();

            foreach( Vacuna obj in resultado)
            {
                if (obj.Nombre == nom)
                    res = true; ;
                
            }

            return res;
        }

        
        public List<VacunasSegunMascota> VacunasSegunTipoMascota(string tipo)
        {
            List<VacunasSegunMascota> lista = new List<VacunasSegunMascota>();
            int total=0;
            MyPetEntities contexto = new MyPetEntities();

            var resultado = from vacuna in contexto.Vacunas
                            join mascota in contexto.Mascotas on vacuna.CodMascota equals mascota.Codigo
                            where (mascota.Tipo.Equals(tipo))
                            where (vacuna.Tipo.Equals(tipo))
                            group vacuna by vacuna.Nombre into newGroup
                            orderby newGroup.Key
                            select newGroup;

            
            foreach (var vacuna in resultado)
            {
                total++;
            }
            foreach (var vacuna in resultado)
            {
                VacunasSegunMascota obj = new VacunasSegunMascota();
                obj.nombreVacuna = vacuna.Key;
                obj.cant_vacuna = vacuna.Count();
                obj.porcentaje = (obj.porcentaje+(obj.cant_vacuna / total))*100;
                lista.Add(obj);
            }
            
            return lista;
        }
        
    }
}
