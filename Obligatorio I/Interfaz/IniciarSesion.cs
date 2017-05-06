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

namespace Interfaz
{
    public partial class IniciarSesion : UserControl
    {
        Sistema s = Sistema.GetInstance();

        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string email = this.txtUsuario.Text;
            string contraseña = this.txtContraseña.Text;
        }
    }
}
