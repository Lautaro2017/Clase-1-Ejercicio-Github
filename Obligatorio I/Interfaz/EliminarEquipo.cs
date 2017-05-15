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
            lstPizarrones.Rows.Clear();
            lstPizarrones.ColumnCount = 3;
            lstPizarrones.Columns[0].Name = "Nombre";
            lstPizarrones.Columns[1].Name = "Descripcion";
            lstPizarrones.Columns[2].Name = "Fecha de creación";
            foreach (Equipo e in s.Equipos)
            {
                string nombre = e.Nombre;
                string descripcion = e.Descripcion;
                string fechaCreacion = e.FechaDeCreacion.ToString();
            }
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

        }
    }
}
