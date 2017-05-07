using Excepciones;
using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorFormatoEmail
    {
        Validaciones v = new Validaciones();
        public void ControladorEmail(string email)
        {
            if (!v.EsEmailValido(email))
            {
                throw new ExcepcionEmail();
            }
        }
    }
}
