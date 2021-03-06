﻿using System;
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
    public partial class MenuAdministrador : UserControl
    {
        private Usuario usuarioLogueado;
        private ControladorNoHayEquipos controlador1;
        private ControladorNoHayUsuarios controlador2;
        private ControladorNoHayPizarrones controlador3;
        private ControladorNoHayUsuarios controlador4;

        public MenuAdministrador(Usuario u)
        {
            usuarioLogueado = u;
            controlador1 = new ControladorNoHayEquipos();
            controlador2 = new ControladorNoHayUsuarios();
            controlador3 = new ControladorNoHayPizarrones();
            controlador4 = new ControladorNoHayUsuarios();
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            CrearUsuario nuevoUsuario = new CrearUsuario(usuarioLogueado);
            parent.Controls.Clear();
            parent.Controls.Add(nuevoUsuario);
        }

        private void btnCrearEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                controlador2.NoHayUsuarios();
                Panel parent = this.Parent as Panel;
                CrearEquipo nuevoEquipo = new CrearEquipo(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(nuevoEquipo);
            }
            catch (ExcepcionNoHayUsuarios ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrearPizarron_Click(object sender, EventArgs e)
        {
            try
            {
                controlador1.NoHayEquipos();
                Panel parent = this.Parent as Panel;
                CrearPizarron nuevoPizarron = new CrearPizarron(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(nuevoPizarron);
            }
            catch(ExcepcionNoHayEquipos ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerPizarrón_Click(object sender, EventArgs e)
        {
            try
            {
                controlador3.NoHayPizarrones();
                Panel parent = this.Parent as Panel;
                VisualizarPizarron verPizarron = new VisualizarPizarron(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(verPizarron);
            }
            catch (ExcepcionNoHayPizarrones ex)
            {
                MessageBox.Show(ex.Message);
            }                        
        }

        private void btnInformePizarron_Click(object sender, EventArgs e)
        {
            try
            {
                controlador1.NoHayEquipos();
                Panel parent = this.Parent as Panel;
                InformePizarronesPorEquipo nuevoPizarron = new InformePizarronesPorEquipo(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(nuevoPizarron);
            }
            catch (ExcepcionNoHayEquipos ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInformeComentario_Click(object sender, EventArgs e)
        {
            try
            {
                controlador2.NoHayUsuarios();
                Panel parent = this.Parent as Panel;
                InformeComentariosPorUsuario nuevoInformeComentario = new InformeComentariosPorUsuario(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(nuevoInformeComentario);
            }
            catch(ExcepcionNoHayUsuarios ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                controlador1.NoHayEquipos();
                Panel parent = this.Parent as Panel;
                AgregarUsuariosAEquipo ventana = new AgregarUsuariosAEquipo(usuarioLogueado,null);
                parent.Controls.Clear();
                parent.Controls.Add(ventana);
            }
            catch (ExcepcionNoHayEquipos ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarPizarron_Click(object sender, EventArgs e)
        {
            try
            {
                controlador3.NoHayPizarrones();
                Panel parent = this.Parent as Panel;
                EliminarPizarron ventana = new EliminarPizarron(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(ventana);
            }
            catch (ExcepcionNoHayPizarrones ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                controlador4.NoHayUsuarios();
                Panel parent = this.Parent as Panel;
                EliminarUsuario ventana = new EliminarUsuario(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(ventana);
            }
            catch (ExcepcionNoHayUsuarios ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controlador1.NoHayEquipos();
                Panel parent = this.Parent as Panel;
                EliminarEquipo ventana = new EliminarEquipo(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(ventana);
            }
            catch (ExcepcionNoHayEquipos ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                controlador4.NoHayUsuarios();
                Panel parent = this.Parent as Panel;
                ModificarUsuario ventana = new ModificarUsuario(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(ventana);
            }
            catch (ExcepcionNoHayUsuarios ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                controlador1.NoHayEquipos();
                Panel parent = this.Parent as Panel;
                ModificarEquipo ventana = new ModificarEquipo(usuarioLogueado);
                parent.Controls.Clear();
                parent.Controls.Add(ventana);
            }
            catch (ExcepcionNoHayEquipos ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
