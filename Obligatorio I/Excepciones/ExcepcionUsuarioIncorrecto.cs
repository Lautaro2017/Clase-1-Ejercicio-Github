using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionUsuarioIncorrecto : Exception
    {
        public ExcepcionUsuarioIncorrecto() : base("El usuario ingresado no existe!") { }
    }
}
