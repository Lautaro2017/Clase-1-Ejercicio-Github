using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorNombreEquipoVacio
    {
        public void NombreEquipoVacio(string nombre)
        {
            if (String.IsNullOrWhiteSpace(nombre))
            {
                throw new ExcepcionNombreEquipoVacio();
            }
        }
    }
}
