using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaDatos;
namespace MyPet
{
    public partial class FrmVacunar : Form
    {
        NegVacuna objNegVacuna = new NegVacuna();
        NegMascota objNegMascota = new NegMascota();
        public FrmVacunar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Vacuna objPreuba = (Vacuna)cbTipoVacuna.SelectedItem;
            Vacuna objVacuna = new Vacuna();
            objVacuna.Nombre = objPreuba.Nombre;
            objVacuna.Cantidad = Convert.ToInt32(txtCantidad.Text);
            objVacuna.CodMascota = objNegMascota.ListarControlMascota().codigo;
            int cod = Convert.ToInt32(objVacuna.CodMascota);
            objVacuna.Fecha = dtFecha.Value;
            objVacuna.Tipo = objNegMascota.ListarControlMascota().tipo;
            
            if (objNegVacuna.ExisteVacuna(cod, objVacuna.Nombre))
            {
                MensajeError frm = new MensajeError();
                frm.lbMensajeError.Text = "      Vacuna ya registrada";
                frm.ShowDialog();
            }
            else
            {
                
                
                objNegVacuna.IngresarVacuna(objVacuna);
                int codigo = Convert.ToInt32(objVacuna.CodMascota);
                objNegMascota.ModificarFechaMascota(codigo,objVacuna.Fecha.Value);
                lbMensaje.Text= "Su proxima vacuna \n" + "  programada es:\n\n"+ objVacuna.Fecha.Value.AddMonths(3);
                Notificacion.Visible = true;
                




            }
            
           
            
        }

        private void FrmVacunar_Load(object sender, EventArgs e)
        {
            
            cbTipoVacuna.DataSource = objNegVacuna.ListaVacunaControl(objNegMascota.ListarControlMascota());
            cbTipoVacuna.DisplayMember = "Nombre";
            

        }
    }
}
