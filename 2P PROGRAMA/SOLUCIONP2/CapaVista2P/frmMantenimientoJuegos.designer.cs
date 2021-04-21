
namespace CapaVista
{
    partial class frmMantenimientoJuegos
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.LblIdJuego = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblExistencia = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.LblAutor = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
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
            this.txtEstado.Location = new System.Drawing.Point(577, 533);
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
            this.rbtnInactivo.Location = new System.Drawing.Point(195, 549);
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
            this.rbtnActivo.Location = new System.Drawing.Point(86, 549);
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
            this.lblEstado.Location = new System.Drawing.Point(12, 514);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(150, 20);
            this.lblEstado.TabIndex = 38;
            this.lblEstado.Text = "Estado del Juego";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(15, 292);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(333, 22);
            this.TxtNombre.TabIndex = 2;
            this.TxtNombre.Tag = "nombre_juego";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(13, 193);
            this.TxtId.Margin = new System.Windows.Forms.Padding(4);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(157, 22);
            this.TxtId.TabIndex = 1;
            this.TxtId.Tag = "pk_id_juego";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNombre.Location = new System.Drawing.Point(13, 247);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(162, 20);
            this.LblNombre.TabIndex = 33;
            this.LblNombre.Text = "Nombre del Juego";
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Location = new System.Drawing.Point(679, 186);
            this.dgvDepartamentos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.RowHeadersWidth = 51;
            this.dgvDepartamentos.Size = new System.Drawing.Size(731, 395);
            this.dgvDepartamentos.TabIndex = 35;
            // 
            // LblIdJuego
            // 
            this.LblIdJuego.AutoSize = true;
            this.LblIdJuego.Enabled = false;
            this.LblIdJuego.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdJuego.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblIdJuego.Location = new System.Drawing.Point(13, 146);
            this.LblIdJuego.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdJuego.Name = "LblIdJuego";
            this.LblIdJuego.Size = new System.Drawing.Size(123, 20);
            this.LblIdJuego.TabIndex = 34;
            this.LblIdJuego.Text = "Codigo Juego";
            // 
            // CmbTipo
            // 
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Location = new System.Drawing.Point(426, 186);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(213, 24);
            this.CmbTipo.TabIndex = 5;
            this.CmbTipo.Tag = "fk_idtipo";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(426, 362);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(213, 22);
            this.TxtCantidad.TabIndex = 7;
            this.TxtCantidad.Tag = "existencia_juego";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(426, 270);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(213, 22);
            this.TxtPrecio.TabIndex = 6;
            this.TxtPrecio.Tag = "precio_dia_juego";
            // 
            // LblExistencia
            // 
            this.LblExistencia.AutoSize = true;
            this.LblExistencia.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExistencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblExistencia.Location = new System.Drawing.Point(425, 321);
            this.LblExistencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblExistencia.Name = "LblExistencia";
            this.LblExistencia.Size = new System.Drawing.Size(205, 20);
            this.LblExistencia.TabIndex = 55;
            this.LblExistencia.Text = "Cantidad en Existencia";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPrecio.Location = new System.Drawing.Point(425, 230);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(137, 20);
            this.LblPrecio.TabIndex = 54;
            this.LblPrecio.Text = "Precio Unitario";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTipo.Location = new System.Drawing.Point(422, 152);
            this.LblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(101, 20);
            this.LblTipo.TabIndex = 53;
            this.LblTipo.Text = "Tipo Juego";
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(17, 462);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(299, 22);
            this.TxtAutor.TabIndex = 4;
            this.TxtAutor.Tag = "autor_juego";
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblAutor.Location = new System.Drawing.Point(12, 426);
            this.LblAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(109, 20);
            this.LblAutor.TabIndex = 61;
            this.LblAutor.Text = "Autor Juego";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDescripcion.Location = new System.Drawing.Point(11, 342);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(167, 20);
            this.LblDescripcion.TabIndex = 60;
            this.LblDescripcion.Text = "Descripción Juego";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 383);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(299, 22);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Tag = "descripcion_juego";
            // 
            // frmMantenimientoJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1423, 594);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.LblAutor);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.CmbTipo);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.LblExistencia);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.rbtnInactivo);
            this.Controls.Add(this.rbtnActivo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.dgvDepartamentos);
            this.Controls.Add(this.LblIdJuego);
            this.Controls.Add(this.navegador1);
            this.Name = "frmMantenimientoJuegos";
            this.Text = "frmMantenimientoDepto";
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
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.Label LblIdJuego;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblExistencia;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}