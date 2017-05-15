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
        private ControladorFormatoContraseña controlador5;
        private ControladorUsuarioYaIngresado controlador6;

        public CrearUsuario(Usuario u)
        {
            usuarioLogueado = u;
            controlador1 = new ControladorDatosUsuarioVacios();
            controlador2 = new ControladorConfirmacionContraseña();
            controlador3 = new ControladorFormatoEmail();
            controlador4 = new ControladorFechaDeNacimiento();
            controlador5 = new ControladorFormatoContraseña();
            controlador6 = new ControladorUsuarioYaIngresado();
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuAdministrador ventana = new MenuAdministrador(usuarioLogueado);
            Panel parent = this.Parent as Panel;
            parent.Controls.Clear();
            parent.Controls.Add(ventana);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Panel parent = this.Parent as Panel;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string email = txtEmail.Text.ToLower();
                string contraseña = txtContraseña.Text;
                string contraseñaConf = txtConfirmarContraseña.Text;
                bool esAdmin = chkEsAdministrador.Checked;
                DateTime fechaNac = dateTimeFechaNacimiento.Value;
                string[] datos = { nombre, apellido, email, contraseña, contraseñaConf };
                controlador1.DatosUsuarioVacios(datos);
                controlador2.ConfirmacionContraseña(contraseña, contraseñaConf);
                controlador3.ControladorEmail(email);
                controlador4.FechaDeNacimientoValida(fechaNac);
                controlador5.FormatoContraseñaValido(contraseña);
                controlador6.UsuarioYaIngresado(email);
                Usuario u = new Usuario(nombre, apellido, email, fechaNac, contraseña, esAdmin);
                s.AgregarUsuario(u);
                MessageBox.Show("El usuario se ha creado correctamente");
                parent.Controls.Clear();
                parent.Controls.Add(new MenuAdministrador(usuarioLogueado));
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
            catch(ExcepcionFormatoContraseña ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ExcepcionUsuarioYaIngresado ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
