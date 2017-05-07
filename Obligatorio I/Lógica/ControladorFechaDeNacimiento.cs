using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorFechaDeNacimiento
    {
        public void FechaDeNacimientoValida(DateTime fecha)
        {
            if (fecha >= DateTime.Now)
            {
                throw new ExcepcionFechaDeNacimiento();
            }
        }
    }
}
