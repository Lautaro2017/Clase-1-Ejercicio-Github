using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionNoHayEquipos : Exception
    {
        public ExcepcionNoHayEquipos() : base("No se han ingresado equipos en el sistema") { }
    }
}
