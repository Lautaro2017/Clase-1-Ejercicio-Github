using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionComentarioVacio:Exception
    {
        public ExcepcionComentarioVacio():base("El comentario está vacío!") { }
    }
}
