using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo2P;
using System.Data.Odbc;
using System.Data;

namespace CapaControlador2P
{
    public class ClsControlador
    {

        ClsSentencias sn = new ClsSentencias();


        public DataTable funcTipo()
        {
            DataTable Items = sn.funcTipo();
            return Items;
        }

        public DataTable funcNombres()
        {
            DataTable Items = sn.funcNombres();
            return Items;
        }

        public DataTable funcJuego()
        {
            DataTable Items = sn.funcJuego();
            return Items;
        }

        public DataTable funcDvD()
        {
            DataTable Items = sn.funcDvD();
            return Items;
        }


        public OdbcDataReader funcBuscarCliente(string IdCliente)
        {
            OdbcDataReader Lector = sn.funcBuscarCliente(IdCliente);
            return Lector;
        }

        public void funcInsertarCliente(string Nombres, string Apellidos, int DPI, int Tel, string Correo,  int estatus)
        {
            sn.funcInsertarCliente(Nombres, Apellidos, DPI, Tel, Correo, estatus);
        }

        


        public void funcInsertarRentaD(int Codigo_C, int Codigo_P, int dias, string costo, string fecha)
        {
            sn.funcInsertarRentaD(Codigo_C, Codigo_P, dias, costo, fecha);
        }

        public void funcInsertarRentaJ(int Codigo_C, int Codigo_P, int dias, string costo, string fecha)
        {
            sn.funcInsertarRentaJ(Codigo_C, Codigo_P, dias, costo, fecha);
        }



        //Paso de datos para consulta modificar en la entidad PASAPORTE
        public void funcModificarCliente(string Nombres, string Apellidos, int DPI, int Tel, string Correo,int estatus, string ID)
        {

            sn.funcModificarCliente(Nombres, Apellidos, DPI, Tel, Correo, estatus, ID);


        }


    }
}
