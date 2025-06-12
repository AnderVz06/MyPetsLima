using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocios
{
    public class NegLocal
    {
        DataLocal objNegLocal = new DataLocal();
        public void IngresarMascota(Local obj)
        {
             objNegLocal.IngresarMascota(obj);
        }
       
    }
}
