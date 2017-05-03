using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionConfirmacionContraseña : Exception
    {
        public ExcepcionConfirmacionContraseña() : base("La confirmación de contraseña no coincide con la original!") { }
    }
}
