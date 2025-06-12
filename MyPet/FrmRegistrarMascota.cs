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
    
    public partial class FrmRegistrarMascota : Form
    {
        NegCliente objNegCliente = new NegCliente();
        NegMascota objNegMascota = new NegMascota();
        NegLocal objNegLocal = new NegLocal();
        public FrmRegistrarMascota()
        {
            InitializeComponent();
        }
        public void ActualizarCliente()
        {
            dgCliente.DataSource = objNegCliente.ActualizarCliente();
            dgCliente.Columns["dni"].Visible = false;
            dgCliente.Columns["Telefono"].Visible = false;
        }

        private void FrmRegistrarMascota_Load(object sender, EventArgs e)
        {
            ActualizarCliente();
            btmRegistrar.Enabled = false;
        }

        private void txtBuscardueño_TextChanged(object sender, EventArgs e)
        {
            string Nombre = txtBuscardueño.Text;
            dgCliente.DataSource = objNegCliente.BuscarCliente(Nombre);
        }

        private void btmRegistrar_Click(object sender, EventArgs e)
        {
            
            
            Local objLocal = new Local();
            Mascota objMascota = new Mascota();
            if (rbAte.Checked)
            {
                objMascota.Local = rbAte.Text;
                objLocal.local1 = rbAte.Text;
            }
            if (rbMolina.Checked)
            {
                objMascota.Local = rbMolina.Text;
                objLocal.local1 = rbAte.Text;
            }

            objMascota.CodigoCliente = Convert.ToString(dgCliente.SelectedRows[0].Cells[0].Value);
            if (txtNombre.Text != "" )
            {
                
                objMascota.Nombre = txtNombre.Text;
                objMascota.Tipo = cbTipo.SelectedItem.ToString();
                objMascota.FechaRegistro = DateTime.Now;
                objNegMascota.IngresarMascota(objMascota);
                objLocal.codigoMascota = objMascota.Codigo;
                objNegLocal.IngresarMascota(objLocal);
                MensajeFlotante frm = new MensajeFlotante();
                frm.label1.Text = " La mascota ha sido\n" + "registrada correctamente";
                frm.ShowDialog();
            }
            else
            { MensajeError frm = new MensajeError();
                frm.lbMensajeError.Text = "    Faltan ingresar " + "datos";
                frm.ShowDialog();
            }
        
        }

        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btmRegistrar.Enabled = true;
        }
    }
}
