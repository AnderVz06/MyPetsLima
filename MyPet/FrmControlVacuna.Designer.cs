
namespace MyPet
{
    partial class FrmControlVacuna
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btmBuscar = new System.Windows.Forms.Button();
            this.dgMascota = new System.Windows.Forms.DataGridView();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingresar DNI del cliente";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.txtDni);
            this.panel9.Location = new System.Drawing.Point(257, 18);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(199, 32);
            this.panel9.TabIndex = 18;
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDni.Location = new System.Drawing.Point(13, 9);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(174, 16);
            this.txtDni.TabIndex = 3;
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
            this.btmBuscar.Location = new System.Drawing.Point(490, 20);
            this.btmBuscar.Name = "btmBuscar";
            this.btmBuscar.Size = new System.Drawing.Size(99, 30);
            this.btmBuscar.TabIndex = 22;
            this.btmBuscar.Text = "Buscar";
            this.btmBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmBuscar.UseVisualStyleBackColor = false;
            this.btmBuscar.Click += new System.EventHandler(this.btmBuscar_Click);
            // 
            // dgMascota
            // 
            this.dgMascota.AllowUserToAddRows = false;
            this.dgMascota.AllowUserToDeleteRows = false;
            this.dgMascota.AllowUserToOrderColumns = true;
            this.dgMascota.AllowUserToResizeColumns = false;
            this.dgMascota.AllowUserToResizeRows = false;
            this.dgMascota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMascota.Location = new System.Drawing.Point(50, 83);
            this.dgMascota.MultiSelect = false;
            this.dgMascota.Name = "dgMascota";
            this.dgMascota.ReadOnly = true;
            this.dgMascota.RowHeadersVisible = false;
            this.dgMascota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMascota.Size = new System.Drawing.Size(539, 223);
            this.dgMascota.TabIndex = 23;
            this.dgMascota.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMascota_CellClick);
            // 
            // FrmControlVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(642, 361);
            this.Controls.Add(this.dgMascota);
            this.Controls.Add(this.btmBuscar);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmControlVacuna";
            this.Text = "FrmControlVacuna";
            this.Load += new System.EventHandler(this.FrmControlVacuna_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btmBuscar;
        private System.Windows.Forms.DataGridView dgMascota;
        public System.Windows.Forms.TextBox txtDni;
    }
}