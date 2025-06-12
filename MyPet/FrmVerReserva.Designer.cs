
namespace MyPet
{
    partial class FrmVerReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btmBuscar = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgReserva = new System.Windows.Forms.DataGridView();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ingresar DNI del cliente";
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDni.Location = new System.Drawing.Point(3, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(174, 16);
            this.txtDni.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.txtDni);
            this.panel9.Location = new System.Drawing.Point(252, 45);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(199, 32);
            this.panel9.TabIndex = 25;
            // 
            // btmBuscar
            // 
            this.btmBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btmBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(48)))), ((int)(((byte)(116)))));
            this.btmBuscar.FlatAppearance.BorderSize = 0;
            this.btmBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmBuscar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmBuscar.ForeColor = System.Drawing.Color.White;
            this.btmBuscar.Image = global::MyPet.Properties.Resources.search;
            this.btmBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmBuscar.Location = new System.Drawing.Point(471, 45);
            this.btmBuscar.Name = "btmBuscar";
            this.btmBuscar.Size = new System.Drawing.Size(99, 30);
            this.btmBuscar.TabIndex = 26;
            this.btmBuscar.Text = "Buscar";
            this.btmBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmBuscar.UseVisualStyleBackColor = false;
            this.btmBuscar.Click += new System.EventHandler(this.btmBuscar_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(1, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(641, 1);
            this.panel11.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 348);
            this.panel1.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(641, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 347);
            this.panel6.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(1, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 1);
            this.panel2.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Lista de reservas";
            // 
            // dgReserva
            // 
            this.dgReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReserva.Location = new System.Drawing.Point(48, 97);
            this.dgReserva.Name = "dgReserva";
            this.dgReserva.Size = new System.Drawing.Size(540, 224);
            this.dgReserva.TabIndex = 43;
            // 
            // FrmVerReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(642, 348);
            this.Controls.Add(this.dgReserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmBuscar);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerReserva";
            this.Text = "FrmVerReserva";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btmBuscar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgReserva;
    }
}