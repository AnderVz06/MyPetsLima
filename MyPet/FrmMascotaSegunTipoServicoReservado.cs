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
namespace MyPet
{
    public partial class FrmMascotaSegunTipoServicoReservado : Form
    {
        NegReserva objN = new NegReserva();
        public FrmMascotaSegunTipoServicoReservado()
        {
            InitializeComponent();
        }

        private void cbServicio_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today; GraficoMes1.Series.Clear();
            GraficoMes2.Visible = true;
            GraficoMes3.Visible = true;
            GraficoMes1.Visible = true;
            GraficoMes2.Series.Clear();
            GraficoMes3.Series.Clear();
            if (rbAte.Checked)
            {
               
                string mes1 = fecha.ToString("MMMM");
                GraficoMes1.DataSource = objN.ListarServicioSegunTipo("Ate",cbServicio.SelectedItem.ToString(),fecha);
                GraficoMes1.Series.Clear();
                GraficoMes1.Series.Add("Mes de " + mes1);
                GraficoMes1.Series["Mes de " + mes1].XValueMember = "TipoMascota";
                GraficoMes1.Series["Mes de " + mes1].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                GraficoMes1.Series["Mes de " + mes1].YValueMembers = "dinero";
                GraficoMes1.Series["Mes de " + mes1].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                GraficoMes1.DataBind();

                string mes2 = fecha.AddMonths(-1).ToString("MMMM");
                GraficoMes2.DataSource = objN.ListarServicioSegunTipo("Ate", cbServicio.SelectedItem.ToString(), fecha.AddMonths(-1));
                GraficoMes2.Series.Add("Mes de " + mes2);
                GraficoMes2.Series["Mes de " + mes2].XValueMember = "TipoMascota";
                GraficoMes2.Series["Mes de " + mes2].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                GraficoMes2.Series["Mes de " + mes2].YValueMembers = "dinero";
                GraficoMes2.Series["Mes de " + mes2].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                GraficoMes2.DataBind();

                string mes3 = fecha.AddMonths(-2).ToString("MMMM");
                GraficoMes3.Series.Add("Mes de " + mes3);
                GraficoMes3.DataSource = objN.ListarServicioSegunTipo("Ate", cbServicio.SelectedItem.ToString(), fecha.AddMonths(-2));
                GraficoMes3.Series["Mes de " + mes3].XValueMember = "TipoMascota";
                GraficoMes3.Series["Mes de " + mes3].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                GraficoMes3.Series["Mes de " + mes3].YValueMembers = "dinero";
                GraficoMes3.Series["Mes de " + mes3].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                GraficoMes3.DataBind();

               
            }

            if (rbMolina.Checked)
            {
                
                string mes1 = fecha.ToString("MMMM");
                GraficoMes1.DataSource = objN.ListarServicioSegunTipo("La Molina", cbServicio.SelectedItem.ToString(), fecha);
                GraficoMes1.Series.Clear();
                GraficoMes1.Series.Add("Mes de " + mes1);
                GraficoMes1.Series["Mes de " + mes1].XValueMember = "TipoMascota";
                GraficoMes1.Series["Mes de " + mes1].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                GraficoMes1.Series["Mes de " + mes1].YValueMembers = "dinero";
                GraficoMes1.Series["Mes de " + mes1].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                GraficoMes1.DataBind();

                string mes2 = fecha.AddMonths(-1).ToString("MMMM");
                GraficoMes2.DataSource = objN.ListarServicioSegunTipo("La Molina", cbServicio.SelectedItem.ToString(), fecha.AddMonths(-1));
                GraficoMes2.Series.Add("Mes de " + mes2);
                GraficoMes2.Series["Mes de " + mes2].XValueMember = "TipoMascota";
                GraficoMes2.Series["Mes de " + mes2].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                GraficoMes2.Series["Mes de " + mes2].YValueMembers = "dinero";
                GraficoMes2.Series["Mes de " + mes2].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                GraficoMes2.DataBind();

                string mes3 = fecha.AddMonths(-2).ToString("MMMM");
                GraficoMes3.DataSource = objN.ListarServicioSegunTipo("La Molina", cbServicio.SelectedItem.ToString(), fecha.AddMonths(-2));
                GraficoMes3.Series.Add("Mes de " + mes3);
                GraficoMes3.Series["Mes de " + mes3].XValueMember = "TipoMascota";
                GraficoMes3.Series["Mes de " + mes3].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                GraficoMes3.Series["Mes de " + mes3].YValueMembers = "dinero";
                GraficoMes3.Series["Mes de " + mes3].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                GraficoMes3.DataBind();

                
            }

        }

        private void cbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
