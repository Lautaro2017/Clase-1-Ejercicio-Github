using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionEquipoRepetido : Exception
    {
        public ExcepcionEquipoRepetido() : base("Ya existe un equipo con ese nombre!") { }
    }
}
