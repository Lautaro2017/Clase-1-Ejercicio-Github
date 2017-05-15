using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionEquipoSinUsuarios : Exception
    {
        public ExcepcionEquipoSinUsuarios() : base("El equipo debe tener al menos un usuario") { }
    }
}
