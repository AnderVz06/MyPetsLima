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
    public partial class FrmVerReserva : Form
    {
        public FrmVerReserva()
        {
            InitializeComponent();
        }
        NegReserva objNegReserva = new NegReserva();

        private void btmBuscar_Click(object sender, EventArgs e)
        {
            dgReserva.DataSource = objNegReserva.ActualizarReserva(txtDni.Text);
            dgReserva.Columns["CodReserva"].Visible = false;
            dgReserva.Columns["CodCliente"].Visible = false;
        }
    }
}
