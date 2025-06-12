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
    public partial class FrmRegistrarCliente : Form
    {
        NegCliente objNegCliente = new NegCliente();
        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNombre.ForeColor = Color.Black;
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtApellido.ForeColor = Color.Black;
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            txtTelefono.Text = "";
            //txtTelefono.Font = new Font("Microsoft YaHei UI Light", 9);
            txtTelefono.ForeColor = Color.Black;
        }

        private void btmRegistrar_Click(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            objCliente.Nombre = txtNombre.Text;
            objCliente.Apellido = txtApellido.Text;
            objCliente.Telefono = txtTelefono.Text;
            objCliente.dni = txtDni.Text;

            if (txtNombre.Text != "" && txtApellido.Text != "" && txtTelefono.Text != "" && txtDni.Text != "")
            {
                if (!objNegCliente.ClienteExiste(txtDni.Text))
                {
                    objNegCliente.IngresarCliente(objCliente);
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtTelefono.Text = "";
                    txtDni.Text = "";
                    MensajeFlotante frm = new MensajeFlotante();
                    frm.label1.Text = " El cliente ha sido \n" + "registrado con exito";
                    frm.ShowDialog();

                }

                else
                {
                    MensajeError frm = new MensajeError();
                    frm.lbMensajeError.Text = "El DNI ya ha sido registrado";
                    frm.ShowDialog();
                    txtDni.Text = "";
                }
            }


            else
            {
                MensajeError frm = new MensajeError();
                frm.lbMensajeError.Text = "Faltan ingresar datos";
                frm.ShowDialog();
            }

        }
    }
}
