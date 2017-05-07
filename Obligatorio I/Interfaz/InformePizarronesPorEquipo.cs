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
    public partial class InformePizarronesPorEquipo : UserControl
    {
        private Usuario usuarioLogueado;
        public InformePizarronesPorEquipo(Usuario u)
        {
            usuarioLogueado = u;
            InitializeComponent();
        }

        private void InformePizarronesPorEquipo_Load(object sender, EventArgs e)
        {

        }

    }
}
