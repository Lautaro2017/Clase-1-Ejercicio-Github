using Excepciones;
using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public class ControladorEquipoSinUsuarios
    {
        public void EquipoSinUsuarios(Equipo e)
        {
            if (e.usuarios.Count == 0)
            {
                throw new ExcepcionEquipoSinUsuarios();
            }
        }
    }
}
