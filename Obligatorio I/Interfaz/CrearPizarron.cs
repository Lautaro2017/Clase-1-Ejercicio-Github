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

        public CrearPizarron(string email)
        {
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
                Equipo equipo = (Equipo)cmbEquipo.SelectedItem;
                string nombre = txtNombre.Text;
                string alto = txtAlto.Text;
                string ancho = txtAncho.Text;
                string descripcion = txtDescripcion.Text;
                controlador1.NombrePizarronVacio(nombre);
                controlador2.NombrePizarronRepetido(nombre,equipo);
                controlador3.EsValorNumerico(alto);
                controlador3.EsValorNumerico(ancho);
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