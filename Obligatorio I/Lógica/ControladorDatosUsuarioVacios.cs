using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorDatosUsuarioVacios
    {
        public void DatosUsuarioVacios(string[]datos)
        {
            if (datos.Contains(""))
            {
                throw new ExcepcionDatosVacios();
            }
        }
    }
}
