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
    public partial class PizarronDeEquipo : UserControl
    {
        public PizarronDeEquipo(List<Elemento>elementos,int alto,int ancho)
        {
            InitializeComponent();
            foreach (Elemento e in elementos)
            {
                if (e.Tipo == 'T')
                {
                    TextBox l = new TextBox();
                    l.Text = e.Contenido;
                    l.Location = new Point(e.PuntoOrigen.x, e.PuntoOrigen.y);
                    this.Controls.Add(l);
                }
                else
                {
                    PictureBox imagen = new PictureBox();
                    imagen.Size = new Size(e.Ancho,e.Alto);
                    imagen.Load(e.Contenido);
                    imagen.Location = new Point(e.PuntoOrigen.x, e.PuntoOrigen.y);
                    this.Controls.Add(imagen);
                }                
            }
            this.Width = ancho;
            this.Height = alto;
            this.BackColor = Color.White;
                        
        }
    }
}
