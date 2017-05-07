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
        }

        public void InicializarCombo()
        {
            foreach (Equipo e in s.Equipos)
            {
                cmbEquipo.Items.Add(e.Nombre);
            }
            cmbEquipo.SelectedIndex = 0;
        }

        private void InformePizarronesPorEquipo_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Equipo equipo = (Equipo)cmbEquipo.SelectedItem;
            List<Pizarron> pizarrones = s.FiltroDePizarronesPorEquipo(equipo);
            DateTime fechaCreacion = dateTimeFechaCreacion.Value;
            foreach (Pizarron p in pizarrones)
            {
                if (p.FechaDeCreacion == fechaCreacion)
                {
                    string equipoCreador = p.EquipoPerteneciente.Nombre;
                    string fechaDeCreacion = fechaCreacion.ToString();
                    string fechaMod = p.UltimaModificacion.ToString();
                    string cantElementos = p.Elementos.Count()+"";
                    lstPizarrones.Items.Add(equipoCreador + fechaDeCreacion + fechaMod + cantElementos);
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
