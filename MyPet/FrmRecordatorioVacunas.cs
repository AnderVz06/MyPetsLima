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
    public partial class FrmRecordatorioVacunas : Form
    {
        NegCliente objNeg = new NegCliente();
        public FrmRecordatorioVacunas()
        {
            InitializeComponent();
        }

        private void FrmRecordatorioVacunas_Load(object sender, EventArgs e)
        {
            dgClientes.DataSource = objNeg.RecordatorioCliente();
            dgClientes.Columns["dni"].Visible = false;
        }
    }
}
