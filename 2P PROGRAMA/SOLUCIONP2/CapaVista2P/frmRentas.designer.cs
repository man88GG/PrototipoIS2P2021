
namespace CapaVista
{
    partial class frmRentas
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
            this.DtpRenta = new System.Windows.Forms.DateTimePicker();
            this.LblFechaNac = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.RbtnDvd = new System.Windows.Forms.RadioButton();
            this.RbtnJuego = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoC = new System.Windows.Forms.ComboBox();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.CmbRentas1 = new System.Windows.Forms.ComboBox();
            this.LblNacimiento = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbRentas2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtpRenta
            // 
            this.DtpRenta.CalendarFont = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpRenta.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DtpRenta.Location = new System.Drawing.Point(306, 254);
            this.DtpRenta.Name = "DtpRenta";
            this.DtpRenta.Size = new System.Drawing.Size(311, 22);
            this.DtpRenta.TabIndex = 94;
            // 
            // LblFechaNac
            // 
            this.LblFechaNac.AutoSize = true;
            this.LblFechaNac.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFechaNac.Location = new System.Drawing.Point(10, 184);
            this.LblFechaNac.Name = "LblFechaNac";
            this.LblFechaNac.Size = new System.Drawing.Size(155, 22);
            this.LblFechaNac.TabIndex = 100;
            this.LblFechaNac.Text = "Costo por Renta";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCodigo.Location = new System.Drawing.Point(10, 74);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(214, 22);
            this.LblCodigo.TabIndex = 104;
            this.LblCodigo.Text = "Nombres del Producto";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNombres.Location = new System.Drawing.Point(10, 24);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(199, 22);
            this.LblNombres.TabIndex = 103;
            this.LblNombres.Text = "Nombres del Cliente";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIngresar.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIngresar.Location = new System.Drawing.Point(463, 495);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(190, 61);
            this.BtnIngresar.TabIndex = 124;
            this.BtnIngresar.Text = "Ingresar Datos";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // RbtnDvd
            // 
            this.RbtnDvd.AutoSize = true;
            this.RbtnDvd.Checked = true;
            this.RbtnDvd.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnDvd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RbtnDvd.Location = new System.Drawing.Point(139, 84);
            this.RbtnDvd.Margin = new System.Windows.Forms.Padding(4);
            this.RbtnDvd.Name = "RbtnDvd";
            this.RbtnDvd.Size = new System.Drawing.Size(68, 24);
            this.RbtnDvd.TabIndex = 109;
            this.RbtnDvd.TabStop = true;
            this.RbtnDvd.Text = "DvD";
            this.RbtnDvd.UseVisualStyleBackColor = true;
            this.RbtnDvd.CheckedChanged += new System.EventHandler(this.RbtnDvd_CheckedChanged);
            // 
            // RbtnJuego
            // 
            this.RbtnJuego.AutoSize = true;
            this.RbtnJuego.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnJuego.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RbtnJuego.Location = new System.Drawing.Point(381, 84);
            this.RbtnJuego.Margin = new System.Windows.Forms.Padding(4);
            this.RbtnJuego.Name = "RbtnJuego";
            this.RbtnJuego.Size = new System.Drawing.Size(79, 24);
            this.RbtnJuego.TabIndex = 110;
            this.RbtnJuego.Text = "Juego";
            this.RbtnJuego.UseVisualStyleBackColor = true;
            this.RbtnJuego.CheckedChanged += new System.EventHandler(this.RbtnJuego_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(135, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 22);
            this.label1.TabIndex = 127;
            this.label1.Text = "Seleccione el tipo de Producto a Rentar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(10, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 22);
            this.label2.TabIndex = 128;
            this.label2.Text = "Cantidad de Días de Renta";
            // 
            // CodigoC
            // 
            this.CodigoC.FormattingEnabled = true;
            this.CodigoC.Location = new System.Drawing.Point(313, 24);
            this.CodigoC.Name = "CodigoC";
            this.CodigoC.Size = new System.Drawing.Size(311, 24);
            this.CodigoC.TabIndex = 87;
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(313, 186);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(239, 22);
            this.TxtCosto.TabIndex = 97;
            // 
            // TxtDias
            // 
            this.TxtDias.Location = new System.Drawing.Point(313, 132);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(239, 22);
            this.TxtDias.TabIndex = 96;
            // 
            // CmbRentas1
            // 
            this.CmbRentas1.FormattingEnabled = true;
            this.CmbRentas1.Location = new System.Drawing.Point(313, 74);
            this.CmbRentas1.Name = "CmbRentas1";
            this.CmbRentas1.Size = new System.Drawing.Size(311, 24);
            this.CmbRentas1.TabIndex = 103;
            this.CmbRentas1.Visible = false;
            // 
            // LblNacimiento
            // 
            this.LblNacimiento.AutoSize = true;
            this.LblNacimiento.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNacimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNacimiento.Location = new System.Drawing.Point(10, 254);
            this.LblNacimiento.Name = "LblNacimiento";
            this.LblNacimiento.Size = new System.Drawing.Size(239, 22);
            this.LblNacimiento.TabIndex = 104;
            this.LblNacimiento.Text = "Fecha Vencimiento Renta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbRentas2);
            this.groupBox1.Controls.Add(this.LblFechaNac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCosto);
            this.groupBox1.Controls.Add(this.CodigoC);
            this.groupBox1.Controls.Add(this.CmbRentas1);
            this.groupBox1.Controls.Add(this.LblNacimiento);
            this.groupBox1.Controls.Add(this.DtpRenta);
            this.groupBox1.Controls.Add(this.LblCodigo);
            this.groupBox1.Controls.Add(this.LblNombres);
            this.groupBox1.Controls.Add(this.TxtDias);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 316);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            // 
            // CmbRentas2
            // 
            this.CmbRentas2.FormattingEnabled = true;
            this.CmbRentas2.Location = new System.Drawing.Point(313, 74);
            this.CmbRentas2.Name = "CmbRentas2";
            this.CmbRentas2.Size = new System.Drawing.Size(311, 24);
            this.CmbRentas2.TabIndex = 130;
            this.CmbRentas2.Visible = false;
            // 
            // frmRentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(671, 590);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RbtnDvd);
            this.Controls.Add(this.RbtnJuego);
            this.Name = "frmRentas";
            this.Text = "frmRentas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DtpRenta;
        private System.Windows.Forms.Label LblFechaNac;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.RadioButton RbtnDvd;
        private System.Windows.Forms.RadioButton RbtnJuego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CodigoC;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.ComboBox CmbRentas1;
        private System.Windows.Forms.Label LblNacimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbRentas2;
    }
}