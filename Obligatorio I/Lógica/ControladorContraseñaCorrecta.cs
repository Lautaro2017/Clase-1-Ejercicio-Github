using Excepciones;
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

        public void ContraseñaCorrectaOK(string email, string contraseña)
        {
            if (s.ContraseñaIncorrecta(email, contraseña))
            {
                throw new ExcepcionContraseñaIncorrecta();
            }
        }
    }
}
