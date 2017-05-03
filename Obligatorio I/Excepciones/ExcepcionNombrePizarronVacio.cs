using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionNombrePizarronVacio : Exception
    {
        public ExcepcionNombrePizarronVacio() : base("Debe ingresar un nombre para el pizarrón!") { }
    }
}
