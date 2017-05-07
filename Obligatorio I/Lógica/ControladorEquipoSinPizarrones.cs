using Excepciones;
using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorEquipoSinPizarrones
    {
        Sistema s = Sistema.GetInstance();
        public void EquipoSinPizarrones(Equipo e)
        {
            if (s.FiltroDePizarronesPorEquipo(e).Count == 0)
            {
                throw new ExcepcionEquipoSinPizarrones();
            }
        }
    }
}
