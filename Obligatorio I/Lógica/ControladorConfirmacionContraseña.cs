using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorConfirmacionContraseña
    {
        public void ConfirmacionContraseña(string contraseña, string confirmacion)
        {
            if (contraseña != confirmacion)
            {
                throw new ExcepcionConfirmacionContraseña();
            }
        }
    }
}
