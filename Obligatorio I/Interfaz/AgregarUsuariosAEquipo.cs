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
    public partial class AgregarUsuariosAEquipo : UserControl
    {
        Sistema s = Sistema.GetInstance();

        public AgregarUsuariosAEquipo()
        {
            InitializeComponent();
        }

        public void InicializarCombo()
        {
            cmbEquipos.Items.AddRange(s.Equipos.ToArray());
            cmbEquipos.SelectedIndex = 0;
        }

        public void InicializarListaUsuariosParaAgregar()
        {
        }
    }
}
