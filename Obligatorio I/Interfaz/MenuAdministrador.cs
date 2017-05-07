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
    public partial class MenuAdministrador : UserControl
    {
        private Usuario usuarioLogueado;
        public MenuAdministrador(Usuario u)
        {
            usuarioLogueado = u;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            CrearUsuario nuevoUsuario = new CrearUsuario(usuarioLogueado);
            parent.Controls.Clear();
            parent.Controls.Add(nuevoUsuario);
        }

        private void btnCrearEquipo_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            CrearEquipo nuevoEquipo = new CrearEquipo(usuarioLogueado);
            parent.Controls.Clear();
            parent.Controls.Add(nuevoEquipo);
        }

        private void btnCrearPizarron_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            CrearPizarron nuevoPizarron = new CrearPizarron(usuarioLogueado);
            parent.Controls.Clear();
            parent.Controls.Add(nuevoPizarron);
        }

        private void btnVerPizarrón_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            VisualizarPizarron verPizarron = new VisualizarPizarron(usuarioLogueado);
            parent.Controls.Clear();
            parent.Controls.Add(verPizarron);
        }

        private void btnInformePizarron_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            InformePizarronesPorEquipo nuevoInformePizarron = new InformePizarronesPorEquipo(usuarioLogueado);
            parent.Controls.Clear();
            parent.Controls.Add(nuevoInformePizarron);
        }

        private void btnInformeComentario_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            InformeComentariosPorUsuario nuevoInformeComentario = new InformeComentariosPorUsuario(usuarioLogueado);
            parent.Controls.Clear();
            parent.Controls.Add(nuevoInformeComentario);
        }
    }
}
