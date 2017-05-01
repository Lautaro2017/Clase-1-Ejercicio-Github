using System;
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
    public partial class CrearPizarron : UserControl
    {
        public CrearPizarron()
        {
            InitializeComponent();
        }

        private void cmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CrearPizarron_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
