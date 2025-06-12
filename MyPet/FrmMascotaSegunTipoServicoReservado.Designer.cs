
namespace MyPet
{
    partial class FrmMascotaSegunTipoServicoReservado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbMolina = new System.Windows.Forms.RadioButton();
            this.rbAte = new System.Windows.Forms.RadioButton();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.GraficoMes1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GraficoMes2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GraficoMes3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoMes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoMes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoMes3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione local:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(284, 46);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(82, 26);
            this.panel8.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(7, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Servicio";
            // 
            // rbMolina
            // 
            this.rbMolina.AutoSize = true;
            this.rbMolina.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMolina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbMolina.Location = new System.Drawing.Point(494, 15);
            this.rbMolina.Name = "rbMolina";
            this.rbMolina.Size = new System.Drawing.Size(85, 23);
            this.rbMolina.TabIndex = 38;
            this.rbMolina.Text = "La Molina";
            this.rbMolina.UseVisualStyleBackColor = true;
            // 
            // rbAte
            // 
            this.rbAte.AutoSize = true;
            this.rbAte.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAte.Location = new System.Drawing.Point(385, 15);
            this.rbAte.Name = "rbAte";
            this.rbAte.Size = new System.Drawing.Size(46, 21);
            this.rbAte.TabIndex = 37;
            this.rbAte.Text = "Ate";
            this.rbAte.UseVisualStyleBackColor = true;
            // 
            // cbServicio
            // 
            this.cbServicio.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Items.AddRange(new object[] {
            "Baños/cortes",
            "Hospedaje",
            "Tratamientos"});
            this.cbServicio.Location = new System.Drawing.Point(394, 49);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(141, 25);
            this.cbServicio.TabIndex = 39;
            this.cbServicio.SelectedIndexChanged += new System.EventHandler(this.cbServicio_SelectedIndexChanged);
            this.cbServicio.SelectedValueChanged += new System.EventHandler(this.cbServicio_SelectedValueChanged);
            // 
            // GraficoMes1
            // 
            chartArea1.Name = "ChartArea1";
            this.GraficoMes1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.GraficoMes1.Legends.Add(legend1);
            this.GraficoMes1.Location = new System.Drawing.Point(12, 113);
            this.GraficoMes1.Name = "GraficoMes1";
            this.GraficoMes1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Mes1";
            this.GraficoMes1.Series.Add(series1);
            this.GraficoMes1.Size = new System.Drawing.Size(242, 218);
            this.GraficoMes1.TabIndex = 40;
            this.GraficoMes1.Text = "chart1";
            this.GraficoMes1.Visible = false;
            // 
            // GraficoMes2
            // 
            chartArea2.Name = "Mes2";
            this.GraficoMes2.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.GraficoMes2.Legends.Add(legend2);
            this.GraficoMes2.Location = new System.Drawing.Point(275, 113);
            this.GraficoMes2.Name = "GraficoMes2";
            this.GraficoMes2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "Mes2";
            series2.Legend = "Legend1";
            series2.Name = "Mes2";
            this.GraficoMes2.Series.Add(series2);
            this.GraficoMes2.Size = new System.Drawing.Size(247, 218);
            this.GraficoMes2.TabIndex = 41;
            this.GraficoMes2.Text = "chart2";
            this.GraficoMes2.Visible = false;
            // 
            // GraficoMes3
            // 
            chartArea3.Name = "Mes2";
            this.GraficoMes3.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.Name = "Legend1";
            this.GraficoMes3.Legends.Add(legend3);
            this.GraficoMes3.Location = new System.Drawing.Point(557, 113);
            this.GraficoMes3.Name = "GraficoMes3";
            this.GraficoMes3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "Mes2";
            series3.Legend = "Legend1";
            series3.Name = "Mes3";
            this.GraficoMes3.Series.Add(series3);
            this.GraficoMes3.Size = new System.Drawing.Size(247, 218);
            this.GraficoMes3.TabIndex = 42;
            this.GraficoMes3.Text = "chart2";
            this.GraficoMes3.Visible = false;
            // 
            // FrmMascotaSegunTipoServicoReservado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(816, 364);
            this.Controls.Add(this.GraficoMes3);
            this.Controls.Add(this.GraficoMes2);
            this.Controls.Add(this.GraficoMes1);
            this.Controls.Add(this.cbServicio);
            this.Controls.Add(this.rbMolina);
            this.Controls.Add(this.rbAte);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMascotaSegunTipoServicoReservado";
            this.Text = "FrmMascotaSegunTipoServicoReservado";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoMes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoMes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GraficoMes3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbMolina;
        private System.Windows.Forms.RadioButton rbAte;
        private System.Windows.Forms.ComboBox cbServicio;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoMes1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoMes2;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficoMes3;
    }
}