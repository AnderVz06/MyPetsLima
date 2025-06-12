using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class NegCliente
    {
        DataCliente objDataCliente = new DataCliente();
        public string IngresarCliente(Cliente objCliente)
        {
            return objDataCliente.IngresarCliente(objCliente);
        }
        public List<Cliente> ActualizarCliente()
        {
            return objDataCliente.ActualizarCliente();
        }
        public List<Cliente> BuscarCliente(string cli)
        {
            return objDataCliente.BuscarCliente(cli);
        }

        public bool ClienteExiste(string id)
        {
            return objDataCliente.ClienteExiste(id);
        }

        public List<Cliente> RecordatorioCliente()
        {
            return objDataCliente.RecordatorioCliente();
        }

        
       
    }
}
