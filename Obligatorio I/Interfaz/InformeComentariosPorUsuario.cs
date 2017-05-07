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
    public partial class InformeComentariosPorUsuario : UserControl
    {
        private Usuario usuarioLogueado;
        public InformeComentariosPorUsuario(Usuario u)
        {
            usuarioLogueado = u;
            InitializeComponent();
        }

    }
}
