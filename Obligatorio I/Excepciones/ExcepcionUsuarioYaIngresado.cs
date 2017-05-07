using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionUsuarioYaIngresado:Exception
    {
        public ExcepcionUsuarioYaIngresado() : base("El usuario ya fue ingresado!") { }
    }
}
