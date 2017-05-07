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
    public partial class CrearEquipo : UserControl
    {
        private Usuario usuarioLogueado;

        public CrearEquipo(Usuario u)
        {
            usuarioLogueado = u;
            InitializeComponent();
            InicializarCombo();
        }

        public void InicializarCombo()
        {
            for (int i = 1; i <= 100; i++)
            {
                cmbCantMaxUsuarios.Items.Add(i);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string descripcion = rtxtDescripcion.Text;
                DateTime fechaCreacion = dateTimeFechaCreacion.Value;
                int cantMaxUsuarios = Int32.Parse(cmbCantMaxUsuarios.SelectedValue+"");
            }
        }
    }
}
