using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataEmpleado
    {
        public Empleado login(Empleado objEmpleado)
        {
            using (var contexto = new MyPetEntities())
            {
                var resultado = (from alguien in contexto.Empleados
                                 where alguien.usuario == objEmpleado.usuario && alguien.contraseña == objEmpleado.contraseña
                                 && alguien.activo == true
                                 select alguien).SingleOrDefault();
                return resultado;
            }
        }
    }
}
