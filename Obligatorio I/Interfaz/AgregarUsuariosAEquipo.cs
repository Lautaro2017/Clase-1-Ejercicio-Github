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
    public partial class AgregarUsuariosAEquipo : UserControl
    {
        Sistema s = Sistema.GetInstance();
        private Usuario usuarioLogueado;
        private Equipo equipoAgregado;
        private List<Usuario> nuevosUsuarios;
        private List<Usuario> usuariosActuales;
        private ControladorCantidadMaxUsuarios controlador;
        private ControladorEquipoSinUsuarios controlador2;

        public AgregarUsuariosAEquipo(Usuario u,Equipo e)
        {
            usuarioLogueado = u;
            equipoAgregado = e;
            nuevosUsuarios = new List<Usuario>();
            usuariosActuales = new List<Usuario>();
            controlador = new ControladorCantidadMaxUsuarios();
            controlador2 = new ControladorEquipoSinUsuarios();
            InitializeComponent();
            InicializarCombo();
            RefrescarListas();
        }

        public void InicializarCombo()
        {
            cmbEquipos.Items.AddRange(s.Equipos.ToArray());
            if (equipoAgregado == null)
            {
                cmbEquipos.SelectedIndex = 0;
            }
            else
            {
                cmbEquipos.SelectedItem = equipoAgregado;
                cmbEquipos.Enabled = false;
            }
        }

        public void RefrescarListas()
        {
            lstUsuarioParaAgregar.Rows.Clear();
            lstUsuariosAgregados.Rows.Clear();
            InicializarListaUsuariosParaAgregar();
            InicializarListaUsuariosAgregados();
        }

        public void InicializarListaUsuariosParaAgregar()
        {
            Equipo equipo = (Equipo)cmbEquipos.SelectedItem;
            nuevosUsuarios = usuariosActuales == equipo.usuarios ? s.UsuariosNoAgregadosEnEquipo(equipo) : nuevosUsuarios;
            lstUsuarioParaAgregar.Rows.Clear();
            lstUsuarioParaAgregar.ColumnCount = 3;
            lstUsuarioParaAgregar.Columns[0].Name = "Nombre";
            lstUsuarioParaAgregar.Columns[1].Name = "Apellido";
            lstUsuarioParaAgregar.Columns[2].Name = "Email";
            foreach (Usuario u in nuevosUsuarios)
            {
                string nombre = u.Nombre;
                string apellido = u.Apellido;
                string email = u.Email;
                string[] row = new String[3];
                row[0] = nombre;
                row[1] = apellido;
                row[2] = email;
                lstUsuarioParaAgregar.Rows.Add(row);
            }
        }

        public void InicializarListaUsuariosAgregados()
        {
            Equipo equipo = (Equipo)cmbEquipos.SelectedItem;
            usuariosActuales = usuariosActuales == equipo.usuarios ? equipo.usuarios : usuariosActuales;
            lstUsuariosAgregados.Rows.Clear();
            lstUsuariosAgregados.ColumnCount = 3;
            lstUsuariosAgregados.Columns[0].Name = "Nombre";
            lstUsuariosAgregados.Columns[1].Name = "Apellido";
            lstUsuariosAgregados.Columns[2].Name = "Email";
            foreach (Usuario u in usuariosActuales)
            {
                string nombre = u.Nombre;
                string apellido = u.Apellido;
                string email = u.Email;
                string[] row = new String[3];
                row[0] = nombre;
                row[1] = apellido;
                row[2] = email;
                lstUsuariosAgregados.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuarios = new List<Usuario>(lstUsuarioParaAgregar.SelectedRows.Count);
            Equipo equipo = (Equipo)cmbEquipos.SelectedItem;
            for (int index = 0; index < lstUsuarioParaAgregar.SelectedRows.Count; index++)
            {
                var selectedRow = lstUsuarioParaAgregar.SelectedRows[index];
                string email = selectedRow.Cells["Email"].FormattedValue.ToString();
                Usuario usuario = s.BuscarUsuarioPorMail(email);
                nuevosUsuarios.Remove(usuario);
                usuariosActuales.Add(usuario);
            }            
            RefrescarListas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var usuarios = new List<Usuario>(lstUsuariosAgregados.SelectedRows.Count);
            Equipo equipo = (Equipo)cmbEquipos.SelectedValue;
            for (int index = 0; index < lstUsuariosAgregados.SelectedRows.Count; index++)
            {
                var selectedRow = lstUsuariosAgregados.SelectedRows[index];
                string email = selectedRow.Cells["Email"].FormattedValue.ToString();
                Usuario usuario = s.BuscarUsuarioPorMail(email);
                nuevosUsuarios.Add(usuario);
                usuariosActuales.Remove(usuario);
            }
            RefrescarListas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (equipoAgregado != null)
                {
                    controlador2.EquipoSinUsuarios(equipoAgregado);
                }                
                Panel parent = this.Parent as Panel;
                MenuAdministrador ventana = new MenuAdministrador(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(ventana);
            }
            catch(ExcepcionEquipoSinUsuarios ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {                
                Equipo equipo = (Equipo)cmbEquipos.SelectedItem;
                controlador.CantidadMaxUsuarios(equipo, usuariosActuales.Count);
                equipo.usuarios = usuariosActuales;
                if (equipoAgregado != null)
                {
                    controlador2.EquipoSinUsuarios(equipoAgregado);
                }
                MessageBox.Show("Se han guardado los cambios correctamente!");
                Panel parent = this.Parent as Panel;
                MenuAdministrador ventana = new MenuAdministrador(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(ventana);
            }
            catch(ExcepcionCantidadMaxUsuarios ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ExcepcionEquipoSinUsuarios ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Equipo equipo = (Equipo)cmbEquipos.SelectedItem;
            nuevosUsuarios = new List<Usuario>();
            usuariosActuales = new List<Usuario>();
            foreach (Usuario u in s.UsuariosNoAgregadosEnEquipo(equipo))
            {                
                nuevosUsuarios.Add(u);
            }
            foreach (Usuario u in equipo.usuarios)
            {                
                usuariosActuales.Add(u);
            }
            RefrescarListas();
        }
    }
}