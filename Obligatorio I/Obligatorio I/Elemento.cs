using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_I
{
    public class Elemento
    {
        public char Tipo { set; get; }  //Cuadro de texto (T) o Imagen (I)
        public int Alto { set; get; }
        public int Ancho { set; get; }
        public List<Comentario> Comentarios { set; get; }

        public struct Point
        {
            public int x;
            public int y;

            public Point(int coordX, int coordY)
            {
                this.x = coordX;
                this.y = coordY;
            }
        }

        public Point PuntoOrigen { set; get; }
        
        //Si el tipo es T se usan estas variables
        public int TamañoFuente { set; get; }
        public string TipoFuente { set; get; }
        //Si el tipo es T se guarda el texto, si es I se guarda el path del archivo
        public string Contenido { set; get; }
        public Pizarron PizarronContenedor { set; get; }

        public Elemento(char nuevoTipo, int nuevaAltura, int nuevaAnchura, List<Comentario> nuevosComentarios, Point nuevoPuntoOrigen, Pizarron nuevoPizarron)
        {

            this.Tipo = nuevoTipo;
            this.Alto = nuevaAltura;
            this.Ancho = nuevaAnchura;
            this.Comentarios = nuevosComentarios;
            this.PuntoOrigen = nuevoPuntoOrigen;
            this.PizarronContenedor = nuevoPizarron;
            this.TamañoFuente = 0;
            this.TipoFuente = "Arial";
            this.Contenido = "";
        }

        public override bool Equals(object obj)
        {
            var item = obj as Elemento;

            if (item == null)
            {
                return false;
            }

            return this.PizarronContenedor.Equals(item.PizarronContenedor) && this.Tipo.Equals(item.Tipo)
                && this.TamañoFuente.Equals(item.TamañoFuente) && this.TipoFuente.Equals(item.TipoFuente)
                && this.Contenido.Equals(item.Contenido);
        }

        public void AgregarComentario(Comentario c)
        {
            this.Comentarios.Add(c);
        }
    }
}