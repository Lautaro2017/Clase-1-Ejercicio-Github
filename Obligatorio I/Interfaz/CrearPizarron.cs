using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lógica;
using Obligatorio_I;
using Excepciones;

namespace Interfaz
{
    public partial class CrearPizarron : UserControl
    {
        private ControladorNombrePizarronVacio controlador1;
        private ControladorNombrePizarronRepetido controlador2;
        private ControladorValorNumerico controlador3;
        private Usuario usuarioLogueado;
        private Sistema sistema = Sistema.GetInstance();

        public CrearPizarron(Usuario u)
        {
            usuarioLogueado = u;
            controlador1 = new ControladorNombrePizarronVacio();
            controlador2 = new ControladorNombrePizarronRepetido();
            controlador3 = new ControladorValorNumerico();
            InitializeComponent();
        }

        private void cmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CrearPizarron_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Panel parent = this.Parent as Panel;
                Equipo equipo = (Equipo)cmbEquipo.SelectedItem;
                string nombre = txtNombre.Text;
                string alto = txtAlto.Text;
                string ancho = txtAncho.Text;
                string descripcion = txtDescripcion.Text;
                controlador1.NombrePizarronVacio(nombre);
                controlador2.NombrePizarronRepetido(nombre,equipo);
                controlador3.EsValorNumerico(alto);
                controlador3.EsValorNumerico(ancho);
                Pizarron nuevoPizarron = new Pizarron(nombre, equipo, descripcion, Int32.Parse(alto), Int32.Parse(ancho), usuarioLogueado);
                sistema.AgregarPizarron(nuevoPizarron);
                MessageBox.Show("Pizarrón guardado!");
                MenuUsuario nuevoMenuUsuario = new MenuUsuario(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(nuevoMenuUsuario);
            }
            catch(ExcepcionNombrePizarronVacio e1)
            {
                MessageBox.Show(e1.Message);
            }
            catch(ExcepcionPizarronRepetido e2)
            {
                MessageBox.Show(e2.Message);
            }
            catch(ExcepcionAnchoYAltoPizarron e3)
            {
                MessageBox.Show(e3.Message);
            }
        }
    }
}