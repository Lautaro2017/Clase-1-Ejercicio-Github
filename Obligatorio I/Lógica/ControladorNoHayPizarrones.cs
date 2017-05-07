using Excepciones;
using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorNoHayPizarrones
    {
        Sistema s = Sistema.GetInstance();

        public void NoHayPizarrones()
        {
            if (s.Pizarrones.Count == 0)
            {
                throw new ExcepcionNoHayPizarrones();
            }
        }
    }
}
