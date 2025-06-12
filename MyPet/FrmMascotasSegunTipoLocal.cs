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
    public partial class FrmMascotasSegunTipoLocal : Form
    {
        NegMascota objNegMascota = new NegMascota();
        public FrmMascotasSegunTipoLocal()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            ChartYear1.Visible = true;
            ChartYear2.Visible = true;
            lbAforo.Text = " Aforo máximo: 55 mascotas";
            ChartYear1.Series.Clear();
            ChartYear2.Series.Clear();
            ChartYear1.Series.Clear();
                ChartYear1.Series.Add("Año "+fecha.AddYears(-1).Year);
                ChartYear1.DataSource = objNegMascota.Lista_Cantidad_Tipo("Ate", fecha.AddYears(-1));
                ChartYear1.Series["Año " + fecha.AddYears(-1).Year].XValueMember = "tipoMascota";
                ChartYear1.Series["Año " + fecha.AddYears(-1).Year].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                ChartYear1.Series["Año " + fecha.AddYears(-1).Year].YValueMembers = "cantidad_tipo";
                ChartYear1.Series["Año " + fecha.AddYears(-1).Year].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                
                ChartYear1.DataBind();

                ChartYear2.Series.Clear();
                ChartYear2.Series.Add("Año " + fecha.Year);
                ChartYear2.DataSource = objNegMascota.Lista_Cantidad_Tipo("Ate", fecha);
                ChartYear2.Series["Año " + fecha.Year].XValueMember = "tipoMascota";
                ChartYear2.Series["Año " + fecha.Year].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                ChartYear2.Series["Año " + fecha.Year].YValueMembers = "cantidad_tipo";
                ChartYear2.Series["Año " + fecha.Year].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                ChartYear2.DataBind();

                
            

           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbMolina_CheckedChanged(object sender, EventArgs e)
        {
            lbAforo.Text = " Aforo máximo: 40 mascotas";
            DateTime fecha = DateTime.Now;
            ChartYear1.Visible = true;
            ChartYear2.Visible = true;

            ChartYear1.Series.Clear();
            ChartYear2.Series.Clear();
            ChartYear1.Series.Clear();
            ChartYear1.Series.Add("Año " + fecha.AddYears(-1).Year);
            ChartYear1.DataSource = objNegMascota.Lista_Cantidad_Tipo("La Molina", fecha.AddYears(-1));
            ChartYear1.Series["Año " + fecha.AddYears(-1).Year].XValueMember = "tipoMascota";
            ChartYear1.Series["Año " + fecha.AddYears(-1).Year].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            ChartYear1.Series["Año " + fecha.AddYears(-1).Year].YValueMembers = "cantidad_tipo";
            ChartYear1.Series["Año " + fecha.AddYears(-1).Year].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            ChartYear1.DataBind();

            ChartYear2.Series.Add("Año " + fecha.Year);
            ChartYear2.DataSource = objNegMascota.Lista_Cantidad_Tipo("La Molina", fecha);
            ChartYear2.Series["Año " + fecha.Year].XValueMember = "tipoMascota";
            ChartYear2.Series["Año " + fecha.Year].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            ChartYear2.Series["Año " + fecha.Year].YValueMembers = "cantidad_tipo";
            ChartYear2.Series["Año " + fecha.Year].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            ChartYear2.DataBind();
        }
    }
}
