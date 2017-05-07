using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionUsuarioSinEquipo : Exception
    {
        public ExcepcionUsuarioSinEquipo() : base("El usuario no está asignado a ningún equipo!") { }
    }
}
