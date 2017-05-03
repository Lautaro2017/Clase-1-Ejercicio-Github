using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionFechaDeNacimiento : Exception
    {
        public ExcepcionFechaDeNacimiento() : base("La fecha de nacimiento ingresada no es valida!") { }
    }
}
