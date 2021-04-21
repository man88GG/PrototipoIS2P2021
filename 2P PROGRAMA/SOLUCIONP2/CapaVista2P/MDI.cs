using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridad.Formularios.Mantenimientos;
using CapaVistaSeguridad.Formularios;
using CapaVistaSeguridad;
using CapaVista;

namespace CapaVista2P
{
    public partial class MDI : Form
    {

        clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
        clsVistaBitacora bit = new clsVistaBitacora();

        public MDI()
        {
            InitializeComponent();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de Tipo de Departamento de la empresa", 307);
                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMantenimientoDVD);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmMantenimientoDVD(txtUsuario.Text, this);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de Departamento de la empresa", 307);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmCambioContraseña);
            if (frmFormulario != null)
            {
                frmFormulario.BringToFront();
                return;
            }

            frmFormulario = new frmCambioContraseña(txtUsuario.Text);
            frmFormulario.MdiParent = this;
            frmFormulario.Show();
        }

        private void mantenimientoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de usuarios", 2);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMantenimientoUsuario);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmMantenimientoUsuario(txtUsuario.Text);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de usuarios", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoDeAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("3", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso al mantenimiento de aplicaciones", 3);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmAplicativo);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmAplicativo();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar al mantenimiento de aplicaciones", 3);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void asignacionDePerfilYAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("6", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la asignacion de aplicaciones", 6);


                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmAsignacionDeAplicaciones);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmAsignacionDeAplicaciones();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();


            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a l asignacion de aplicaciones", 6);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoDeModuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("8", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la apliacion de Modulo", 8);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmModulo);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmModulo(txtUsuario.Text);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de Modulo", 8);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoDePerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("4", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la apliacion de mantenimiento de perfil", 4);


                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmMantenimientoPerfil);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmMantenimientoPerfil(txtUsuario.Text);
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de mantenimiento de perfil", 4);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void asignacionDeAplicacionesAPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("5", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la apliacion de mantenimiento de perfil apliaciones a perfil", 5);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmAsignarAplicacionesAPerfil);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmAsignarAplicacionesAPerfil();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();

            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacione de mantenimiento de perfil apliaciones a perfil", 5);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void asignaciónDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("10", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion de Asignacion de permisos", 10);

                Form frmFormulario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmModificarPermisos);
                if (frmFormulario != null)
                {
                    frmFormulario.BringToFront();
                    return;
                }

                frmFormulario = new frmModificarPermisos();
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion de Asignacion de permisos", 10);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = frm.usuario();
            }
        }

        private void mantenimientoDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion Tipo de caso", 2);
                frmMantenimientoDVD asignacion = new frmMantenimientoDVD(txtUsuario.Text, this);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion tipo de caso", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoJuegosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion Tipo de caso", 2);
                frmMantenimientoJuegos asignacion = new frmMantenimientoJuegos(txtUsuario.Text, this);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion tipo de caso", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion Tipo de caso", 2);
                frmMantenimientoCategorias asignacion = new frmMantenimientoCategorias(txtUsuario.Text, this);
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion tipo de caso", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void mantenimientoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion Tipo de caso", 2);
                frmMantenimientoClientes asignacion = new frmMantenimientoClientes();
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion tipo de caso", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

        private void rentaDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seguridad.PermisosAcceso("2", txtUsuario.Text) == 1)
            {
                bit.user(txtUsuario.Text);
                bit.insert("Ingreso a la aplicacion Tipo de caso", 2);
                frmRentas asignacion = new frmRentas();
                asignacion.MdiParent = this;
                asignacion.Show();
            }
            else
            {
                bit.user(txtUsuario.Text);
                bit.insert("Trato de ingresar a la aplicacion tipo de caso", 2);
                MessageBox.Show("El Usuario No Cuenta Con Permisos De Acceso A La Aplicación");
            }
        }

      
    }
}
