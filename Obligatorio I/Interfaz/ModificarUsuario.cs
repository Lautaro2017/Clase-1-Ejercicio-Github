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
    public partial class ModificarUsuario : UserControl
    {
        Sistema s = Sistema.GetInstance();
        private Usuario usuarioLogueado;
        private Usuario usuarioSeleccionado;
        private ControladorDatosUsuarioVacios controlador1;
        private ControladorConfirmacionContraseña controlador2;
        private ControladorFormatoEmail controlador3;
        private ControladorFechaDeNacimiento controlador4;
        private ControladorFormatoContraseña controlador5;
        private ControladorUsuarioYaIngresado controlador6;

        public ModificarUsuario(Usuario u)
        {
            InitializeComponent();
            controlador1 = new ControladorDatosUsuarioVacios();
            controlador2 = new ControladorConfirmacionContraseña();
            controlador3 = new ControladorFormatoEmail();
            controlador4 = new ControladorFechaDeNacimiento();
            controlador5 = new ControladorFormatoContraseña();
            controlador6 = new ControladorUsuarioYaIngresado();
            usuarioLogueado = u;
            InicializarCombo();
        }

        public void InicializarCombo()
        {
            List<Usuario> usuarios = s.Usuarios;
            cmbUsuarios.Items.AddRange(usuarios.ToArray());
            cmbUsuarios.SelectedIndex = 0;
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            usuarioSeleccionado = ((Usuario)cmbUsuarios.SelectedItem);
            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
            string nombre = ((Usuario)cmbUsuarios.SelectedItem).Nombre;
            string apellido = ((Usuario)cmbUsuarios.SelectedItem).Apellido;
            string email = ((Usuario)cmbUsuarios.SelectedItem).Email;
            string contraseña = ((Usuario)cmbUsuarios.SelectedItem).Contraseña;
            DateTime fechaNac = ((Usuario)cmbUsuarios.SelectedItem).FechaNacimiento;
            bool admin = ((Usuario)cmbUsuarios.SelectedItem).EsAdministrador;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtEmail.Text = email;
            txtContraseña.Text = contraseña;
            txtConfirmarContraseña.Text = contraseña;
            dateTimeFechaNacimiento.Value = fechaNac;
            chkEsAdministrador.Checked = admin;
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
                for (int i = 0; i < s.Usuarios.Count; i++)
                {
                    if (usuarioSeleccionado.Equals(s.Usuarios[i]))
                    {
                        s.Usuarios[i] = u;                        
                    }
                }
                MessageBox.Show("El usuario se ha creado correctamente");
                parent.Controls.Clear();
                parent.Controls.Add(new MenuAdministrador(usuarioLogueado));
            }
            catch (ExcepcionDatosVacios ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionConfirmacionContraseña ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionEmail ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionFechaDeNacimiento ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionFormatoContraseña ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionUsuarioYaIngresado ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuAdministrador ventana = new MenuAdministrador(usuarioLogueado);
            Panel parent = this.Parent as Panel;
            parent.Controls.Clear();
            parent.Controls.Add(ventana);
        }
    }
}
