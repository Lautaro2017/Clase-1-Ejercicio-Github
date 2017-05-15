using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorCambiosPendientesDeSalvar
    {
        public void CambiosPendientesDeSalvar(bool datosSalvados)
        {
            if (!datosSalvados)
            {
                throw new ExcepcionCambiosPendientes();
            }
        }
    }
}
