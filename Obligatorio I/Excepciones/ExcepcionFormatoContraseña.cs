using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionFormatoContraseña : Exception
    {
        public ExcepcionFormatoContraseña() : base("El formato de la contraseña no es válido!") { }
    }
}
