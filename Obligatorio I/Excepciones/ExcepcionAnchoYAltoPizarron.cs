using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionAnchoYAltoPizarron : Exception
    {
        public ExcepcionAnchoYAltoPizarron() : base("El ancho y alto inicial del pizarrón son obligatorios") { }
        public ExcepcionAnchoYAltoPizarron(string message) : base(message) { }
    }
}
