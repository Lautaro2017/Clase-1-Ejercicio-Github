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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Interfaz
{
    public partial class VisualizarPizarron : UserControl
    {
        Sistema s = Sistema.GetInstance();
        private Usuario usuarioLogueado;
        private PizarronDeEquipo pizarronEnUso;
        private Pizarron pizarron;
        private ControladorEquipoSinPizarrones controlador1;
        private ControladorCambiosPendientesDeSalvar controlador2;
        private int posMouseFormX, posMouseFormY;
        private int posMouseElemX, posMouseElemY;
        private int posActElemX, posActElemY;
        private List<Elemento> elementos;
        Elemento elementoEnUso;
        int cantElementos;
        bool elementoPresionado = false;
        bool datosSalvados = true;
        bool allowResize = false;

        public VisualizarPizarron(Usuario u)
        {
            usuarioLogueado = u;
            controlador1 = new ControladorEquipoSinPizarrones();
            controlador2 = new ControladorCambiosPendientesDeSalvar();
            elementos = new List<Elemento>();
            InitializeComponent();
            InicializarCombos();
        }

        public void InicializarCombos()
        {
            if (usuarioLogueado.EsAdministrador)
            {
                cmbEquipo.Items.AddRange(s.Equipos.ToArray());
                cmbEquipo.SelectedIndex = 0;
            }
            else
            {
                cmbEquipo.Items.AddRange(s.EquiposDeUsuario(usuarioLogueado).ToArray());
                cmbEquipo.SelectedIndex = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPizarron_Load(object sender, EventArgs e)
        {

        }

        private void VisualizarPizarron_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Equipo equipo = (Equipo)cmbEquipo.SelectedItem;
                controlador1.EquipoSinPizarrones(equipo);
                cmbPizarron.Controls.Clear();
                cmbPizarron.Items.AddRange(s.FiltroDePizarronesPorEquipo(equipo).ToArray());
                cmbPizarron.SelectedIndex = 0;
                btnCargarImagen.Enabled = true;
                btnCargarCuadroTexto.Enabled = true;
            }
            catch(ExcepcionEquipoSinPizarrones ex)
            {
                MessageBox.Show(ex.Message);
                btnCargarImagen.Enabled = false;
                btnCargarCuadroTexto.Enabled = false;
                if (pnlPizarron.Controls != null)
                {
                    pnlPizarron.Controls.Clear();                    
                }
                if (cmbPizarron.Items.Count != 0)
                {
                    cmbPizarron.SelectedIndex = -1;
                    cmbPizarron.Items.Clear();
                }
            }
        }

        private void cmbPizarron_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPizarron.SelectedIndex != -1)
            {
                pnlPizarron.Controls.Clear();
                Pizarron p = (Pizarron)cmbPizarron.SelectedItem;
                rtxtDescripcion.Text = p.Descripcion;
                elementos = new List<Elemento>();
                foreach (Elemento elem in p.Elementos)
                {
                    elementos.Add(elem);
                }
                cantElementos = p.Elementos.Count;
                this.pizarron = p;
                PizarronDeEquipo pizarronDeEquipo = new PizarronDeEquipo(p.Elementos, p.Alto, p.Ancho);
                pnlPizarron.Controls.Add(pizarronDeEquipo);
                pizarronDeEquipo.Location = new Point(
                pnlPizarron.ClientSize.Width / 2 - pnlPizarron.Size.Width / 2,
                pnlPizarron.ClientSize.Height / 2 - pnlPizarron.Size.Height / 2);
                pnlPizarron.Anchor = AnchorStyles.None;
                pnlPizarron.BackColor = Color.Transparent;
                pizarron = s.Pizarrones.Where(piz => piz.Equals(pizarron)).First();
                pizarronEnUso = pizarronDeEquipo;
                foreach (Control caja in pizarronDeEquipo.Controls)
                {
                    if (caja is PictureBox)
                    {
                        caja.MouseMove += Cuadro_MouseMove;
                        caja.MouseDown += Cuadro_MouseDown;
                        caja.MouseUp += Cuadro_MouseUp;                        
                    }
                    if (caja is TextBox)
                    {
                        caja.MouseMove += CuadroDeTexto_MouseMove;
                        caja.MouseDown += CuadroDeTexto_MouseDown;
                        caja.MouseUp += CuadroDeTexto_MouseUp;
                    }
                    caja.Click += Cuadro_Click;
                    PictureBox mover = new PictureBox();
                    mover.Width = 5;
                    mover.Height = 5;
                    mover.Cursor = Cursors.SizeNWSE;
                    mover.Anchor = AnchorStyles.Bottom;
                    mover.Anchor = AnchorStyles.Right;
                    caja.Controls.Add(mover);
                    mover.Location = new Point(caja.Width - 5, caja.Height - 5);
                    mover.MouseMove += Mover_MouseMove;
                    mover.MouseDown += Mover_MouseDown;
                    mover.MouseUp += Mover_MouseUp;
                }
                foreach (Control c in pizarronEnUso.Controls)
                {
                    c.DoubleClick += Caja_DoubleClick;
                }
            }
        }

        private void Caja_DoubleClick(object sender, EventArgs e)
        {
            if (datosSalvados)
            {
                if (sender is PictureBox)
                {
                    foreach (Elemento el in elementos)
                    {
                        PictureBox img = (PictureBox)sender;
                        if (el.Contenido == img.ImageLocation && el.PizarronContenedor == pizarron)
                        {
                            elementoEnUso = el;
                        }
                    }
                }
                else
                {
                    foreach (Elemento el in elementos)
                    {
                        TextBox text = (TextBox)sender;
                        if (el.Contenido == text.Text && el.PizarronContenedor == pizarron)
                        {
                            elementoEnUso = el;
                        }
                    }
                }
                Panel parent = this.Parent as Panel;
                ComentarioDeElemento verComentarios = new ComentarioDeElemento(elementoEnUso, usuarioLogueado);
                if (parent != null)
                {
                    parent.Controls.Clear();
                    parent.Controls.Add(verComentarios);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (Elemento el in elementos)
            {
                for (int i = 0; i < pizarron.Elementos.Count; i++)
                {
                    if (pizarron.Elementos[i].Equals(el))
                    {
                        pizarron.Elementos[i].Alto = el.Alto;
                        pizarron.Elementos[i].Ancho = el.Ancho;
                        pizarron.Elementos[i].PuntoOrigen = el.PuntoOrigen;
                        pizarron.Elementos[i].Contenido = el.Contenido;
                    }
                }
                pizarron.AgregarElemento(el);
            }
            datosSalvados = true;
            MessageBox.Show("Datos salvados!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Panel parent = this.Parent as Panel;
            parent.Controls.Clear();
            if (usuarioLogueado.EsAdministrador)
            {
                MenuAdministrador nuevoMenuAdmin = new MenuAdministrador(usuarioLogueado);
                parent.Controls.Add(nuevoMenuAdmin);
            }
            else
            {
                MenuUsuario nuevoMenuUsuario = new MenuUsuario(usuarioLogueado);
                parent.Controls.Add(nuevoMenuUsuario);
            }                     

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;                    
                    PictureBox cuadro = new PictureBox();
                    PictureBox mover = new PictureBox();
                    mover.Width = 5;
                    mover.Height = 5;
                    cuadro.ImageLocation = imagen;
                    cuadro.SizeMode = PictureBoxSizeMode.StretchImage;
                    cuadro.MouseMove += Cuadro_MouseMove;
                    cuadro.MouseDown += Cuadro_MouseDown;
                    cuadro.MouseUp += Cuadro_MouseUp;
                    cuadro.SizeMode = PictureBoxSizeMode.Normal;
                    mover.Cursor = Cursors.SizeNWSE;
                    mover.Anchor = AnchorStyles.Bottom;
                    mover.Anchor = AnchorStyles.Right;                    
                    cuadro.Controls.Add(mover);
                    mover.Location = new Point(cuadro.Width-5, cuadro.Height-5);
                    mover.MouseMove += Mover_MouseMove;
                    mover.MouseDown += Mover_MouseDown;
                    mover.MouseUp += Mover_MouseUp;
                    cuadro.Click += Cuadro_Click;
                    pizarronEnUso.Controls.Add(cuadro);
                    Elemento.Point coord = new Elemento.Point(posActElemX, posActElemY);
                    Elemento el = new Elemento('I', cuadro.Height, cuadro.Width, new List<Comentario>(), coord, pizarron);
                    el.Contenido = imagen;
                    elementos.Add(el);
                    cuadro.MouseDoubleClick += Caja_DoubleClick;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void Cuadro_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                if (sender is PictureBox)
                {                    
                    for (int i = 0; i < elementos.Count;i++)
                    {
                        if (elementos[i].Contenido == ((PictureBox)sender).ImageLocation)
                        {
                            if (pizarron.Elementos.Contains(elementos[i]))
                            {
                                pizarron.Elementos.Remove(elementos[i]);
                            }
                            elementos.Remove(elementos[i]);
                            i--;
                        }
                    }
                    pizarronEnUso.Controls.Remove((PictureBox)sender);
                }
                else
                {                    
                    for (int i = 0; i < elementos.Count; i++)
                    {
                        if (elementos[i].Contenido == ((TextBox)sender).Text)
                        {
                            if (pizarron.Elementos.Contains(elementos[i]))
                            {
                                pizarron.Elementos.Remove(elementos[i]);
                            }
                            elementos.Remove(pizarron.Elementos[i]);
                            i--;
                        }
                    }
                    pizarronEnUso.Controls.Remove((TextBox)sender);
                }
            }
        }

        private void Mover_MouseUp(object sender, MouseEventArgs e)
        {
            allowResize = false;
        }

        private void Mover_MouseDown(object sender, MouseEventArgs e)
        {
            allowResize = true;
        }

        private void Mover_MouseMove(object sender, MouseEventArgs e)
        {
            if (allowResize)
            {
                if (sender is PictureBox)
                {
                    ((PictureBox)sender).Parent.Height = ((PictureBox)sender).Top + e.Y;
                    ((PictureBox)sender).Parent.Width = ((PictureBox)sender).Left + e.X;
                    ((PictureBox)sender).Location = new Point(((PictureBox)sender).Parent.Width - 5, ((PictureBox)sender).Parent.Height - 5);
                }
                else
                {
                    ((TextBox)sender).Parent.Height = ((TextBox)sender).Top + e.Y;
                    ((TextBox)sender).Parent.Width = ((TextBox)sender).Left + e.X;
                    ((TextBox)sender).Location = new Point(((TextBox)sender).Parent.Width - 5, ((TextBox)sender).Parent.Height - 5);
                }
            }            
        }

        private void Cuadro_MouseUp(object sender, MouseEventArgs e)
        {
            elementoPresionado = false;
        }

        private void Cuadro_MouseDown(object sender, MouseEventArgs e)
        {
            posMouseElemX = e.Location.X;
            posMouseElemY = e.Location.Y;
            elementoPresionado = true;
        }

        private void MoverPictureBox(PictureBox caja)
        {
            caja.Location = new System.Drawing.Point(posMouseFormX - posMouseElemX, posMouseFormY - posMouseElemY);
            posActElemX = caja.Location.X;
            posActElemY = caja.Location.Y;            
            Elemento.Point coord = new Elemento.Point(posActElemX, posActElemY);            
            Elemento e = new Elemento('I', caja.Height, caja.Width, new List<Comentario>(), coord,pizarron);
            e.Contenido = caja.ImageLocation;
            bool yaIncluido = false;            
            for (int i = 0; !yaIncluido && i < elementos.Count; i++)
            {
                if (elementos[i].Equals(e))
                {
                    e.Comentarios = elementos[i].Comentarios;
                    elementos[i] = e;
                    yaIncluido = true;
                }
            }
            if (!yaIncluido)
            {
                elementos.Insert(cantElementos, e);
            }
            datosSalvados = false;
        }

        private void Cuadro_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = posActElemX + e.Location.X;
            posMouseFormY = posActElemY + e.Location.Y;
            if (elementoPresionado)
            {
                MoverPictureBox((PictureBox)sender);
            }
        }

        private void btnCargarCuadroTexto_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox cuadroDeTexto = new TextBox();
                PictureBox mover = new PictureBox();
                cuadroDeTexto.Width = 100;
                cuadroDeTexto.Height = 30;
                mover.Width = 5;
                mover.Height = 5;
                cuadroDeTexto.Text = "Escriba aqui...";
                cuadroDeTexto.MouseMove += CuadroDeTexto_MouseMove;
                cuadroDeTexto.MouseDown += CuadroDeTexto_MouseDown;
                cuadroDeTexto.MouseUp += CuadroDeTexto_MouseUp;
                mover.Cursor = Cursors.SizeNWSE;
                mover.Anchor = AnchorStyles.Bottom;
                mover.Anchor = AnchorStyles.Right;
                cuadroDeTexto.Controls.Add(mover);
                mover.Location = new Point(cuadroDeTexto.Width - 5, cuadroDeTexto.Height - 5);
                mover.MouseMove += Mover_MouseMove;
                mover.MouseDown += Mover_MouseDown;
                mover.MouseUp += Mover_MouseUp;
                Elemento.Point coord = new Elemento.Point(posActElemX, posActElemY);
                Elemento el = new Elemento('T', cuadroDeTexto.Height, cuadroDeTexto.Width, new List<Comentario>(), coord, pizarron);
                el.Contenido = cuadroDeTexto.Text;
                elementos.Add(el);
                cuadroDeTexto.MouseDoubleClick += Caja_DoubleClick;
                pizarronEnUso.Controls.Add(cuadroDeTexto);
            }
            catch (Exception exc)
            {
                MessageBox.Show("ERROR!");
            }
        }


        private void CuadroDeTexto_MouseUp(object sender, MouseEventArgs e)
        {
            elementoPresionado = false;
        }

        private void VisualizarPizarron_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = posActElemX + e.Location.X;
            posMouseFormY = posActElemY + e.Location.Y;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            cantElementos = this.pizarron.Elementos.Count == 0 ? 0 : this.pizarron.Elementos.Count-1;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream("C:/CrearPDF.pdf", FileMode.Create));
                doc.Open();
                Paragraph p1 = new Paragraph("Documento PDF de Pizarrón");
                doc.Add(p1);

                Graphics myGraphics = this.CreateGraphics();
                Size s = this.Size;
                Bitmap memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
                Graphics memoryGraphics = Graphics.FromImage(memoryImage);

                this.Parent.Location = new Point(0, 0);
                this.FindForm().Location = new Point(0, 0);
                memoryGraphics.CopyFromScreen(0, 0, 0, 0, memoryImage.Size);


                System.Drawing.Image img = memoryImage;
                img.Save("C:/img.png");

                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("C:/img.png");
                doc.Add(PNG);
                doc.Close();
                MessageBox.Show("Se crea el documento PDF correctamente! ver archivo en c:/");
            }
            catch(ExcepcionImprimirPizarron ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MoverTextBox(TextBox caja)
        {
            caja.Location = new System.Drawing.Point(posMouseFormX - posMouseElemX, posMouseFormY - posMouseElemY);
            posActElemX = caja.Location.X;
            posActElemY = caja.Location.Y;
            Elemento.Point coord = new Elemento.Point(posActElemX, posActElemY);
            Elemento e = new Elemento('T', caja.Height, caja.Width, new List<Comentario>(), coord, pizarron);
            e.Contenido = caja.Text;
            bool yaIncluido = false;
            for (int i = 0; !yaIncluido && i < elementos.Count; i++)
            {
                if (elementos[i].Equals(e))
                {
                    e.Comentarios = elementos[i].Comentarios;
                    elementos[i] = e;
                    yaIncluido = true;
                }
            }
            if (!yaIncluido)
            {
                elementos.Insert(cantElementos, e);
            }
            datosSalvados = false;
        }

        private void CuadroDeTexto_MouseDown(object sender, MouseEventArgs e)
        {
            posMouseElemX = e.Location.X;
            posMouseElemY = e.Location.Y;
            elementoPresionado = true;
        }

        private void CuadroDeTexto_MouseMove(object sender, MouseEventArgs e)
        {
            posMouseFormX = posActElemX + e.Location.X;
            posMouseFormY = posActElemY + e.Location.Y;
            if (elementoPresionado)
            {
                MoverTextBox((TextBox)sender);
            }
        }
    }
}
