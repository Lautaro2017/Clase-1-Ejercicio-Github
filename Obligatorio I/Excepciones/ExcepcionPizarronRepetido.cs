using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionPizarronRepetido : Exception
    {
        public ExcepcionPizarronRepetido() : base("Ya existe un pizarrón con ese nombre para el equipo indicado!") { }
    }
}
