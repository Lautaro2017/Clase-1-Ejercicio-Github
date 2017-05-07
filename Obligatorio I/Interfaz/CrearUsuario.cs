using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Obligatorio_I;
using Lógica;
using Excepciones;

namespace Interfaz
{
    public partial class CrearUsuario : UserControl
    {
        Sistema s = Sistema.GetInstance();        
        private Usuario usuarioLogueado;
        private ControladorDatosUsuarioVacios controlador1;
        private ControladorConfirmacionContraseña controlador2;
        private ControladorFormatoEmail controlador3;
        private ControladorFechaDeNacimiento controlador4;

        public CrearUsuario(Usuario u)
        {
            usuarioLogueado = u;
            controlador1 = new ControladorDatosUsuarioVacios();
            controlador2 = new ControladorConfirmacionContraseña();
            controlador3 = new ControladorFormatoEmail();
            controlador4 = new ControladorFechaDeNacimiento();
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string email = txtEmail.Text;
                string contraseña = txtContraseña.Text;
                string contraseñaConf = txtConfirmarContraseña.Text;
                bool esAdmin = chkEsAdministrador.Checked;
                DateTime fechaNac = dateTimeFechaNacimiento.Value;
                string[] datos = { nombre, apellido, email, contraseña, contraseñaConf };
                controlador1.DatosUsuarioVacios(datos);
                controlador2.ConfirmacionContraseña(contraseña, contraseñaConf);
                controlador3.ControladorEmail(email);
                controlador4.FechaDeNacimientoValida(fechaNac);
                Usuario u = new Usuario(nombre, apellido, email, fechaNac, contraseña, esAdmin);
                s.AgregarUsuario(u);
            }
            catch(ExcepcionDatosVacios ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ExcepcionConfirmacionContraseña ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ExcepcionEmail ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionFechaDeNacimiento ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
