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
    public partial class FrmReservasCadaDia : Form
    {
        NegReserva objNegReserva = new NegReserva();
        public FrmReservasCadaDia()
        {
            InitializeComponent();
        }

        private void rbAte_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAte_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            chartMes1.Visible = true;
            chartMes2.Visible = true;
            chartMes3.Visible = true;

            chartMes1.Series.Clear();
            chartMes2.Series.Clear();
            chartMes3.Series.Clear();

            chartMes1.Titles.Clear();
            chartMes2.Titles.Clear();
            chartMes3.Titles.Clear();

            string mes1 = fecha.AddMonths(-2).ToString("MMMM");

            chartMes1.Series.Add("Mes" + fecha.AddMonths(-2).Month);

            chartMes1.Series["Mes" + fecha.AddMonths(-2).Month].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chartMes1.Titles.Add("Mes de " + mes1);

            chartMes1.Series["Mes" + fecha.AddMonths(-2).Month].IsValueShownAsLabel = true;

            chartMes1.DataSource = objNegReserva.ListarServicio_PorDia("Ate", fecha.AddMonths(-2));
            chartMes1.Series["Mes" + fecha.AddMonths(-2).Month].XValueMember = "dia_semana";
            chartMes1.Series["Mes" + fecha.AddMonths(-2).Month].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartMes1.Series["Mes" + fecha.AddMonths(-2).Month].YValueMembers = "Cantidad_Servicio";
            chartMes1.Series["Mes" + fecha.AddMonths(-2).Month].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
           
            //////////////////////////////////////////////////////////////////////////////////////

            string mes2 = fecha.AddMonths(-1).ToString("MMMM");

            chartMes2.Series.Add("Mes" + fecha.AddMonths(-1).Month);

            chartMes2.Series["Mes" + fecha.AddMonths(-1).Month].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chartMes2.Titles.Add("Mes de " + mes2);

            chartMes2.Series["Mes" + fecha.AddMonths(-1).Month].IsValueShownAsLabel = true;

            chartMes2.DataSource = objNegReserva.ListarServicio_PorDia("Ate", fecha.AddMonths(-1));
            chartMes2.Series["Mes" + fecha.AddMonths(-1).Month].XValueMember = "dia_semana";
            chartMes2.Series["Mes" + fecha.AddMonths(-1).Month].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartMes2.Series["Mes" + fecha.AddMonths(-1).Month].YValueMembers = "Cantidad_Servicio";
            chartMes2.Series["Mes" + fecha.AddMonths(-1).Month].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

            //////////////////////////////////////////////////////////////////////////////////////

            string mes3 = fecha.AddMonths(0).ToString("MMMM");

            chartMes3.Series.Add("Mes" + fecha.AddMonths(0).Month);

            chartMes3.Series["Mes" + fecha.AddMonths(0).Month].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chartMes3.Titles.Add("Mes de " + mes3);

            chartMes3.Series["Mes" + fecha.AddMonths(0).Month].IsValueShownAsLabel = true;

            chartMes3.DataSource = objNegReserva.ListarServicio_PorDia("Ate", fecha.AddMonths(0));
            chartMes3.Series["Mes" + fecha.AddMonths(0).Month].XValueMember = "dia_semana";
            chartMes3.Series["Mes" + fecha.AddMonths(0).Month].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartMes3.Series["Mes" + fecha.AddMonths(0).Month].YValueMembers = "Cantidad_Servicio";
            chartMes3.Series["Mes" + fecha.AddMonths(0).Month].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

        }

        private void rbMolina_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            chartMes1.Visible = true;
            chartMes2.Visible = true;
            chartMes3.Visible = true;

            chartMes1.Series.Clear();
            chartMes2.Series.Clear();
            chartMes3.Series.Clear();

            chartMes1.Titles.Clear();
            chartMes2.Titles.Clear();
            chartMes3.Titles.Clear();

            string mes1 = fecha.AddMonths(-2).ToString("MMMM");

            chartMes1.Series.Add("Mes" + fecha.AddMonths(-2).Month);

            chartMes1.Series["Mes" + fecha.AddMonths(-2).Month].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chartMes1.Titles.Add("Mes de " + mes1);

            chartMes1.Series["Mes" + fecha.AddMonths(-2).Month].IsValueShownAsLabel = true;

            chartMes1.DataSource = objNegReserva.ListarServicio_PorDia("La Molina", fecha.AddMonths(-2));
            chartMes1.Series["Mes" + fecha.AddMonths(-2).Month].XValueMember = "dia_semana";
            chartMes1.Series["Mes" + fecha.AddMonths(-2).Month].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartMes1.Series["Mes" + fecha.AddMonths(-2).Month].YValueMembers = "Cantidad_Servicio";
            chartMes1.Series["Mes" + fecha.AddMonths(-2).Month].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;





            string mes2 = fecha.AddMonths(-1).ToString("MMMM");

            chartMes2.Series.Add("Mes" + fecha.AddMonths(-1).Month);

            chartMes2.Series["Mes" + fecha.AddMonths(-1).Month].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chartMes2.Titles.Add("Mes de " + mes2);

            chartMes2.Series["Mes" + fecha.AddMonths(-1).Month].IsValueShownAsLabel = true;

            chartMes2.DataSource = objNegReserva.ListarServicio_PorDia("La Molina", fecha.AddMonths(-1));
            chartMes2.Series["Mes" + fecha.AddMonths(-1).Month].XValueMember = "dia_semana";
            chartMes2.Series["Mes" + fecha.AddMonths(-1).Month].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartMes2.Series["Mes" + fecha.AddMonths(-1).Month].YValueMembers = "Cantidad_Servicio";
            chartMes2.Series["Mes" + fecha.AddMonths(-1).Month].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;





            string mes3 = fecha.AddMonths(0).ToString("MMMM");

            chartMes3.Series.Add("Mes" + fecha.AddMonths(0).Month);

            chartMes3.Series["Mes" + fecha.AddMonths(0).Month].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chartMes3.Titles.Add("Mes de " + mes3);

            chartMes3.Series["Mes" + fecha.AddMonths(0).Month].IsValueShownAsLabel = true;

            chartMes3.DataSource = objNegReserva.ListarServicio_PorDia("La Molina", fecha.AddMonths(0));
            chartMes3.Series["Mes" + fecha.AddMonths(0).Month].XValueMember = "dia_semana";
            chartMes3.Series["Mes" + fecha.AddMonths(0).Month].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartMes3.Series["Mes" + fecha.AddMonths(0).Month].YValueMembers = "Cantidad_Servicio";
            chartMes3.Series["Mes" + fecha.AddMonths(0).Month].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;

        }
    }
}
