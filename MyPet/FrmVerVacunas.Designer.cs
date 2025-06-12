
namespace MyPet
{
    partial class FrmVerVacunas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombreMascota = new System.Windows.Forms.Label();
            this.dgVacunas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgVacunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Vacunas ";
            // 
            // lbNombreMascota
            // 
            this.lbNombreMascota.AutoSize = true;
            this.lbNombreMascota.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreMascota.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreMascota.Location = new System.Drawing.Point(132, 12);
            this.lbNombreMascota.Name = "lbNombreMascota";
            this.lbNombreMascota.Size = new System.Drawing.Size(0, 21);
            this.lbNombreMascota.TabIndex = 14;
            // 
            // dgVacunas
            // 
            this.dgVacunas.AllowUserToAddRows = false;
            this.dgVacunas.AllowUserToDeleteRows = false;
            this.dgVacunas.AllowUserToResizeColumns = false;
            this.dgVacunas.AllowUserToResizeRows = false;
            this.dgVacunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgVacunas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVacunas.Location = new System.Drawing.Point(90, 46);
            this.dgVacunas.MultiSelect = false;
            this.dgVacunas.Name = "dgVacunas";
            this.dgVacunas.ReadOnly = true;
            this.dgVacunas.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgVacunas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgVacunas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVacunas.Size = new System.Drawing.Size(457, 199);
            this.dgVacunas.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MyPet.Properties.Resources.vacunaAnimal;
            this.pictureBox1.Location = new System.Drawing.Point(529, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(1, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(641, 1);
            this.panel11.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 340);
            this.panel1.TabIndex = 26;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(1, 339);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(640, 1);
            this.panel12.TabIndex = 29;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(641, 1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 339);
            this.panel10.TabIndex = 28;
            // 
            // FrmVerVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(642, 340);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgVacunas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbNombreMascota);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerVacunas";
            this.Text = "FrmVerVacunas";
            this.Load += new System.EventHandler(this.FrmVerVacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVacunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNombreMascota;
        private System.Windows.Forms.DataGridView dgVacunas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel10;
    }
}