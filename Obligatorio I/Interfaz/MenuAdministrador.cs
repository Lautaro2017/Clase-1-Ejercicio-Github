using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MenuAdministrador : UserControl
    {
        private string loginId;
        public MenuAdministrador(string email)
        {
            loginId = email;
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            CrearUsuario nuevoUsuario = new CrearUsuario(loginId);
            parent.Controls.Clear();
            parent.Controls.Add(nuevoUsuario);
        }

        private void btnCrearEquipo_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            CrearEquipo nuevoEquipo = new CrearEquipo(loginId);
            parent.Controls.Clear();
            parent.Controls.Add(nuevoEquipo);
        }

        private void btnCrearPizarron_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            CrearPizarron nuevoPizarron = new CrearPizarron(loginId);
            parent.Controls.Clear();
            parent.Controls.Add(nuevoPizarron);
        }

        private void btnVerPizarrón_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            VisualizarPizarron verPizarron = new VisualizarPizarron(loginId);
            parent.Controls.Clear();
            parent.Controls.Add(verPizarron);
        }

        private void btnInformePizarron_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            InformePizarronesPorEquipo nuevoInformePizarron = new InformePizarronesPorEquipo(loginId);
            parent.Controls.Clear();
            parent.Controls.Add(nuevoInformePizarron);
        }

        private void btnInformeComentario_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            InformeComentariosPorUsuario nuevoInformeComentario = new InformeComentariosPorUsuario(loginId);
            parent.Controls.Clear();
            parent.Controls.Add(nuevoInformeComentario);
        }
    }
}
