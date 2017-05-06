using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionNombreEquipoVacio : Exception
    {
        public ExcepcionNombreEquipoVacio() : base("Debe elegir un nombre para el equipo!") { }
    }
}
