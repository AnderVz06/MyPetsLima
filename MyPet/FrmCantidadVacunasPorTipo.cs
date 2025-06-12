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
    public partial class FrmCantidadVacunasPorTipo : Form
    {
        NegVacuna objN = new NegVacuna();
        public FrmCantidadVacunasPorTipo()
        {
            InitializeComponent();
        }

        private void cbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
           
            chart1.DataSource = objN.VacunasSegunTipoMascota(cbTipo.SelectedItem.ToString());
            chart1.Series["Vacunas"].XValueMember = "nombreVacuna";
            chart1.Series["Vacunas"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chart1.Series["Vacunas"].YValueMembers = "cant_vacuna";
            chart1.Series["Vacunas"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            chart1.Series["Vacunas"].IsValueShownAsLabel = true;
          
            chart1.DataBind();
            chart1.Visible = true;
        }
    }
}
