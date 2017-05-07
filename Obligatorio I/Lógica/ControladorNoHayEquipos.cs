using Excepciones;
using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorNoHayEquipos
    {
        Sistema s = Sistema.GetInstance();
        public void NoHayEquipos()
        {
            if (s.Equipos.Count == 0)
            {
                throw new ExcepcionNoHayEquipos();
            }
        }
    }
}
