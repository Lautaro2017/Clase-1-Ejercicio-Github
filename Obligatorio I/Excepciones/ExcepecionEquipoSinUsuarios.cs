using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepecionEquipoSinUsuarios : Exception
    {
        public ExcepecionEquipoSinUsuarios() : base("El equipo debe tener al menos un usuario") { }
    }
}
