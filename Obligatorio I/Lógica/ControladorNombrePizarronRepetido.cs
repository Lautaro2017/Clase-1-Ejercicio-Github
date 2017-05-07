using Excepciones;
using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{    
    public class ControladorNombrePizarronRepetido
    {
        Sistema s = Sistema.GetInstance();

        public void NombrePizarronRepetido(string nombre, Equipo e)
        {
            if (s.NombrePizarronRepetido(nombre, e))
            {
                throw new ExcepcionPizarronRepetido();
            }
        }
    }
}
