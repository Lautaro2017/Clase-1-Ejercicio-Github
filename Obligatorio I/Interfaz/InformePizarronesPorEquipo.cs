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
    public partial class InformePizarronesPorEquipo : UserControl
    {
        Sistema s = Sistema.GetInstance();
        private Usuario usuarioLogueado;

        public InformePizarronesPorEquipo(Usuario u)
        {
            usuarioLogueado = u;
            InitializeComponent();
            InicializarCombo();
        }

        public void InicializarCombo()
        {
            cmbEquipo.Items.AddRange(s.Equipos.ToArray());
            cmbEquipo.SelectedIndex = 0;
        }

        private void InformePizarronesPorEquipo_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Equipo equipo = (Equipo)cmbEquipo.SelectedItem;
            List<Pizarron> pizarrones = s.FiltroDePizarronesPorEquipo(equipo);
            DateTime fechaCreacion = dateTimeFechaCreacion.Value.Date;
            lstPizarrones.Rows.Clear();
            lstPizarrones.ColumnCount = 4;
            lstPizarrones.Columns[0].Name = "Equipo";
            lstPizarrones.Columns[1].Name = "Fecha de creación";
            lstPizarrones.Columns[2].Name = "Última modificación";
            lstPizarrones.Columns[3].Name = "Cantidad de elementos";
            foreach (Pizarron p in pizarrones)
            {
                if (p.FechaDeCreacion.Date == fechaCreacion)
                {
                    string equipoCreador = p.EquipoPerteneciente.Nombre;
                    string fechaDeCreacion = fechaCreacion.ToString();
                    string fechaMod = p.UltimaModificacion.ToString();
                    string cantElementos = p.Elementos.Count()+"";
                    string[] row = new String[4];
                    row[0] = equipoCreador;
                    row[1] = fechaDeCreacion;
                    row[2] = fechaMod;
                    row[3] = cantElementos;
                    lstPizarrones.Rows.Add(row);
                }
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
