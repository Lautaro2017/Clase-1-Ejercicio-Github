using Excepciones;
using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorNombrePizarronVacio
    {
        public void NombrePizarronVacio(string nombre)
        {
            if (nombre == "")
            {
                throw new ExcepcionNombrePizarronVacio();
            }
        }
    }
}
