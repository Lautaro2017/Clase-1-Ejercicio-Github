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
            this.Elementos = new List<Elemento>();
            this.FechaDeCreacion = DateTime.Now;
            this.UltimaModificacion = DateTime.Now;
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

        public bool SeAgregaElemento(Elemento e, Pizarron p)
        {
            if (p.Alto > e.Alto + e.PuntoOrigen.y)
            {
                return false;
            }

            if (p.Ancho > e.Ancho + e.PuntoOrigen.x)
            {
                return false;
            }

            return true;
        }

        public void AgregarElemento(Elemento e)
        {
            if (!this.Elementos.Contains(e))
            {
                this.Elementos.Add(e);
            }            
        }
        
        public override bool Equals(object obj)
        {
            var item = obj as Pizarron;

            if (item == null)
            {
                return false;
            }

            if (item.EquipoPerteneciente == null && this.EquipoPerteneciente == null)
            {
                return (item.Nombre == null && this.Nombre == null);
            }

            if (item.Nombre == null && this.Nombre == null)
            {
                return (item.EquipoPerteneciente == null && this.EquipoPerteneciente == null);
            }

            return this.EquipoPerteneciente.Equals(item.EquipoPerteneciente)
                && this.Nombre.Equals(item.Nombre);
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
