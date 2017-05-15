using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionCambiosPendientes:Exception
    {
        public ExcepcionCambiosPendientes():base("Hay cambios pendientes de ser salvados") { }
    }
}
