using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocios
{
    public class NegVacuna
    {
        DataVacuna objDataVacuna = new DataVacuna();
        public string IngresarVacuna(Vacuna objVacuna)
        {
            return objDataVacuna.IngresarVacuna(objVacuna);
        }
        public List<Vacuna> ActualizarVacuna ()
        {
            return objDataVacuna.ActualizarVacuna();
        }
        public List<Vacuna> ListaVacunaControl(MascotaControl objMascotaControl)
        {
            return objDataVacuna.ListaVacunaControl(objMascotaControl);
        }
        public List<Vacuna> VacunasDeUnaMascota(int id)
        {
            return objDataVacuna.VacunasDeUnAnimal(id);
        }

        public bool ExisteVacuna(int id, string nom)
        {
            return objDataVacuna.VacunaExiste(id, nom);
        }

        public List<VacunasSegunMascota> VacunasSegunTipoMascota(string tipo)
        {
            return objDataVacuna.VacunasSegunTipoMascota(tipo);
        }
    }
}
