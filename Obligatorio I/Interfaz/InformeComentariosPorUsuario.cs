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
        Sistema s = Sistema.GetInstance();
        Utilidades u = new Utilidades();
        private Usuario usuarioLogueado;

        public InformeComentariosPorUsuario(Usuario u)
        {
            usuarioLogueado = u;
            InitializeComponent();
            InicializarCombos();
        }

        public void InicializarCombos()
        {
            cmbUsuarioCreador.Items.AddRange(s.Usuarios.ToArray());
            cmbUsuarioQueResuelve.Items.AddRange(s.Usuarios.ToArray());
            cmbUsuarioCreador.SelectedIndex = -1;
            cmbUsuarioQueResuelve.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario creador = cmbUsuarioCreador.SelectedIndex != -1 ? (Usuario)cmbUsuarioCreador.SelectedItem : null;
            Usuario resolvedor = cmbUsuarioQueResuelve.SelectedIndex != -1 ? (Usuario)cmbUsuarioQueResuelve.SelectedItem : null;
            DateTime fechaCreacion = dateTimeFechaCreacion.Value;
            DateTime fechaResuelto = dateTimeFechaResuelto.Value;            
            lstComentarios.Rows.Clear();
            lstComentarios.ColumnCount = 5;
            lstComentarios.Columns[0].Name = "Fecha de creación";
            lstComentarios.Columns[1].Name = "Usuario creador";
            lstComentarios.Columns[2].Name = "Usuario que resuelve";
            lstComentarios.Columns[3].Name = "Pizarron";
            lstComentarios.Columns[4].Name = "Fecha de resuelto";
            List<Comentario> comentarios = new List<Comentario>();       
            foreach (Pizarron p in s.Pizarrones)
            {
                foreach (Elemento el in p.Elementos)
                {
                    if (creador == null && resolvedor == null)
                    {
                        if (comentarios.Count == 0)
                        {
                            comentarios = u.FiltrarComentariosPorFechaDeCreacion(el.Comentarios, fechaCreacion)
                                                        .Intersect(u.FiltrarComentariosPorFechaDeResolucion(el.Comentarios, fechaResuelto)).ToList();
                        }
                        else
                        {
                            comentarios.AddRange(u.FiltrarComentariosPorFechaDeCreacion(el.Comentarios, fechaCreacion)
                                                        .Intersect(u.FiltrarComentariosPorFechaDeResolucion(el.Comentarios, fechaResuelto)).ToList());
                        }                        
                    }
                    if (creador == null)
                    {
                        if (comentarios.Count == 0)
                        {
                            comentarios = u.FiltrarComentariosPorFechaDeCreacion(el.Comentarios, fechaCreacion)
                                                        .Intersect(u.FiltrarComentariosPorFechaDeResolucion(el.Comentarios, fechaResuelto)).ToList()
                                                        .Intersect(u.FiltrarComentariosPorUsuarioResolutor(el.Comentarios, resolvedor)).ToList();
                        }
                        else
                        {
                            comentarios.AddRange(u.FiltrarComentariosPorFechaDeCreacion(el.Comentarios, fechaCreacion)
                                                        .Intersect(u.FiltrarComentariosPorFechaDeResolucion(el.Comentarios, fechaResuelto)).ToList()
                                                        .Intersect(u.FiltrarComentariosPorUsuarioResolutor(el.Comentarios, resolvedor)).ToList());
                        }
                    }
                    if (resolvedor == null)
                    {
                        if (comentarios.Count == 0)
                        {
                            comentarios = u.FiltrarComentariosPorFechaDeCreacion(el.Comentarios, fechaCreacion)
                                                        .Intersect(u.FiltrarComentariosPorFechaDeResolucion(el.Comentarios, fechaResuelto)).ToList()
                                                        .Intersect(u.FiltrarComentariosPorUsuarioCreador(el.Comentarios, creador)).ToList();
                        }
                        else
                        {
                            comentarios.AddRange(u.FiltrarComentariosPorFechaDeCreacion(el.Comentarios, fechaCreacion)
                                                        .Intersect(u.FiltrarComentariosPorFechaDeResolucion(el.Comentarios, fechaResuelto)).ToList()
                                                        .Intersect(u.FiltrarComentariosPorUsuarioCreador(el.Comentarios, creador)).ToList());
                        }
                    }
                    if (resolvedor != null && creador != null)
                    {
                        if (comentarios.Count == 0)
                        {
                            comentarios = u.FiltrarComentariosPorFechaDeCreacion(el.Comentarios, fechaCreacion)
                                                        .Intersect(u.FiltrarComentariosPorFechaDeResolucion(el.Comentarios, fechaResuelto)).ToList()
                                                        .Intersect(u.FiltrarComentariosPorUsuarioCreador(el.Comentarios, creador)).ToList()
                                                        .Intersect(u.FiltrarComentariosPorUsuarioResolutor(el.Comentarios, resolvedor)).ToList();
                        }
                        else
                        {
                            comentarios.AddRange(u.FiltrarComentariosPorFechaDeCreacion(el.Comentarios, fechaCreacion)
                                                        .Intersect(u.FiltrarComentariosPorFechaDeResolucion(el.Comentarios, fechaResuelto)).ToList()
                                                        .Intersect(u.FiltrarComentariosPorUsuarioCreador(el.Comentarios, creador)).ToList()
                                                        .Intersect(u.FiltrarComentariosPorUsuarioResolutor(el.Comentarios, resolvedor)).ToList());
                        }
                    }
                }
            }
            foreach (Comentario c in comentarios)
            {                
                string fechaDeCreacion = c.FechaCreacion.ToString();
                string usuarioCreador = c.Creador.ToString();
                string usuarioQueResuelve = c.Resolutivo.ToString();
                string pizarron = c.PizarronContenedor.ToString();
                string fechaResolucion = c.FechaResolucion.ToString();
                string[] row = new string[5];
                row[0] = fechaDeCreacion;
                row[1] = usuarioCreador;
                row[2] = usuarioQueResuelve;
                row[3] = pizarron;
                row[4] = fechaResolucion;
                lstComentarios.Rows.Add(row);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuAdministrador nuevoMenuAdmin = new MenuAdministrador(usuarioLogueado);
            Panel parent = this.Parent as Panel;
            parent.Controls.Clear();
            parent.Controls.Add(nuevoMenuAdmin);
        }
    }
}
