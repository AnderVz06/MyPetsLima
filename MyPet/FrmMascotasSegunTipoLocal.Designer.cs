
namespace MyPet
{
    partial class FrmMascotasSegunTipoLocal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbMolina = new System.Windows.Forms.RadioButton();
            this.rbAte = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ChartYear2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartYear1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbAforo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartYear2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartYear1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbAforo);
            this.panel1.Controls.Add(this.rbMolina);
            this.panel1.Controls.Add(this.rbAte);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ChartYear2);
            this.panel1.Controls.Add(this.ChartYear1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 364);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rbMolina
            // 
            this.rbMolina.AutoSize = true;
            this.rbMolina.Location = new System.Drawing.Point(401, 17);
            this.rbMolina.Name = "rbMolina";
            this.rbMolina.Size = new System.Drawing.Size(71, 17);
            this.rbMolina.TabIndex = 4;
            this.rbMolina.TabStop = true;
            this.rbMolina.Text = "La Molina";
            this.rbMolina.UseVisualStyleBackColor = true;
            this.rbMolina.CheckedChanged += new System.EventHandler(this.rbMolina_CheckedChanged);
            // 
            // rbAte
            // 
            this.rbAte.AutoSize = true;
            this.rbAte.Location = new System.Drawing.Point(306, 17);
            this.rbAte.Name = "rbAte";
            this.rbAte.Size = new System.Drawing.Size(41, 17);
            this.rbAte.TabIndex = 3;
            this.rbAte.TabStop = true;
            this.rbAte.Text = "Ate";
            this.rbAte.UseVisualStyleBackColor = true;
            this.rbAte.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el local:";
            // 
            // ChartYear2
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartYear2.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.ChartYear2.Legends.Add(legend1);
            this.ChartYear2.Location = new System.Drawing.Point(335, 75);
            this.ChartYear2.Name = "ChartYear2";
            this.ChartYear2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.ChartYear2.Size = new System.Drawing.Size(283, 277);
            this.ChartYear2.TabIndex = 1;
            this.ChartYear2.Text = "chart2";
            this.ChartYear2.Visible = false;
            // 
            // ChartYear1
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartYear1.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.ChartYear1.Legends.Add(legend2);
            this.ChartYear1.Location = new System.Drawing.Point(12, 75);
            this.ChartYear1.Name = "ChartYear1";
            this.ChartYear1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.ChartYear1.Size = new System.Drawing.Size(274, 277);
            this.ChartYear1.TabIndex = 0;
            this.ChartYear1.Text = "Char2021";
            this.ChartYear1.Visible = false;
            // 
            // lbAforo
            // 
            this.lbAforo.AutoSize = true;
            this.lbAforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAforo.Location = new System.Drawing.Point(12, 42);
            this.lbAforo.Name = "lbAforo";
            this.lbAforo.Size = new System.Drawing.Size(0, 15);
            this.lbAforo.TabIndex = 5;
            // 
            // FrmMascotasSegunTipoLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(642, 364);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMascotasSegunTipoLocal";
            this.Text = "FrmMascotasSegunTipoLocal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartYear2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartYear1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartYear1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartYear2;
        private System.Windows.Forms.RadioButton rbMolina;
        private System.Windows.Forms.RadioButton rbAte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAforo;
    }
}