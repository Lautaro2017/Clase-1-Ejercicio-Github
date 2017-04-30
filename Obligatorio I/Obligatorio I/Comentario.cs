using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_I
{
    public class Comentario
    {
        public DateTime FechaCreacion { set; get; }
        public DateTime FechaResolucion { set; get; }
        public Usuario Creador { set; get; }
        public Usuario Resolutivo { set; get; }
        public Pizarron PizarronContenedor { set; get; }

        public Comentario()
        {
            this.FechaCreacion = DateTime.Now;
            this.FechaResolucion = DateTime.MinValue;
        }

        public Comentario(DateTime nuevaFechaResolucion, Usuario nuevoCreador, Usuario nuevoResolutivo, Pizarron nuevoPizarron)
        {
            this.FechaCreacion = DateTime.Now;
            this.FechaResolucion = nuevaFechaResolucion;
            this.Creador = nuevoCreador;
            this.Resolutivo = nuevoResolutivo;
            this.PizarronContenedor = nuevoPizarron;
        }
    }
}
