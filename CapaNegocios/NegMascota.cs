using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class NegMascota
    {
        DataMascota objDataMascota = new DataMascota();
        public string IngresarMascota(Mascota objMascota)
        {
            return objDataMascota.IngresarMascota(objMascota);
        }
        public List<Mascota> ActualizarMascota()
        {
            return objDataMascota.ActualizarMascota();
        }

        public void ModificarFechaMascota(int id, DateTime fecha)
        {
             objDataMascota.ModificarFechaMascota(id, fecha);
        }
        public List<Mascota> ListarMascotaDeUnCliente(string dni)
        {
            return objDataMascota.ListarMascotaDeUnCliente(dni);
        }
        public void listarTemporal(MascotaControl objMascotaControl)
        {
            objDataMascota.ListaTemporal(objMascotaControl);
        }
        public MascotaControl ListarControlMascota()
        {
            return objDataMascota.ListarControlMascota();
        }
        public void BorrarListaTemporal()
        {
            objDataMascota.BorrarListaTemporal();
        }
        public bool ListaExiste()
        {
            return objDataMascota.ListaExiste();
        }

        public List<Entity_NumMascotas_Tipo_Local> Lista_Cantidad_Tipo(string local, DateTime fecha)
        {
            return objDataMascota.Mascotas_Tipo_Locals(local, fecha);
        }
    }
}
