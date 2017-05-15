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
    public partial class EliminarPizarron : UserControl
    {
        Sistema s = Sistema.GetInstance();
        private Usuario usuarioLogueado;

        public EliminarPizarron(Usuario u)
        {
            usuarioLogueado = u;            
            InitializeComponent();
            InicializarLista();
        }

        public void InicializarLista()
        {            
            lstPizarrones.Rows.Clear();
            lstPizarrones.ColumnCount = 2;
            lstPizarrones.Columns[0].Name = "Nombre";
            lstPizarrones.Columns[1].Name = "Equipo";
            if (usuarioLogueado.EsAdministrador)
            {
                List<Pizarron> pizarrones = s.Pizarrones;
                foreach (Pizarron p in pizarrones)
                {
                    string nombre = p.Nombre;
                    string equipoCreador = p.EquipoPerteneciente.Nombre;
                    string[] row = new String[2];
                    row[0] = nombre;
                    row[1] = equipoCreador;
                    lstPizarrones.Rows.Add(row);
                }
            }
            else
            {
                List<Pizarron> pizarrones = s.PizarronesDondeUsuarioEsCreador(usuarioLogueado);
                foreach (Pizarron p in pizarrones)
                {
                    string nombre = p.Nombre;
                    string equipoCreador = p.EquipoPerteneciente.Nombre;
                    string[] row = new String[2];
                    row[0] = nombre;
                    row[1] = equipoCreador;
                    lstPizarrones.Rows.Add(row);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<PizarronDeEquipo> pizarrones = new List<PizarronDeEquipo>();
            var usuarios = new List<PizarronDeEquipo>(lstPizarrones.SelectedRows.Count);
            for (int index = 0; index < lstPizarrones.SelectedRows.Count; index++)
            {
                var selectedRow = lstPizarrones.SelectedRows[index];
                string nombre = selectedRow.Cells["Nombre"].FormattedValue.ToString();
                string equipo = selectedRow.Cells["Equipo"].FormattedValue.ToString();
                Pizarron p = s.BuscarPizarronPorNombreYEquipo(nombre, equipo);
                s.EliminarPizarron(p);
            }
            MessageBox.Show("Cambios guardados");
            if (usuarioLogueado.EsAdministrador)
            {
                MenuAdministrador ventana = new MenuAdministrador(usuarioLogueado);
                Panel parent = this.Parent as Panel;
                parent.Controls.Clear();
                parent.Controls.Add(ventana);
            }
            else
            {
                MenuUsuario ventana = new MenuUsuario(usuarioLogueado);
                Panel parent = this.Parent as Panel;
                parent.Controls.Clear();
                parent.Controls.Add(ventana);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (usuarioLogueado.EsAdministrador)
            {
                MenuAdministrador ventana = new MenuAdministrador(usuarioLogueado);
                Panel parent = this.Parent as Panel;
                parent.Controls.Clear();
                parent.Controls.Add(ventana);
            }
            else
            {
                MenuUsuario ventana = new MenuUsuario(usuarioLogueado);
                Panel parent = this.Parent as Panel;
                parent.Controls.Clear();
                parent.Controls.Add(ventana);
            }
        }
    }
}
