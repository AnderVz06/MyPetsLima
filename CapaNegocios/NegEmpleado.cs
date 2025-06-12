using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class NegEmpleado
    {
        DataEmpleado objDataEmpleado = new DataEmpleado();
        public Empleado login(Empleado objEmpleado)
        {
            return objDataEmpleado.login(objEmpleado);
        }
    }
}
