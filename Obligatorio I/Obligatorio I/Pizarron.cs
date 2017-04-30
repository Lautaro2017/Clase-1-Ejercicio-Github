using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_I
{
    public class Pizarron
    {
        public string Nombre { set; get; }
        public Equipo EquipoPerteneciente { set; get; }
        public string Descripcion { set; get; }
        public int Alto { set; get; }
        public int Ancho { set; get; }

        public Usuario Creador { set; get; }
        public List<Elemento> Elementos { set; get; }
        public DateTime FechaDeCreacion { set; get; }
        public DateTime UltimaModificacion { set; get; }

        public Pizarron()
        {
            this.Nombre = "";
            this.Elementos = new List<Elemento>();
        }

        public Pizarron(string nuevoNombre, Equipo unEquipo, string nuevaDescripcion, int nuevaAltura, int nuevaAnchura, Usuario nuevoCreador)
        {
            this.Nombre = nuevoNombre;
            this.EquipoPerteneciente = unEquipo;
            this.Descripcion = nuevaDescripcion;
            this.Alto = nuevaAltura;
            this.Ancho = nuevaAnchura;
            this.Creador = nuevoCreador;
            this.Elementos = new List<Elemento>();
            this.FechaDeCreacion = DateTime.Now;
            this.UltimaModificacion = DateTime.Now;
        }

        public void AgregarElemento(Elemento e)
        {
            this.Elementos.Add(e);
        }
    }
}
