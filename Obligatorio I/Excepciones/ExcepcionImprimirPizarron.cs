using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionImprimirPizarron : Exception
    {
        public ExcepcionImprimirPizarron() : base("No se puede general el archivo PDF de pizarrón") { }
        public ExcepcionImprimirPizarron(string message) : base(message) { }
    }
}
