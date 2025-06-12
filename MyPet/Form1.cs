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
    public partial class Form1 : Form
    {
        NegEmpleado objNegEmpleado = new NegEmpleado();
        public static string EmpleadoLogin;
        public static string EmpleadoRol;
        public Form1()
        {
            InitializeComponent();
        }


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
       
        private void btAcceder_Click(object sender, EventArgs e)
        {
            Empleado objEmpleado = new Empleado();
            objEmpleado.usuario = txtCorreo.Text.Trim();
            objEmpleado.contraseña = txtContraseña.Text.Trim();
            var resultado = objNegEmpleado.login(objEmpleado);
            if (txtContraseña.Text == "")
            {
                //passwordTB2.BorderColor = Color.Red;
                lbCont.Text = "Ingrese su contraseña";
                error2.Visible = true;
            }

            if (txtCorreo.Text == "")
            {
                //passwordTB1.BorderColor = Color.Red;
                lbCorreo.Text = "Ingrese su usuario";
                txtCorreo.Text = String.Empty;
                error1.Visible = true;
            }
            if (resultado==null)
            {
                lbCorreo.Text = "Usuario incorrecto";
                txtCorreo.Text = String.Empty;
                error1.Visible = true;
                txtContraseña.Text = String.Empty;
            }
            else
            {
                EmpleadoLogin = resultado.usuario;
                EmpleadoRol = resultado.rol;
                FrmMenuPrincipal frm = new FrmMenuPrincipal();
                this.Hide();
                frm.ShowDialog();
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox5.BringToFront();
            txtContraseña.Font = new Font("Arial Rounded MT Bold", 9, FontStyle.Regular);

            txtContraseña.PasswordChar = '\0';
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
            pictureBox3.BringToFront();
            txtContraseña.Font = new Font("MS Reference Sans Serif", 10, FontStyle.Bold);
            txtContraseña.PasswordChar = '•';
        }

        private void error1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
