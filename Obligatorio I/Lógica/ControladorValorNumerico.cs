using Excepciones;
using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorValorNumerico
    {
        Validaciones validador = new Validaciones();
        public void EsValorNumerico(string valor)
        {
            if (String.IsNullOrWhiteSpace(valor))
            {
                throw new ExcepcionAnchoYAltoPizarron();
            }
            if (!validador.EsNumero(valor))
            {
                throw new ExcepcionAnchoYAltoPizarron("Revise los valores ingresado en el alto y ancho del pizarrón!");
            }
        }
    }
}
