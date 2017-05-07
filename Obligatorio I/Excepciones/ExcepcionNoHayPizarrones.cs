using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionNoHayPizarrones : Exception
    {
        public ExcepcionNoHayPizarrones() : base("No hay pizarrones ingresados en el sistema") { }
    }
}
