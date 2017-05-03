using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionPizarronSinEquipo : Exception
    {
        public ExcepcionPizarronSinEquipo() : base("Seleccione el equipo al que pertenece el pizarrón!") { }
    }
}
