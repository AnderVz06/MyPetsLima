using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;

namespace MyPet
{
    public partial class FrmVerVacunas : Form
    {
        NegVacuna objNegVacuna = new NegVacuna();
        NegMascota objNegMascota = new NegMascota();
        public FrmVerVacunas()
        {
            InitializeComponent();
        }

        private void FrmVerVacunas_Load(object sender, EventArgs e)
        {
            MascotaControl objMascotaControl= objNegMascota.ListarControlMascota();
            
                int id = Convert.ToInt32(objMascotaControl.codigo);
                dgVacunas.DataSource = objNegVacuna.VacunasDeUnaMascota(id);
                dgVacunas.Columns["Tipo"].Visible = false;
                dgVacunas.Columns["id"].Visible = false;
                dgVacunas.Columns["CodMascota"].Visible = false;
                
        }

        private void btmVolver_Click(object sender, EventArgs e)
        {
            
        }
    }
}
