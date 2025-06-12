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
    public partial class FrmReservar : Form
    {
        public FrmReservar()
        {
            InitializeComponent();
        }
        NegCliente objNegCliente = new NegCliente();
        NegMascota objNegMascota = new NegMascota();
        NegReserva objNegReserva = new NegReserva();
        private void btmReservar_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = dtFechaReserva.Value;
            string dia = dt.AddDays(0).ToString("dddd");
                Mascota objMascota = (Mascota)cbMascota.SelectedItem;
            Reserva objReserva = new Reserva();
           objReserva.Fecha = dtFechaReserva.Value;
            objReserva.Hora = cbHora.SelectedItem.ToString();
            objReserva.CodMascota = objMascota.Codigo;
            objReserva.DiaSemana = dia;
            
            
            if (rbAte.Checked)
            {
                objReserva.Local = rbAte.Text;
            }
            if (rbMolina.Checked)
            {
                objReserva.Local = rbMolina.Text;
            }
            objReserva.Servicio = cbServicio.SelectedItem.ToString();
            objReserva.CodCliente = txtDNI.Text;
            objReserva.precio = objNegReserva.PonerPrecioServicio(objMascota.Tipo, objReserva.Servicio);
            objReserva.Mascota = objMascota.Nombre;

            if (objNegReserva.ReservaExiste(Convert.ToDateTime(objReserva.Fecha), objReserva.Hora, objReserva.Local))
            {
                MensajeError frm = new MensajeError();
                frm.lbMensajeError.Text = "La fecha de reserva esta \n"+" \t ocupada";
                frm.ShowDialog();
                Notificacion.Visible = false;
                cbHora.SelectedItem = null;
            }
            else
            {
                objNegReserva.IngresarReserva(objReserva);

                Notificacion.Visible = true;
            }
       
        }

        private void btmBuscar_Click(object sender, EventArgs e)
        {
            
            cbMascota.DataSource = objNegMascota.ListarMascotaDeUnCliente(txtDNI.Text);
            cbMascota.DisplayMember = "Nombre";
            cbMascota.Enabled = true;
            cbServicio.Enabled = true;
            cbHora.Enabled = true;
            rbAte.Enabled = true;
            rbMolina.Enabled = true;
            btmReservar.Enabled = true;
            dtFechaReserva.Enabled = true;
            
        }
    }
}
