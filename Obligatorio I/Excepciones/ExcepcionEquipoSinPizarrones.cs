using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionEquipoSinPizarrones : Exception
    {
        public ExcepcionEquipoSinPizarrones() : base("El equipo seleccionado no tiene pizarrones") { }
    }
}
