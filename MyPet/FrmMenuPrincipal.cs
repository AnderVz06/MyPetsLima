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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        NegMascota objNegMascota = new NegMascota();
        private void AbrirPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                panelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = formHijo;
            fh.Show();
            
        }
        
        private void btmRegistro_Click(object sender, EventArgs e)
        {
            panelContenedor.Height = 307;
            opcRegistro.Visible = true;
            opcReserva.Visible = false;
            opcReportes.Visible = false;
        }
        
        private void btmReserva_Click(object sender, EventArgs e)
        {
           
            panelContenedor.Height = 307;
            opcReserva.Visible = true;
            opcRegistro.Visible = false;
            opcReportes.Visible = false;
            //730; 450


        }


        //botones de direccion
        private void btmRegistrarCliente_Click(object sender, EventArgs e)
        {
            this.Size = new Size(730, 450);
            panelContenedor.Size = new Size(642, 307);
            panelContenedor.Height = 307;
            opcRegistro.Visible = false;
            opcReportes.Visible = false;
            btmVerVacunas.Visible = false;
            btmVacunar.Visible = false;
            AbrirPanel(new FrmRegistrarCliente());
            btmVolver.Visible = true;
            btmVolver.Location = new Point(580, 360);
        }
        private void btmRegistrarMascota_Click(object sender, EventArgs e)
        {
            this.Size = new Size(730, 450);
            panelContenedor.Size = new Size(642, 307);
            this.Size = new Size(730, 450);
            panelContenedor.Size = new Size(642, 307); 
            panelContenedor.Height = 307;
            btmVerVacunas.Visible = false;
            btmVacunar.Visible = false;
            opcRegistro.Visible = false;
            opcReportes.Visible = false;
            btmVolver.Visible = false;
            AbrirPanel(new FrmRegistrarMascota());
        }
        private void btmReservar_Click(object sender, EventArgs e)
        {
            
            this.Size = new Size(730, 450);
            panelContenedor.Size = new Size(642, 307); 
            panelContenedor.Height = 307;
            btmVerVacunas.Visible = false;
            btmVacunar.Visible = false;
            opcReserva.Visible = false;
            opcReportes.Visible = false;
            AbrirPanel(new FrmReservar());
            btmRegistro.Enabled = false;
            btmReserva.Enabled = false;
            btmVacuna.Enabled = false;
            btnReportes.Enabled = false;
            btmVolver.Visible = true;
            btmVolver.Location=new Point(580, 360);
        }
        private void btmVerReserva_Click(object sender, EventArgs e)
        {
            btmVolver.Visible = false;
            this.Size = new Size(730, 450);
            panelContenedor.Size = new Size(642, 307); 
            panelContenedor.Height = 307;
            btmVerVacunas.Visible = false;
            btmVacunar.Visible = false;
            opcReserva.Visible = false;
            opcReportes.Visible = false;
            AbrirPanel(new FrmVerReserva());
        }

        private void btmVacuna_Click(object sender, EventArgs e)
        {
            this.Size = new Size(730, 450);
            panelContenedor.Size = new Size(642, 307);
            panelContenedor.Height = 285;
            opcRegistro.Visible = false;
            opcReserva.Visible = false;
            opcReportes.Visible = false;
            AbrirPanel(new FrmControlVacuna());
            btmVacunar.Visible = true;
            btmVerVacunas.Visible = true;
            btmVerVacunas.Location = new Point(219, 354);
            btmVacunar.Location = new Point(423, 354);
            btmVolver.Visible = false;

        }

        private void btmVerVacunas_Click(object sender, EventArgs e)
        {
           
            MascotaControl objMascotaControl = objNegMascota.ListarControlMascota();
            if (objNegMascota.ListaExiste())

            {
                panelContenedor.Height = 307;
                btmVerVacunas.Visible = false;
                btmVacunar.Visible = false;
                AbrirPanel(new FrmVerVacunas());
                btvolver2.Visible = true;
                btvolver2.Location = new Point(580, 360);
                btmRegistro.Enabled = false;
                btmReserva.Enabled = false;
                btmVacuna.Enabled = false;
                btnReportes.Enabled = false;
            }
            else
            {

                MensajeError frm = new MensajeError();
                frm.lbMensajeError.Text = " No siguió los pasos\n" + " correctamente";
                frm.ShowDialog();
                AbrirPanel(new FrmMenu());
                btmVacunar.Visible = false;
                btmVerVacunas.Visible = false;
                btmVolver.Visible=false;
            }

            
        }

        private void btmVacunar_Click(object sender, EventArgs e)
        {
            if (objNegMascota.ListaExiste())
            {
                panelContenedor.Height = 307;
                btmVerVacunas.Visible = false;
                btmVacunar.Visible = false;
                AbrirPanel(new FrmVacunar());
                btmRegistro.Enabled = false;
                btmReserva.Enabled = false;
                btmVacuna.Enabled = false;
                btnReportes.Enabled = false;
                btvolver2.Visible = true;
                btvolver2.Location = new Point(580, 360);
            }
            else
            {
                MensajeError frm = new MensajeError();
                frm.ShowDialog();
                btmVerVacunas.Visible = false;
                btmVacunar.Visible = false;
                AbrirPanel(new FrmMenu());
            }
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
            panelContenedor.Height = 307;
            AbrirPanel(new FrmMenu());
            btvolver2.Visible = false;
        }

        private void MenuPage_Click(object sender, EventArgs e)
        {
            this.Size = new Size(730, 450);
            panelContenedor.Size = new Size(642, 307);
            btmVolver.Visible = false; 
            btmVerVacunas.Visible = false;
            btmVacunar.Visible = false;
            btvolver2.Visible = false;
            panelContenedor.Height = 307;
            AbrirPanel(new FrmMenu());
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (Form1.EmpleadoRol == "Gerente")
            {
                opcReportes.Visible = true;
            }
            opcRegistro.Visible = false;
            opcReserva.Visible = false;
            btmVolver.Visible = false;
        }

        private void btmVolver_Click(object sender, EventArgs e)
        {
            btmRegistro.Enabled = true;
            btmReserva.Enabled = true;
            btmVacuna.Enabled = true;
            btnReportes.Enabled = true;
            AbrirPanel(new FrmMenu());
            btmVolver.Visible = false;
        }

        private void btvolver2_Click(object sender, EventArgs e)
        {
            objNegMascota.BorrarListaTemporal();
            AbrirPanel(new FrmMenu());
            btmRegistro.Enabled = true;
            btmReserva.Enabled = true;
            btmVacuna.Enabled = true;
            btnReportes.Enabled = true;
            btvolver2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btmVerVacunas.Visible = false;
            btmVacunar.Visible = false;

            this.Size = new Size(730, 450);
            panelContenedor.Size = new Size(642, 307);
            AbrirPanel(new FrmMascotasSegunTipoLocal());
            opcRegistro.Visible = false;
            opcReserva.Visible = false;
            opcReportes.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btmVerVacunas.Visible = false;
            btmVacunar.Visible = false;
            this.Size = new Size(730, 450);
            panelContenedor.Size = new Size(642, 307);
            opcRegistro.Visible = false;
            opcReserva.Visible = false;
            opcReportes.Visible = false;
            AbrirPanel(new FrmRecordatorioVacunas());
        }

        private void btmSegunServicio_Click(object sender, EventArgs e)
        {
            btmVerVacunas.Visible = false;
            btmVacunar.Visible = false;
            AbrirPanel(new FrmMascotaSegunTipoServicoReservado());
            opcRegistro.Visible = false;
            opcReserva.Visible = false;
            opcReportes.Visible = false;
            this.Size = new Size(905 , 450);
            panelContenedor.Size = new Size(816, 307);
        }

        private void btmPorcentajeVacunas_Click(object sender, EventArgs e)
        {
            btmVerVacunas.Visible = false;
            btmVacunar.Visible = false;
            this.Size = new Size(730, 450);
            panelContenedor.Size = new Size(642, 307);
            AbrirPanel(new FrmCantidadVacunasPorTipo());
            opcRegistro.Visible = false;
            opcReserva.Visible = false;
            opcReportes.Visible = false;
        }

        private void btmCantidadDiasReserva_Click(object sender, EventArgs e)
        {
            btmVerVacunas.Visible = false;
            btmVacunar.Visible = false;
            this.Size = new Size(905, 450);
            panelContenedor.Size = new Size(816, 307);
            AbrirPanel(new FrmReservasCadaDia());
            opcRegistro.Visible = false;
            opcReserva.Visible = false;
            opcReportes.Visible = false;

        }
    }
}
