using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataLocal
    {
        public void IngresarMascota(Local objLocal)
        {
            using (var contexto = new MyPetEntities())
            {
                contexto.Local.Add(objLocal);
                contexto.SaveChanges();
              
            }
        }
    }
}
