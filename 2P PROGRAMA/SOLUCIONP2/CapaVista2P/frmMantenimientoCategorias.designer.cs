
namespace CapaVista
{
    partial class frmMantenimientoCategorias
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
            this.navegador1 = new CapaVistaNavegador.Navegador();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.TxtNombreCat = new System.Windows.Forms.TextBox();
            this.TxtIdTipo = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblIDepa = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvPuestos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(21, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1412, 129);
            this.navegador1.TabIndex = 2;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnInactivo.Location = new System.Drawing.Point(243, 383);
            this.rbtnInactivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(100, 24);
            this.rbtnInactivo.TabIndex = 42;
            this.rbtnInactivo.TabStop = true;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            this.rbtnInactivo.CheckedChanged += new System.EventHandler(this.rbtnInactivo_CheckedChanged);
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnActivo.Location = new System.Drawing.Point(129, 383);
            this.rbtnActivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(84, 24);
            this.rbtnActivo.TabIndex = 41;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            this.rbtnActivo.CheckedChanged += new System.EventHandler(this.rbtnActivo_CheckedChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(435, 464);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(33, 22);
            this.txtEstado.TabIndex = 39;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // TxtNombreCat
            // 
            this.TxtNombreCat.Location = new System.Drawing.Point(59, 284);
            this.TxtNombreCat.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombreCat.Name = "TxtNombreCat";
            this.TxtNombreCat.Size = new System.Drawing.Size(361, 22);
            this.TxtNombreCat.TabIndex = 36;
            this.TxtNombreCat.Tag = "nombre_tipo";
            // 
            // TxtIdTipo
            // 
            this.TxtIdTipo.Location = new System.Drawing.Point(59, 198);
            this.TxtIdTipo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIdTipo.Name = "TxtIdTipo";
            this.TxtIdTipo.Size = new System.Drawing.Size(361, 22);
            this.TxtIdTipo.TabIndex = 35;
            this.TxtIdTipo.Tag = "pk_id_tipo";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstado.Location = new System.Drawing.Point(55, 347);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(66, 20);
            this.lblEstado.TabIndex = 34;
            this.lblEstado.Text = "Estado";
            // 
            // lblIDepa
            // 
            this.lblIDepa.AutoSize = true;
            this.lblIDepa.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDepa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIDepa.Location = new System.Drawing.Point(55, 161);
            this.lblIDepa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDepa.Name = "lblIDepa";
            this.lblIDepa.Size = new System.Drawing.Size(118, 20);
            this.lblIDepa.TabIndex = 33;
            this.lblIDepa.Text = "ID Categoria";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Location = new System.Drawing.Point(55, 234);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(211, 20);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Nombre de la Categoria";
            // 
            // dgvPuestos
            // 
            this.dgvPuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuestos.Location = new System.Drawing.Point(478, 135);
            this.dgvPuestos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPuestos.Name = "dgvPuestos";
            this.dgvPuestos.RowHeadersWidth = 51;
            this.dgvPuestos.Size = new System.Drawing.Size(955, 353);
            this.dgvPuestos.TabIndex = 29;
            // 
            // frmMantenimientoCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1460, 514);
            this.Controls.Add(this.rbtnInactivo);
            this.Controls.Add(this.rbtnActivo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.TxtNombreCat);
            this.Controls.Add(this.TxtIdTipo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblIDepa);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvPuestos);
            this.Controls.Add(this.navegador1);
            this.Name = "frmMantenimientoCategorias";
            this.Text = "frmMantenimientoCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox TxtNombreCat;
        private System.Windows.Forms.TextBox TxtIdTipo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblIDepa;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvPuestos;
    }
}