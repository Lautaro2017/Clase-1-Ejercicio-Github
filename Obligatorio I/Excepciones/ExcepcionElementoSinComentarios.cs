using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionElementoSinComentarios:Exception
    {
        public ExcepcionElementoSinComentarios():base("El elemento no contiene comentarios") { }
    }
}
