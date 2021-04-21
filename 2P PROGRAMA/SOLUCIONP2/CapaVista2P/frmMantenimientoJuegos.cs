using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador2P;

namespace CapaVista
{
    public partial class frmMantenimientoJuegos : Form
    {
        string UsuarioAplicacion;
        static Form FormularioPadre;

        ClsControlador Cont = new ClsControlador();

        public frmMantenimientoJuegos(string usuario, Form formularioPadre)
        {
            InitializeComponent();

            UsuarioAplicacion = usuario;
            navegador1.Usuario = UsuarioAplicacion;
            FormularioPadre = formularioPadre;
            funcTipo();
            CmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        public void funcTipo()
        {
            DataTable Datos = Cont.funcTipo();
            CmbTipo.DataSource = Datos;
            CmbTipo.DisplayMember = "nombre_tipo";
            CmbTipo.ResetText();
        }


       



        private void rbtnActivo_CheckedChanged(object sender, EventArgs e)
        {
            //Asignar estado en TxtEstado segun el Checked
            if (rbtnActivo.Checked == true)
            {
                txtEstado.Text = "1";
            }
        }

        private void rbtnInactivo_CheckedChanged(object sender, EventArgs e)
        {
            //Asignar estado en TxtEstado segun el Checked
            if (rbtnInactivo.Checked == true)
            {
                txtEstado.Text = "0";
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            //Asignar estado en TxtEstado segun el Checked
            if (txtEstado.Text == "")
            {
                rbtnActivo.Checked = false;
                rbtnInactivo.Checked = false;
            }
            if (txtEstado.Text == "1")
            {
                rbtnActivo.Checked = true;
            }
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            List<string> CamposTabla = new List<string>();
            List<Control> lista = new List<Control>();
            //el numero de aplicacion se debe cambiar por el numero asignado en la base de datos 
            navegador1.aplicacion = 2;
            //banco se debe cambiar por la tabla a la que se quiere hacer el mantenimiento
            navegador1.tbl = "juegos";
            //estado_banco se debe cambiar por el estado de la tabla a la que se desea hacer mantenimiento
            navegador1.campoEstado = "estado";
            navegador1.MDIformulario = FormularioPadre;
            foreach (Control C in this.Controls)
            {
                if ((C.Tag != null) && (!C.Tag.ToString().Equals("")))
                {
                    if (C is TextBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is ComboBox)
                    {
                        lista.Add(C);

                    }
                    else if (C is DateTimePicker)
                    {
                        lista.Add(C);
                    }
                }
            }
            navegador1.control = lista;
            navegador1.formulario = this;
            //el dataGridView1 se debe cambiar por el que se tiene en el formulario
            navegador1.DatosActualizar = dgvDepartamentos;
            navegador1.procActualizarData();
            navegador1.procCargar();
        }
    }
}
