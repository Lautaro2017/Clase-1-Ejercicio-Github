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
    public partial class VisualizarPizarron : UserControl
    {
        Sistema s = Sistema.GetInstance();
        private Usuario usuarioLogueado;
        private ControladorEquipoSinPizarrones controlador1;

        public VisualizarPizarron(Usuario u)
        {
            usuarioLogueado = u;
            controlador1 = new ControladorEquipoSinPizarrones();
            InitializeComponent();
            InicializarCombos();
        }

        public void InicializarCombos()
        {
            cmbEquipo.Items.AddRange(s.Equipos.ToArray());
            cmbEquipo.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPizarron_Load(object sender, EventArgs e)
        {

        }

        private void VisualizarPizarron_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Equipo equipo = (Equipo)cmbEquipo.SelectedItem;
                cmbPizarron.Items.AddRange(s.FiltroDePizarronesPorEquipo(equipo).ToArray());                
            }
            catch(ExcepcionEquipoSinPizarrones ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPizarron_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pizarron p = (Pizarron)cmbPizarron.SelectedItem;
            tableLayoutPizarron.Width = p.Ancho;
            tableLayoutPizarron.Height = p.Alto;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            parent.Controls.Clear();
            MenuAdministrador nuevoMenuAdmin = new MenuAdministrador(usuarioLogueado);
            parent.Controls.Add(nuevoMenuAdmin);

        }
    }
}
