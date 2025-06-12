
namespace MyPet
{
    partial class FrmRegistrarMascota
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.btmRegistrar = new System.Windows.Forms.Button();
            this.txtBuscardueño = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.rbMolina = new System.Windows.Forms.RadioButton();
            this.rbAte = new System.Windows.Forms.RadioButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registro de mascota";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(37, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 32);
            this.panel3.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(37, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 32);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtNombre.Location = new System.Drawing.Point(6, 8);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 16);
            this.txtNombre.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.txtNombre);
            this.panel6.Location = new System.Drawing.Point(152, 96);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(161, 32);
            this.panel6.TabIndex = 20;
            // 
            // cbTipo
            // 
            this.cbTipo.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Conejo"});
            this.cbTipo.Location = new System.Drawing.Point(152, 155);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(161, 25);
            this.cbTipo.TabIndex = 21;
            // 
            // btmRegistrar
            // 
            this.btmRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(48)))), ((int)(((byte)(116)))));
            this.btmRegistrar.Enabled = false;
            this.btmRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(48)))), ((int)(((byte)(116)))));
            this.btmRegistrar.FlatAppearance.BorderSize = 0;
            this.btmRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmRegistrar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmRegistrar.ForeColor = System.Drawing.Color.White;
            this.btmRegistrar.Location = new System.Drawing.Point(125, 253);
            this.btmRegistrar.Name = "btmRegistrar";
            this.btmRegistrar.Size = new System.Drawing.Size(90, 41);
            this.btmRegistrar.TabIndex = 23;
            this.btmRegistrar.Text = "Registrar";
            this.btmRegistrar.UseVisualStyleBackColor = false;
            this.btmRegistrar.Click += new System.EventHandler(this.btmRegistrar_Click);
            // 
            // txtBuscardueño
            // 
            this.txtBuscardueño.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscardueño.Location = new System.Drawing.Point(402, 17);
            this.txtBuscardueño.Name = "txtBuscardueño";
            this.txtBuscardueño.Size = new System.Drawing.Size(178, 23);
            this.txtBuscardueño.TabIndex = 24;
            this.txtBuscardueño.TextChanged += new System.EventHandler(this.txtBuscardueño_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 364);
            this.panel1.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(641, 1);
            this.panel4.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(641, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 363);
            this.panel5.TabIndex = 30;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(1, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(640, 1);
            this.panel7.TabIndex = 31;
            // 
            // dgCliente
            // 
            this.dgCliente.AllowUserToAddRows = false;
            this.dgCliente.AllowUserToDeleteRows = false;
            this.dgCliente.AllowUserToOrderColumns = true;
            this.dgCliente.AllowUserToResizeColumns = false;
            this.dgCliente.AllowUserToResizeRows = false;
            this.dgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Location = new System.Drawing.Point(378, 55);
            this.dgCliente.MultiSelect = false;
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.ReadOnly = true;
            this.dgCliente.RowHeadersVisible = false;
            this.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCliente.Size = new System.Drawing.Size(240, 297);
            this.dgCliente.TabIndex = 32;
            this.dgCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellClick);
            // 
            // rbMolina
            // 
            this.rbMolina.AutoSize = true;
            this.rbMolina.Font = new System.Drawing.Font("Microsoft YaHei Light", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMolina.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbMolina.Location = new System.Drawing.Point(267, 210);
            this.rbMolina.Name = "rbMolina";
            this.rbMolina.Size = new System.Drawing.Size(85, 23);
            this.rbMolina.TabIndex = 36;
            this.rbMolina.Text = "La Molina";
            this.rbMolina.UseVisualStyleBackColor = true;
            // 
            // rbAte
            // 
            this.rbAte.AutoSize = true;
            this.rbAte.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAte.Location = new System.Drawing.Point(158, 212);
            this.rbAte.Name = "rbAte";
            this.rbAte.Size = new System.Drawing.Size(46, 21);
            this.rbAte.TabIndex = 35;
            this.rbAte.Text = "Ate";
            this.rbAte.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(37, 204);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(82, 32);
            this.panel8.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(15, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Local";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyPet.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(586, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 37);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegistrarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(642, 364);
            this.Controls.Add(this.rbMolina);
            this.Controls.Add(this.rbAte);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dgCliente);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBuscardueño);
            this.Controls.Add(this.btmRegistrar);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistrarMascota";
            this.Text = "FrmRegistrarMascota";
            this.Load += new System.EventHandler(this.FrmRegistrarMascota_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button btmRegistrar;
        private System.Windows.Forms.TextBox txtBuscardueño;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.RadioButton rbMolina;
        private System.Windows.Forms.RadioButton rbAte;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
    }
}