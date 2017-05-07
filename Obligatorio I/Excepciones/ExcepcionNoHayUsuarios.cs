using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionNoHayUsuarios : Exception
    {
        public ExcepcionNoHayUsuarios() : base("No se ingresaron usuarios en el sistema") { }
    }
}
