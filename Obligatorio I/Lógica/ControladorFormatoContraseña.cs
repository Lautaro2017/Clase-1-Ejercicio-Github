using Excepciones;
using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorFormatoContraseña
    {
        Validaciones validador = new Validaciones();

        public void FormatoContraseñaValido(string contraseña)
        {
            if (!validador.EsContraseñaValida(contraseña))
            {
                throw new ExcepcionFormatoContraseña();
            }
        }
    }
}
