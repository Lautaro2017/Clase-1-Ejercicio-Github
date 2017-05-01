using Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecutable
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void menuOpcionIniciarSesion_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            IniciarSesion nuevaSesion = new IniciarSesion();
            parent.Controls.Clear();
            parent.Controls.Add(nuevaSesion);
        }

        private void menuOpcionAcercaDePlanilla_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            AcercaDePlanilla nuevaAcercaDePlanilla = new AcercaDePlanilla();
            parent.Controls.Clear();
            parent.Controls.Add(nuevaAcercaDePlanilla);
        }

        private void menuOpcionSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
