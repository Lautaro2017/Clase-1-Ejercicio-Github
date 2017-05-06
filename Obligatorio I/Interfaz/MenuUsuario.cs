﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MenuUsuario : UserControl
    {
        public MenuUsuario(string email)
        {
            InitializeComponent();
        }

        private void btnCrearPizarron_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            CrearPizarron nuevoPizarron = new CrearPizarron();
            parent.Controls.Clear();
            parent.Controls.Add(nuevoPizarron);
        }

        private void btnVerPizarrón_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            VisualizarPizarron verPizarron = new VisualizarPizarron();
            parent.Controls.Clear();
            parent.Controls.Add(verPizarron);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
