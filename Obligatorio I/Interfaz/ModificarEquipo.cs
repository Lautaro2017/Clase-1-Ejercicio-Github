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
    public partial class ModificarEquipo : UserControl
    {
        Sistema s = Sistema.GetInstance();
        private Usuario usuarioLogueado;
        private ControladorNombreEquipoVacio controlador1;
        private ControladorNombreEquipoRepetido controlador2;
        private Utilidades utilidad;
        Equipo equipoSeleccionado;

        public ModificarEquipo(Usuario u)
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
            List<Equipo> equipos = s.Equipos;
            cmbModificarEquipo.Items.AddRange(equipos.ToArray());
            cmbModificarEquipo.SelectedIndex = 0;
            for (int i = 1; i <= 100; i++)
            {
                cmbCantMaxUsuarios.Items.Add(i);
            }
            cmbCantMaxUsuarios.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string descripcion = rtxtDescripcion.Text;
                int cantMaxUsuarios = Int32.Parse(cmbCantMaxUsuarios.SelectedItem + "");
                controlador1.NombreEquipoVacio(nombre);
                Equipo equipo = new Equipo(nombre, descripcion, cantMaxUsuarios, new List<Usuario>());
                for (int i = 0; i < s.Equipos.Count; i++)
                {
                    if (equipoSeleccionado.Equals(s.Equipos[i]))
                    {
                        s.Equipos[i] = equipo;
                    }
                }
                Panel parent = this.Parent as Panel;
                parent.Controls.Clear();
                parent.Controls.Add(new MenuAdministrador(usuarioLogueado));
            }
            catch (ExcepcionNombreEquipoVacio ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbModificarEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            equipoSeleccionado = (Equipo)cmbModificarEquipo.SelectedItem;
            txtNombre.Text = equipoSeleccionado.Nombre;
            rtxtDescripcion.Text = equipoSeleccionado.Descripcion;
            cmbCantMaxUsuarios.SelectedItem = equipoSeleccionado.CantMaxUsuarios;
            dateTimeFechaCreacion.Value = equipoSeleccionado.FechaDeCreacion;            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuAdministrador ventana = new MenuAdministrador(usuarioLogueado);
            Panel parent = this.Parent as Panel;
            parent.Controls.Clear();
            parent.Controls.Add(ventana);
        }
    }
}
