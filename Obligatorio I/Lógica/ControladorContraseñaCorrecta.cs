using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorContraseñaCorrecta
    {
        Sistema s = Sistema.GetInstance();

        public bool ContraseñaCorrectaOK(string email, string contraseña)
        {
            if (!s.ContraseñaIncorrecta(email, contraseña))
            {
                return true;
            }
            return false;
        }
    }
}
