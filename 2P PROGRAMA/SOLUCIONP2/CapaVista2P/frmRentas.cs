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
    public partial class frmRentas : Form
    {


        ClsControlador Cont = new ClsControlador();


        public frmRentas()
        {
            InitializeComponent();
            funcTipo();
            funcJuego();
            funcDvD();
            CodigoC.SelectedIndex = +1;
            CodigoC.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbRentas1.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbRentas1.SelectedIndex = +1;
            CmbRentas2.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbRentas2.SelectedIndex = +1;
        }


        public void funcTipo()
        {
            DataTable Datos = Cont.funcNombres();
            CodigoC.DataSource = Datos;
            CodigoC.DisplayMember = "nombres_cliente";
            CodigoC.ResetText();
        }


        public void funcJuego()
        {
            DataTable Datos = Cont.funcJuego();
            CmbRentas2.DataSource = Datos;
            CmbRentas2.DisplayMember = "nombre_juego";
            CmbRentas2.ResetText();
        }

        public void funcDvD()
        {
            DataTable Datos = Cont.funcDvD();
            CmbRentas1.DataSource = Datos;
            CmbRentas1.DisplayMember = "nombre_dvd";
            CmbRentas1.ResetText();
        }



        int Codigo_C, Codigo_P, dias;
        string fecha, costo;

        private void RbtnJuego_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnJuego.Checked == true)
            {
                
                LblCodigo.Text = "Nombre del Juego";
                CmbRentas2.Visible = true;
                
            }
        }

        private void RbtnDvd_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnDvd.Checked == true)
            {

   
                LblCodigo.Text = "Nombre del DvD";
                CmbRentas1.Visible = true;
               
            }
        }

      
        private void funcLimpieza()
        {
           
            TxtDias.Text = "";
            TxtCosto.Text = "";
            CodigoC.Text = "";
            CmbRentas1.Text = "";
            CmbRentas2.Text = "";
            DtpRenta.Value = DateTime.Now;
            

            

        }

        //Función de Bloqueo
        private void funcBloqueo()
        {

            groupBox1.Enabled = false;
            
  
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {


            if (RbtnDvd.Checked == true)
            {

                //segunda verificación de datos de cajas de texto vacias
                if (TxtDias.Text == "" || TxtCosto.Text == "" || (RbtnJuego.Checked == false && RbtnJuego.Checked == false)) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {


                    //Mensaje de Pregunta
                    if (MessageBox.Show("¿Desea agregar una nueva Renta ?", "Renta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                    else
                    {


                        //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                        //datos Pasaporte





                        Codigo_C = CodigoC.SelectedIndex + 1; ;
                        Codigo_P = CmbRentas1.SelectedIndex + 1; ;
                        dias = Convert.ToInt32(TxtDias.Text);
                        costo = TxtCosto.Text;
                        fecha = DtpRenta.Value.Date.ToShortDateString();


                        Cont.funcInsertarRentaD(Codigo_C, Codigo_P, dias, costo, fecha);
                        MessageBox.Show("Se ha ingresado la Renta con Éxito", "INGRESO Renta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        funcLimpieza();
                        funcBloqueo();

                        //envío de datos hacia capa Controlador



                    }//fin elseif Pregunta

                }//fin elseif txt
            }


            if (RbtnJuego.Checked == true)
            {
                //segunda verificación de datos de cajas de texto vacias
                if (TxtDias.Text == "" || TxtCosto.Text == "" || (RbtnJuego.Checked == false && RbtnJuego.Checked == false)) { MessageBox.Show("ADVERTENCIA: Uno o más campos están vacíos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                {


                    //Mensaje de Pregunta
                    if (MessageBox.Show("¿Desea agregar una nueva Renta ?", "Renta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) { }
                    else
                    {


                        //Se da a las variables los valores correspondientes para enviarse a la capa Controlador
                        //datos Pasaporte





                        Codigo_C = CodigoC.SelectedIndex + 1; ;
                        Codigo_P = CmbRentas2.SelectedIndex + 1; ;
                        dias = Convert.ToInt32(TxtDias.Text);
                        costo = TxtCosto.Text;
                        fecha = DtpRenta.Value.Date.ToShortDateString();


                        Cont.funcInsertarRentaJ(Codigo_C, Codigo_P, dias, costo, fecha);
                        MessageBox.Show("Se ha ingresado la Renta con Éxito", "INGRESO Renta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        funcLimpieza();
                        funcBloqueo();

                        //envío de datos hacia capa Controlador



                    }//fin elseif Pregunta

                }//fin elseif txt


            }




            }

        private void funcDesBloqueo()
        {

            groupBox1.Enabled = false;
            
            TxtDias.Enabled = true;
            TxtCosto.Enabled = true;
            CodigoC.Enabled = true;
            CmbRentas1.Enabled = true;
            DtpRenta.Enabled = true;
           
        }






    }
}
