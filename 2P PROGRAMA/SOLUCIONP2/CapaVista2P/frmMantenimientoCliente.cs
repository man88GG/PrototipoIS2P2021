using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaControlador2P;


namespace CapaVista
{
    public partial class frmMantenimientoClientes : Form
    {
        ClsControlador Cont = new ClsControlador();

        public frmMantenimientoClientes()
        {
            InitializeComponent();
               
        }

      


        string Nombres, Apellidos,Correo,ID;
        int estatus, DPI, Tel;

        private void rbtnInactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnInactivo.Checked == true)
            {
                estatus = 0;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //Mensaje de Validación
            if (txtIdCliente.Text == "") { MessageBox.Show("ADVERTENCIA: El campo de busqueda no puede estar vacío.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                //se desbloquean los componentes en los que se puede agregar/cambiar información
                BtnIngresar.Enabled = true;
                funcDesBloqueo();
                BtnIngresar.Enabled = false;

                ID = txtIdCliente.Text;
                String estado;
                //Inicio para Busqueda
                OdbcDataReader Lector = Cont.funcBuscarCliente(txtIdCliente.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {

                        //Se agrega el valor del lector a los textbox dependiendo la posicion 
                        TxtNombre.Text = Lector.GetString(0);
                        TxtApellidos.Text = Lector.GetString(1);
                        TxtDpi.Text = Lector.GetString(2);
                        TxtTel.Text = Lector.GetString(3);
                        TxtCorreo.Text = Lector.GetString(4);
                        estado = Lector.GetString(5);

                        if(estado == "1")
                        {
                            rbtnActivo.Checked = true;
                            
                        }
                        else
                          if(estado == "0")
                        {
                            rbtnInactivo.Checked = true;
                           
                        }

                    }
                }
                else
                {
                    //Mensaje de error
                    MessageBox.Show("ERROR: El ID de ese Cliente no se encuentra Registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    funcBloqueo();
                    funcLimpieza();
                }

            }//fin ifelse


        }

        private void rbtnActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnActivo.Checked == true)
            {
                estatus = 1;
            }
        }

     
        private void BtnModificar_Click(object sender, EventArgs e)
        {

         
            //segunda verificación de datos de cajas de texto vacias
            if (TxtNombre.Text == "" || TxtApellidos.Text == "" || TxtDpi.Text== "" || TxtTel.Text == "" || TxtCorreo.Text == "" ||  (rbtnActivo.Checked == false && rbtnInactivo.Checked == false)) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                //Mensaje de Pregunta
                if (MessageBox.Show("¿Desea agregar modificar este Cliente ?", "CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {


                    //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                    //datos Pasaporte



                    Nombres = TxtNombre.Text;
                    Apellidos = TxtApellidos.Text;
                    DPI = Convert.ToInt32(TxtDpi.Text);
                    Tel = Convert.ToInt32(TxtTel.Text);
                    Correo = TxtCorreo.Text;




                    Cont.funcModificarCliente(Nombres, Apellidos, DPI,Tel,Correo, estatus, ID);
                    MessageBox.Show("Se ha ingresado han modificado los datos del Cliente con Éxito", "MODIFICACION CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    funcLimpieza();
                    funcBloqueo();
                    BtnIngresar.Enabled = true;
                    //envío de datos hacia capa Controlador



                }//fin elseif Pregunta

            }//fin elseif txt


        }

        private void button2_Click(object sender, EventArgs e)
        {


            //segunda verificación de datos de cajas de texto vacias
            if (TxtNombre.Text == "" || TxtApellidos.Text == "" || TxtDpi.Text == "" || TxtTel.Text == "" || TxtCorreo.Text == "" || (rbtnActivo.Checked == false && rbtnInactivo.Checked == false)) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                //Mensaje de Pregunta
                if (MessageBox.Show("¿Desea agregar un nuevo Cliente ?", "CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                else
                {


                    //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                    //datos Pasaporte
                    Nombres = TxtNombre.Text;
                    Apellidos = TxtApellidos.Text;
                    DPI = Convert.ToInt32(TxtDpi.Text);
                    Tel = Convert.ToInt32(TxtTel.Text);
                    Correo = TxtCorreo.Text;


                    Cont.funcInsertarCliente(Nombres, Apellidos, DPI, Tel, Correo, estatus);
                    MessageBox.Show("Se ha ingresado el Cliente con Éxito", "INGRESO Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    funcLimpieza();
                    funcBloqueo();

                    //envío de datos hacia capa Controlador

                }//fin elseif Pregunta

            }//fin elseif txt



        }


        private void funcLimpieza()
        {
           
            txtIdCliente.Text = "";
            TxtNombre.Text = "";
            TxtApellidos.Text = "";
            TxtDpi.Text = "";
            TxtTel.Text = "";
            TxtCorreo.Text = "";
            
            rbtnActivo.Checked = false;
            rbtnInactivo.Checked = false;


        }

        //Función de Bloqueo
        private void funcBloqueo()
        {
            
            BtnModificar.Enabled = false;
            
           

        }

        private void funcDesBloqueo()
        {
            BtnModificar.Enabled = true;
            
        }

    }
}
