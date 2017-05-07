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
        private Usuario usuarioLogueado;

        public InformeComentariosPorUsuario(Usuario u)
        {
            usuarioLogueado = u;
            InitializeComponent();
        }

        public void InicializarCombos()
        {
            cmbUsuarioCreador.Items.AddRange(s.Usuarios.ToArray());
            cmbUsuarioQueResuelve.Items.AddRange(s.Usuarios.ToArray());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario creador = (Usuario)cmbUsuarioCreador.SelectedItem;
            Usuario resolvedor = (Usuario)cmbUsuarioQueResuelve.SelectedItem;
            DateTime fechaCreacion = dateTimeFechaCreacion.Value.Date;
            DateTime fechaResuelto = dateTimeFechaResuelto.Value.Date;            
            lstComentarios.Rows.Clear();
            lstComentarios.ColumnCount = 4;
            lstComentarios.Columns[0].Name = "Fecha de creación";
            lstComentarios.Columns[1].Name = "Usuario creador";
            lstComentarios.Columns[2].Name = "Usuario que resuelve";
            lstComentarios.Columns[3].Name = "Pizarron";
            lstComentarios.Columns[4].Name = "Fecha de resuelto";
            foreach (Pizarron p in pizarrones)
            {
                if (p.FechaDeCreacion.Date == fechaCreacion)
                {
                    string equipoCreador = p.EquipoPerteneciente.Nombre;
                    string fechaDeCreacion = fechaCreacion.ToString();
                    string fechaMod = p.UltimaModificacion.ToString();
                    string cantElementos = p.Elementos.Count() + "";
                    string[] row = new String[4];
                    row[0] = equipoCreador;
                    row[1] = fechaDeCreacion;
                    row[2] = fechaMod;
                    row[3] = cantElementos;
                    lstComentarios.Rows.Add(row);
                }
            }
        }
    }
}
