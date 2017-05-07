using Excepciones;
using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorNoHayUsuarios
    {
        Sistema s = Sistema.GetInstance();
        public void NoHayUsuarios()
        {
            if (s.Usuarios.Count == 0)
            {
                throw new ExcepcionNoHayUsuarios();
            }
        }
    }
}
