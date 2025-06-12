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
    public partial class FrmControlVacuna : Form
    {
        
        public FrmControlVacuna()
        {
            InitializeComponent();
        }
        NegCliente objNegCliente = new NegCliente();
        NegMascota objNegMascota = new NegMascota();
        public void ActualizarData()
        {
            string CodigoDni = Convert.ToString(txtDni.Text);
            dgMascota.DataSource = objNegMascota.ListarMascotaDeUnCliente(CodigoDni);
            dgMascota.Columns["CodigoCliente"].Visible = false;
            dgMascota.Columns["Codigo"].Visible = false;
            dgMascota.Columns["FechaRegistro"].Visible = false;
            dgMascota.Columns["FechaVacuna"].Visible = false;
        }
        public void btmBuscar_Click(object sender, EventArgs e)
        {
            ActualizarData();
        }

        private void dgMascota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool dobleClik = false;
            if (objNegMascota.ListaExiste() )
            {
                dobleClik = true;
            }

            else
            {
                int id = Convert.ToInt16(dgMascota.SelectedRows[0].Cells[0].Value);
                string tipo = dgMascota.SelectedRows[0].Cells[2].Value.ToString();
                MascotaControl objMascotaControl = new MascotaControl();
                objMascotaControl.tipo = tipo;
                objMascotaControl.codigo = id;
                if (!dobleClik)
                { objNegMascota.listarTemporal(objMascotaControl); }
            }
            
        }

        private void FrmControlVacuna_Load(object sender, EventArgs e)
        {
            

        }
    }
}
