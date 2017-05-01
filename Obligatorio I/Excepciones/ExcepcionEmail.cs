using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionEmail : Exception
    {
        public ExcepcionEmail() : base("El formato de e-mail no es valido") { }
    }
}
