using Excepciones;
using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorCantidadMaxUsuarios
    {
        public void CantidadMaxUsuarios(Equipo e,int tamaño)
        {
            if (e.CantMaxUsuarios < tamaño)
            {
                throw new ExcepcionCantidadMaxUsuarios();
            }
        }
    }
}
