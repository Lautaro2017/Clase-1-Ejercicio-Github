using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionCantidadMaxUsuarios:Exception
    {
        public ExcepcionCantidadMaxUsuarios() : base("Ya se ha ingresado la cantidad maxima de usuarios en el equipo!") { }
    }
}
