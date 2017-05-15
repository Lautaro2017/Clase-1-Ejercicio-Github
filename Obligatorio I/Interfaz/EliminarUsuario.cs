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
    public partial class EliminarUsuario : UserControl
    {
        private Usuario usuarioLogueado;
        Sistema s = Sistema.GetInstance();

        public EliminarUsuario(Usuario u)
        {
            usuarioLogueado = u;
            InitializeComponent();
            InicializarLista();
        }

        public void InicializarLista()
        {
            lstUsuarios.Rows.Clear();
            lstUsuarios.ColumnCount = 3;
            lstUsuarios.Columns[0].Name = "Nombre";
            lstUsuarios.Columns[1].Name = "Apellido";
            lstUsuarios.Columns[2].Name = "Email";
            List<Usuario> usuarios = s.Usuarios;
            foreach (Usuario u in usuarios)
            {
                if (!u.EsAdministrador)
                {
                    string nombre = u.Nombre;
                    string apellido = u.Apellido;
                    string email = u.Email;
                    string[] row = new String[3];
                    row[0] = nombre;
                    row[1] = apellido;
                    row[2] = email;
                    lstUsuarios.Rows.Add(row);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuAdministrador ventana = new MenuAdministrador(usuarioLogueado);
            Panel parent = this.Parent as Panel;
            parent.Controls.Clear();
            parent.Controls.Add(ventana);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < lstUsuarios.SelectedRows.Count; index++)
            {
                var selectedRow = lstUsuarios.SelectedRows[index];
                string email = selectedRow.Cells["Email"].FormattedValue.ToString();
                Usuario u = s.BuscarUsuarioPorMail(email);
                s.EliminarUsuario(u);
            }
            MessageBox.Show("Cambios guardados");
            MenuAdministrador ventana = new MenuAdministrador(usuarioLogueado);
            Panel parent = this.Parent as Panel;
            parent.Controls.Clear();
            parent.Controls.Add(ventana);
        }
    }
}
