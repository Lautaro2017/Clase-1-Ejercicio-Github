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
    public partial class ComentarioDeElemento : UserControl
    {
        private Elemento elemento;
        private Usuario usuarioLogueado;
        private ControladorComentarioVacio controlador;
        private ControladorElementoSinComentarios controlador2;
        public ComentarioDeElemento(Elemento e, Usuario u)
        {
            elemento = e;
            controlador = new ControladorComentarioVacio();
            controlador2 = new ControladorElementoSinComentarios();
            usuarioLogueado = u;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string comentario = rtxtComentario.Text;
                controlador.ComentarioVacio(comentario);
                Comentario c = new Comentario(DateTime.MinValue,usuarioLogueado,null,elemento.PizarronContenedor);
                c.contenido = comentario;
                elemento.AgregarComentario(c);
                MessageBox.Show("Comentario guardado!");
            }            
            catch(ExcepcionComentarioVacio ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            parent.Controls.Clear();
            VisualizarPizarron nuevoMenuPizarron = new VisualizarPizarron(usuarioLogueado);
            parent.Controls.Add(nuevoMenuPizarron);
        }

        private void btnListaComentarios_Click(object sender, EventArgs e)
        {
            try
            {
                controlador2.ElementosSinComentarios(elemento);
                Panel parent = this.Parent as Panel;
                parent.Controls.Clear();
                ComentariosDeElemento nuevoMenuComentarios = new ComentariosDeElemento(elemento,usuarioLogueado);
                parent.Controls.Add(nuevoMenuComentarios);
            }
            catch(ExcepcionElementoSinComentarios ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
