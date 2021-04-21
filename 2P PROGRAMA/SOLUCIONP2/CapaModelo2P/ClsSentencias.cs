using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;


namespace CapaModelo2P
{
    public class ClsSentencias
    {

        ClsConexion Con = new ClsConexion();

        public DataTable funcTipo()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaTipoPass = "SELECT * FROM TIPO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaTipoPass, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin

        public DataTable funcNombres()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaTipoPass = "SELECT * FROM CLIENTES";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaTipoPass, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin

        public DataTable funcDvD()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaTipoPass = "SELECT * FROM DVD";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaTipoPass, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin

        public DataTable funcJuego()
        {
            DataTable Datos = new DataTable();
            try
            {
                string CargaTipoPass = "SELECT * FROM JUEGOS";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaTipoPass, Con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.desconexion(Con.conexion());
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }//fin




        public OdbcDataReader funcBuscarCliente(string ID)
        {
            try
            {
                //sentencia para realizar la busqueda obteniendo los nombres de las diferentes entidades e igualando los ID de las diferentes tablas
                string sentencia = "SELECT C.NOMBRES_CLIENTE, C.APELLIDOS_CLIENTE, C.DPI_CLIENTE, C.TELEFONO_CLIENTE, C.CORREO_CLIENTE, C.ESTADO FROM CLIENTES AS C WHERE C.PK_ID_CLIENTE = '" + ID + "'";

                OdbcCommand Query_BusquedaReclu = new OdbcCommand(sentencia, Con.conexion());
                OdbcDataReader Lector = Query_BusquedaReclu.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //Consulta para ingresar datos en la entidad EMPLEADO
        public void funcInsertarCliente(string Nombres, string Apellidos, int DPI, int Tel, string Correo,  int estatus)
        {
            try
            {
                int Idcliente;
                string CorrelativoReclu = "SELECT IFNULL(MAX(pk_id_cliente),0) +1 FROM CLIENTES";
                OdbcCommand QueryIdReclu = new OdbcCommand(CorrelativoReclu, Con.conexion());
                Idcliente = Convert.ToInt32(QueryIdReclu.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdReclu.ExecuteReader();

                //falta firma, fotografia y lugar nacimiento
                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaRecluta = "INSERT INTO CLIENTES (pk_id_cliente, nombres_cliente, apellidos_cliente, " +
                    "dpi_cliente, telefono_cliente, correo_cliente, estado) VALUES " + "('" + Idcliente + "','" + Nombres + "','" + Apellidos + "','" + DPI + "','"
                    + Correo + "','" + Tel + "','" + estatus + "')";

                OdbcCommand Query_IngresoRec = new OdbcCommand(SentenciaRecluta, Con.conexion());

                Query_IngresoRec.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //consulta para modificar en la entidad Reclutamiento
        public void funcModificarCliente(string Nombres, string Apellidos, int DPI, int Tel, string Correo, int estatus, string ID)
        {
            try
            {


                string sentencia = "UPDATE CLIENTES SET nombres_cliente='" + Nombres + "', apellidos_cliente='" + Apellidos + "', dpi_cliente='" + DPI + "', telefono_cliente='" + Tel + "', correo_cliente='" + Correo +
                    "', estado='" + estatus + "' WHERE pk_id_cliente= '" + ID + "'";


                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.conexion());

                Query_Validacion1.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Consulta para ingresar datos en la entidad EMPLEADO
        public void funcInsertarRentaD(int Codigo_C, int Codigo_P, int dias, string costo, string fecha)
        {
            try
            {
                int Idcliente;
                string CorrelativoReclu = "SELECT IFNULL(MAX(pk_id_renta_dvd),0) +1 FROM RENTA_DVD";
                OdbcCommand QueryIdReclu = new OdbcCommand(CorrelativoReclu, Con.conexion());
                Idcliente = Convert.ToInt32(QueryIdReclu.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdReclu.ExecuteReader();

                //falta firma, fotografia y lugar nacimiento
                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaRecluta = "INSERT INTO RENTA_DVD (pk_id_renta_dvd, fk_id_cliente, fk_id_dvd, " +
                    "dias_renta, costo_renta, fecha_vencimiento) VALUES " + "('" + Idcliente + "','" + Codigo_C + "','" + Codigo_P + "','" + dias + "','"
                    + costo + "','" + fecha + "')";

                OdbcCommand Query_IngresoRec = new OdbcCommand(SentenciaRecluta, Con.conexion());

                Query_IngresoRec.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void funcInsertarRentaJ(int Codigo_C, int Codigo_P, int dias, string costo, string fecha)
        {
            try
            {
                int Idcliente;
                string CorrelativoReclu = "SELECT IFNULL(MAX(pk_id_renta_juego),0) +1 FROM RENTA_JUEGO";
                OdbcCommand QueryIdReclu = new OdbcCommand(CorrelativoReclu, Con.conexion());
                Idcliente = Convert.ToInt32(QueryIdReclu.ExecuteScalar());
                OdbcDataReader Ejecucion1 = QueryIdReclu.ExecuteReader();

                //falta firma, fotografia y lugar nacimiento
                //Sentencia para insertar datos a entidad Reclutamiento
                string SentenciaRecluta = "INSERT INTO RENTA_JUEGO (pk_id_renta_juego, fk_id_cliente, fk_id_juego, " +
                    "dias_renta, costo_renta, fecha_vencimiento) VALUES " + "('" + Idcliente + "','" + Codigo_C + "','" + Codigo_P + "','" + dias + "','"
                    + costo + "','" + fecha + "')";

                OdbcCommand Query_IngresoRec = new OdbcCommand(SentenciaRecluta, Con.conexion());

                Query_IngresoRec.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
