using Excepciones;
using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorUsuarioYaIngresado
    {
        Sistema s = Sistema.GetInstance();

        public void UsuarioYaIngresado(string email)
        {
            if (s.BuscarUsuarioPorMail(email) != null)
            {
                throw new ExcepcionUsuarioYaIngresado();
            }
        }
    }
}
