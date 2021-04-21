
namespace CapaVista
{
    partial class frmMantenimientoDVD
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
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDepartamento = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.LblIdDvd = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblExistencia = new System.Windows.Forms.Label();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Transparent;
            this.navegador1.Location = new System.Drawing.Point(-2, 13);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1412, 129);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(559, 547);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(33, 22);
            this.txtEstado.TabIndex = 8;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtnInactivo.Location = new System.Drawing.Point(254, 534);
            this.rbtnInactivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(100, 24);
            this.rbtnInactivo.TabIndex = 40;
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
            this.rbtnActivo.Location = new System.Drawing.Point(145, 534);
            this.rbtnActivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(84, 24);
            this.rbtnActivo.TabIndex = 39;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            this.rbtnActivo.CheckedChanged += new System.EventHandler(this.rbtnActivo_CheckedChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEstado.Location = new System.Drawing.Point(71, 499);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(139, 20);
            this.lblEstado.TabIndex = 38;
            this.lblEstado.Text = "Estado del DvD";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(25, 264);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "nombre_dvd";
            // 
            // txtIDepartamento
            // 
            this.txtIDepartamento.Location = new System.Drawing.Point(25, 180);
            this.txtIDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDepartamento.Name = "txtIDepartamento";
            this.txtIDepartamento.Size = new System.Drawing.Size(151, 22);
            this.txtIDepartamento.TabIndex = 1;
            this.txtIDepartamento.Tag = "pk_id_dvd";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNombre.Location = new System.Drawing.Point(21, 224);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(153, 20);
            this.LblNombre.TabIndex = 33;
            this.LblNombre.Text = "Nombre del DVD";
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Location = new System.Drawing.Point(638, 180);
            this.dgvDepartamentos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.RowHeadersWidth = 51;
            this.dgvDepartamentos.Size = new System.Drawing.Size(772, 389);
            this.dgvDepartamentos.TabIndex = 35;
            // 
            // LblIdDvd
            // 
            this.LblIdDvd.AutoSize = true;
            this.LblIdDvd.Enabled = false;
            this.LblIdDvd.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdDvd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblIdDvd.Location = new System.Drawing.Point(21, 140);
            this.LblIdDvd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdDvd.Name = "LblIdDvd";
            this.LblIdDvd.Size = new System.Drawing.Size(114, 20);
            this.LblIdDvd.TabIndex = 34;
            this.LblIdDvd.Text = "Código DVD";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(24, 356);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(299, 22);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Tag = "descripcion_dvd";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDescripcion.Location = new System.Drawing.Point(20, 315);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(156, 20);
            this.LblDescripcion.TabIndex = 43;
            this.LblDescripcion.Text = "Descripción DvD";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTipo.Location = new System.Drawing.Point(375, 146);
            this.LblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(87, 20);
            this.LblTipo.TabIndex = 44;
            this.LblTipo.Text = "Tipo Dvd";
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblAutor.Location = new System.Drawing.Point(21, 399);
            this.LblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(100, 20);
            this.LblAutor.TabIndex = 45;
            this.LblAutor.Text = "Autor DVD";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPrecio.Location = new System.Drawing.Point(378, 224);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(137, 20);
            this.LblPrecio.TabIndex = 46;
            this.LblPrecio.Text = "Precio Unitario";
            // 
            // LblExistencia
            // 
            this.LblExistencia.AutoSize = true;
            this.LblExistencia.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExistencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblExistencia.Location = new System.Drawing.Point(378, 315);
            this.LblExistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblExistencia.Name = "LblExistencia";
            this.LblExistencia.Size = new System.Drawing.Size(205, 20);
            this.LblExistencia.TabIndex = 47;
            this.LblExistencia.Text = "Cantidad en Existencia";
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(26, 435);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(299, 22);
            this.TxtAutor.TabIndex = 4;
            this.TxtAutor.Tag = "autor_dvd";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(379, 264);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(213, 22);
            this.TxtPrecio.TabIndex = 6;
            this.TxtPrecio.Tag = "precio_dia_dvd";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(379, 356);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(213, 22);
            this.TxtCantidad.TabIndex = 7;
            this.TxtCantidad.Tag = "existencia_dvd";
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(379, 180);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(213, 24);
            this.CmbTipo.TabIndex = 5;
            this.CmbTipo.Tag = "fk_idtipo";
            // 
            // frmMantenimientoDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1423, 582);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.LblExistencia);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.rbtnInactivo);
            this.Controls.Add(this.rbtnActivo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDepartamento);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.dgvDepartamentos);
            this.Controls.Add(this.LblIdDvd);
            this.Controls.Add(this.navegador1);
            this.Name = "frmMantenimientoDVD";
            this.Text = "frmMantenimientoDVD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CapaVistaNavegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDepartamento;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.Label LblIdDvd;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblExistencia;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.ComboBox CmbTipo;
    }
}