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
    public partial class IniciarSesion : UserControl
    {
        Sistema s = Sistema.GetInstance();
        private ControladorInicioSesion controlador1;
        private ControladorContraseñaCorrecta controlador2;

        public IniciarSesion()
        {
            controlador1 = new ControladorInicioSesion();
            controlador2 = new ControladorContraseñaCorrecta();
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string email = this.txtUsuario.Text;
                string contraseña = this.txtContraseña.Text;
                controlador1.IniciarSesionOK(email, contraseña);
                controlador2.ContraseñaCorrectaOK(email, contraseña);
                Panel parent = this.Parent as Panel;
                if (s.BuscarUsuarioPorMail(email).EsAdministrador)
                {
                    MenuAdministrador nuevoMenuAdmin = new MenuAdministrador(email);
                    parent.Controls.Clear();
                    parent.Controls.Add(nuevoMenuAdmin);
                }
                else
                {
                    MenuUsuario nuevoMenuUsuario = new MenuUsuario(email);
                    parent.Controls.Clear();
                    parent.Controls.Add(nuevoMenuUsuario);
                }
            }
            catch(ExcepcionUsuarioIncorrecto e1)
            {
                MessageBox.Show(e1.Message);
            }
            catch(ExcepcionContraseñaIncorrecta e2)
            {
                MessageBox.Show(e2.Message);
            }
        }
    }
}