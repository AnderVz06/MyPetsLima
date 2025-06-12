
namespace MyPet
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.error2 = new System.Windows.Forms.PictureBox();
            this.lbCont = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAcceder = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.error1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 2);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(1, 347);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 2);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 347);
            this.panel6.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 349);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyPet.Properties.Resources.FotoPortada;
            this.pictureBox1.Location = new System.Drawing.Point(14, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(49)))), ((int)(((byte)(118)))));
            this.panelContenedor.Controls.Add(this.txtCorreo);
            this.panelContenedor.Controls.Add(this.pictureBox4);
            this.panelContenedor.Controls.Add(this.error2);
            this.panelContenedor.Controls.Add(this.lbCont);
            this.panelContenedor.Controls.Add(this.lbCorreo);
            this.panelContenedor.Controls.Add(this.pictureBox2);
            this.panelContenedor.Controls.Add(this.txtContraseña);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.label3);
            this.panelContenedor.Controls.Add(this.btAcceder);
            this.panelContenedor.Controls.Add(this.pictureBox3);
            this.panelContenedor.Controls.Add(this.pictureBox5);
            this.panelContenedor.Controls.Add(this.error1);
            this.panelContenedor.Location = new System.Drawing.Point(338, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(224, 349);
            this.panelContenedor.TabIndex = 0;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(36, 134);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCorreo.Size = new System.Drawing.Size(147, 21);
            this.txtCorreo.TabIndex = 59;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MyPet.Properties.Resources.este_;
            this.pictureBox4.Location = new System.Drawing.Point(203, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 58;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // error2
            // 
            this.error2.Image = global::MyPet.Properties.Resources.ErrorSesion;
            this.error2.Location = new System.Drawing.Point(33, 225);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(15, 14);
            this.error2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error2.TabIndex = 57;
            this.error2.TabStop = false;
            this.error2.Visible = false;
            // 
            // lbCont
            // 
            this.lbCont.AutoSize = true;
            this.lbCont.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCont.ForeColor = System.Drawing.Color.DarkGray;
            this.lbCont.Location = new System.Drawing.Point(48, 225);
            this.lbCont.Name = "lbCont";
            this.lbCont.Size = new System.Drawing.Size(0, 13);
            this.lbCont.TabIndex = 55;
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.ForeColor = System.Drawing.Color.DarkGray;
            this.lbCorreo.Location = new System.Drawing.Point(48, 159);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(0, 13);
            this.lbCorreo.TabIndex = 54;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyPet.Properties.Resources.iconoSesion;
            this.pictureBox2.Location = new System.Drawing.Point(73, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 70);
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtContraseña.Location = new System.Drawing.Point(36, 198);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(5, 5, 3, 3);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '•';
            this.txtContraseña.Size = new System.Drawing.Size(148, 23);
            this.txtContraseña.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Usuario";
            // 
            // btAcceder
            // 
            this.btAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.btAcceder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAcceder.FlatAppearance.BorderSize = 0;
            this.btAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcceder.ForeColor = System.Drawing.Color.Black;
            this.btAcceder.Location = new System.Drawing.Point(41, 267);
            this.btAcceder.Name = "btAcceder";
            this.btAcceder.Size = new System.Drawing.Size(144, 35);
            this.btAcceder.TabIndex = 47;
            this.btAcceder.Text = "ACCEDER";
            this.btAcceder.UseVisualStyleBackColor = false;
            this.btAcceder.Click += new System.EventHandler(this.btAcceder_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MyPet.Properties.Resources.ContraseñaVista;
            this.pictureBox3.Location = new System.Drawing.Point(191, 197);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 52;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MyPet.Properties.Resources.contraseñaOculta;
            this.pictureBox5.Location = new System.Drawing.Point(191, 197);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 53;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // error1
            // 
            this.error1.Image = global::MyPet.Properties.Resources.ErrorSesion;
            this.error1.Location = new System.Drawing.Point(33, 158);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(15, 14);
            this.error1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error1.TabIndex = 56;
            this.error1.TabStop = false;
            this.error1.Visible = false;
            this.error1.Click += new System.EventHandler(this.error1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 349);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox error2;
        private System.Windows.Forms.PictureBox error1;
        private System.Windows.Forms.Label lbCont;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAcceder;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox txtCorreo;
    }
}

