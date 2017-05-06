﻿using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorInicioSesion
    {
        Sistema s = Sistema.GetInstance();

        public bool IniciarSesionOK(string email,string contraseña)
        {
            if (s.DatosDeUsuarioCorrectos(email, contraseña))
            {
                return true;
            }
            return false;
        }
    }
}
