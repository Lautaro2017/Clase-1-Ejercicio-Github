﻿using Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecutable
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void menuOpcionIniciarSesion_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new IniciarSesion());
      
        }
        private void menuOpcionAcercaDePlanilla_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(new AcercaDePlanilla());
        }

        private void menuOpcionSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
