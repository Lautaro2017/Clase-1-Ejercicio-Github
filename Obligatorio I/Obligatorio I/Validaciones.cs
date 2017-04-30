using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public bool EsEmailValido(string email)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(email))
                return true;
            else
                return false;
        }

        public bool ElTextoEsVacio(string texto)
        {
            return texto.Length == 0;
        }

        public bool EsNumero(string texto)
        {
            int i = 0;
            return int.TryParse(texto, out i);
        }
    }
}
