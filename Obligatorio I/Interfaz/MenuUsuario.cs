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
    public partial class MenuUsuario : UserControl
    {
        private Usuario usuarioLogueado;
        private ControladorUsuarioSinEquipo controlador;
        public MenuUsuario(Usuario u)
        {
            usuarioLogueado = u;
            controlador = new ControladorUsuarioSinEquipo();
            InitializeComponent();
        }

        private void btnCrearPizarron_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.UsuarioSinEquipo(usuarioLogueado);
                Panel parent = this.Parent as Panel;
                CrearPizarron nuevoPizarron = new CrearPizarron(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(nuevoPizarron);
            }
            catch(ExcepcionUsuarioSinEquipo ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void btnVerPizarrón_Click(object sender, EventArgs e)
        {            
            Panel parent = this.Parent as Panel;
            VisualizarPizarron verPizarron = new VisualizarPizarron(usuarioLogueado);
            parent.Controls.Clear();
            parent.Controls.Add(verPizarron);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
