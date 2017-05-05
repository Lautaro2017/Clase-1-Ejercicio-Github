using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionContraseñaIncorrecta : Exception
    {
        public ExcepcionContraseñaIncorrecta() : base("La contraseña no es correcta!") { }
    }
}
