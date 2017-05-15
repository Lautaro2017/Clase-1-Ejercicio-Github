using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorComentarioVacio
    {
        public void ComentarioVacio(string comentario)
        {
            if (comentario.Length == 0)
            {
                throw new ExcepcionComentarioVacio();
            }
        }
    }
}
