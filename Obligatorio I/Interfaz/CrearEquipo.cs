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
    public partial class CrearEquipo : UserControl
    {
        Sistema s = Sistema.GetInstance();
        private Usuario usuarioLogueado;        
        private ControladorNombreEquipoVacio controlador1;
        private ControladorNombreEquipoRepetido controlador2;
        private Utilidades utilidad;

        public CrearEquipo(Usuario u)
        {
            usuarioLogueado = u;
            controlador1 = new ControladorNombreEquipoVacio();
            controlador2 = new ControladorNombreEquipoRepetido();
            utilidad = new Utilidades();
            InitializeComponent();
            InicializarCombo();
        }

        public void InicializarCombo()
        {
            for (int i = 1; i <= 100; i++)
            {
                cmbCantMaxUsuarios.Items.Add(i);
            }
            cmbCantMaxUsuarios.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            parent.Controls.Clear();
            if (usuarioLogueado.EsAdministrador)
            {
                parent.Controls.Add(new MenuAdministrador(usuarioLogueado));
            }
            else
            {
                parent.Controls.Add(new MenuUsuario(usuarioLogueado));
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string descripcion = rtxtDescripcion.Text;
                int cantMaxUsuarios = Int32.Parse(cmbCantMaxUsuarios.SelectedItem+"");
                controlador1.NombreEquipoVacio(nombre);
                controlador2.NombreEquipoRepetido(nombre);
                Equipo equipo = new Equipo(nombre, descripcion, cantMaxUsuarios, new List<Usuario>());
                s.AgregarEquipo(equipo);
                Panel parent = this.Parent as Panel;
                parent.Controls.Clear();
                if (usuarioLogueado.EsAdministrador)
                {
                    parent.Controls.Add(new MenuAdministrador(usuarioLogueado));
                }
                else
                {
                    parent.Controls.Add(new MenuUsuario(usuarioLogueado));
                }

            }
            catch(ExcepcionNombreEquipoVacio ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ExcepcionNombreEquipoRepetido ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            AgregarUsuariosAEquipo ventana = new AgregarUsuariosAEquipo(usuarioLogueado);
            Panel parent = this.Parent as Panel;
            parent.Controls.Clear();
            parent.Controls.Add(ventana);
        }
    }
}
