using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionDatosVacios : Exception
    {
        public ExcepcionDatosVacios() : base("Hay datos obligatorios vacíos") { }
        public ExcepcionDatosVacios(string message) : base(message) { }
    }
}
