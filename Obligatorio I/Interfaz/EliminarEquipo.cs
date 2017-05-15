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
    public partial class EliminarEquipo : UserControl
    {
        private Usuario usuarioLogueado;
        Sistema s = Sistema.GetInstance();

        public EliminarEquipo(Usuario u)
        {
            usuarioLogueado = u;
            InitializeComponent();
            InicializarLista();
        }

        public void InicializarLista()
        {
            lstEquipos.Rows.Clear();
            lstEquipos.ColumnCount = 3;
            lstEquipos.Columns[0].Name = "Nombre";
            lstEquipos.Columns[1].Name = "Descripcion";
            lstEquipos.Columns[2].Name = "Fecha de creación";
            foreach (Equipo e in s.Equipos)
            {
                string nombre = e.Nombre;
                string descripcion = e.Descripcion;
                string fechaCreacion = e.FechaDeCreacion.ToString();
                string[] row = new String[3];
                row[0] = nombre;
                row[1] = descripcion;
                row[2] = fechaCreacion;
                lstEquipos.Rows.Add(row);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < lstEquipos.SelectedRows.Count; index++)
            {
                var selectedRow = lstEquipos.SelectedRows[index];
                string nombre = selectedRow.Cells["Nombre"].FormattedValue.ToString();
                Equipo equipo = s.BuscarEquipoPorNombre(nombre);
                s.EliminarEquipo(equipo);
            }
            MessageBox.Show("Cambios guardados");
            MenuAdministrador ventana = new MenuAdministrador(usuarioLogueado);
            Panel parent = this.Parent as Panel;
            parent.Controls.Clear();
            parent.Controls.Add(ventana);
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
