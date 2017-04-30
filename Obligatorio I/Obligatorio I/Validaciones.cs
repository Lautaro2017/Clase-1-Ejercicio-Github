using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_I
{
    public class Validaciones
    {
        public bool EsContraseñaValida(string contraseña)
        {
            bool largoCorrecto = contraseña.Length >= 8;
            if (largoCorrecto)
            {
                bool esAlfaNumerico = false;
                bool tieneNro = false;
                bool tieneLetra = false;
                for (int i = 0; !esAlfaNumerico && i < contraseña.Length; i++)
                {
                    if (char.IsNumber(contraseña[i]))
                    {
                        tieneNro = true;
                        if (tieneLetra)
                        {
                            return true;
                        }
                    }
                    if (char.IsLetter(contraseña[i]))
                    {
                        tieneLetra = true;
                        if (tieneNro)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }

    public bool EsEmailValido(string email)
    {

    }
}
