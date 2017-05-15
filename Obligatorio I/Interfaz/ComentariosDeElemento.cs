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
    public partial class ComentariosDeElemento : UserControl
    {
        private Elemento elemento;
        private Usuario usuarioLogueado;
        Sistema s = Sistema.GetInstance();
        public ComentariosDeElemento(Elemento e,Usuario u)
        {
            elemento = e;
            usuarioLogueado = u;
            InitializeComponent();
            InicializarLista();
        }

        public void InicializarLista()
        {
            lstComentarios.Rows.Clear();
            lstComentarios.ColumnCount = 5;
            lstComentarios.Columns[0].Name = "Comentario";
            lstComentarios.Columns[1].Name = "Fecha de creación";
            lstComentarios.Columns[2].Name = "Fecha de resolución";
            lstComentarios.Columns[3].Name = "Creador";
            lstComentarios.Columns[4].Name = "Resolutor";
            foreach (Comentario c in elemento.Comentarios)
            {
                string comentario = c.contenido;
                string fechaDeCreacion = c.FechaCreacion.ToString();
                string fechaResolucion = c.FechaResolucion != DateTime.MinValue ? c.FechaResolucion.ToString() : "No resuelto aún";
                string creador = c.Creador.Email;
                string resolutor = c.Resolutivo != null ? c.Resolutivo.Email : "No resuelto aún";
                string[] row = new String[5];
                row[0] = comentario;
                row[1] = fechaDeCreacion;
                row[2] = fechaResolucion;
                row[3] = creador;
                row[4] = resolutor;
                lstComentarios.Rows.Add(row);
            }
            btnResolver.Enabled = false;
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            var selectedRow = lstComentarios.SelectedRows[0];
            string creador = selectedRow.Cells["Creador"].FormattedValue.ToString();
            string fechaCreacion = selectedRow.Cells["Fecha de creación"].FormattedValue.ToString();
            Usuario usuario = s.BuscarUsuarioPorMail(creador);
            DateTime fecha = DateTime.Parse(fechaCreacion);
            Comentario resuelto = s.BuscarComentarioPorUsuarioYFecha(usuario, fecha);
            resuelto.Resolutivo = new Usuario();
            resuelto.Resolutivo = usuarioLogueado;
            resuelto.FechaResolucion = DateTime.Now;
            MessageBox.Show("Comentario resuelto!");
            InicializarLista();
        }

        private void lstComentarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            parent.Controls.Clear();
            ComentarioDeElemento nuevoMenuComentario = new ComentarioDeElemento(elemento,usuarioLogueado);
            parent.Controls.Add(nuevoMenuComentario);
        }

        private void lstComentarios_SelectionChanged(object sender, EventArgs e)
        {
            if (lstComentarios.SelectedRows.Count != 0)
            {
                var selectedRow = lstComentarios.SelectedRows[0];
                string fechaResolucion = selectedRow.Cells["Fecha de resolución"].FormattedValue.ToString();
                if (fechaResolucion == "No resuelto aún")
                {
                    btnResolver.Enabled = true;
                }
                else
                {
                    btnResolver.Enabled = false;
                }
            }
        }
    }
}
