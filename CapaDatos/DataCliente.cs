using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataCliente
    {
        public string IngresarCliente(Cliente objCliente)
        {
            using (var contexto = new MyPetEntities())
            {
                contexto.Clientes.Add(objCliente);
                contexto.SaveChanges();
                return "Se registro exisamente un cliente";
            }
        }
        public List<Cliente> ActualizarCliente()
        {
            var contexto = new MyPetEntities();
            return contexto.Clientes.ToList<Cliente>();
        }
        public List<Cliente> BuscarCliente(string cli)
        {
            MyPetEntities contexto = new MyPetEntities();
            var resultado = (from alguien in contexto.Clientes
                             where alguien.Nombre.StartsWith(cli) select alguien ).ToList();
            return resultado;
        }

        public bool ClienteExiste(string id)
        {
            var contexto = new MyPetEntities();
            if (contexto.Clientes.Find(id) != null)
            {
                return true;
            }

            else
                return false;
        }

        public List<Cliente> RecordatorioCliente()
        {

            var contexto = new MyPetEntities();
            List<Cliente> lista = new List<Cliente>();

            DateTime fecha = new DateTime();
            fecha = DateTime.Today;
            fecha = fecha.AddDays(1);
            var listaMacota = (from alguien in contexto.Mascotas
                               where (alguien.FechaVacuna.Value.Year == fecha.Year)
                               where (alguien.FechaVacuna.Value.Day== fecha.Day)
                               where(alguien.FechaVacuna.Value.Month==fecha.Month)
                               where(alguien.FechaVacuna.Value.Hour!=fecha.Hour)
                               //where (alguien.FechaVacuna.Value==DateTime.Today.AddDays(1))
                             select alguien).ToList();

            foreach(Cliente clien in contexto.Clientes)
            {
                foreach(Mascota masc in listaMacota)
                {
                    if(masc.CodigoCliente==clien.dni)
                    {
                        lista.Add(clien);
                    }
                }
            }
            HashSet<Cliente> resultado = new HashSet<Cliente>(lista);
            List<Cliente> lista1 = resultado.ToList();
            return lista1;

        }

    }
}
