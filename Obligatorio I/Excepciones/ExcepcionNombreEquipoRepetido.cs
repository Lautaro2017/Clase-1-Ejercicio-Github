﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionNombreEquipoRepetido : Exception
    {
        public ExcepcionNombreEquipoRepetido() : base("El nombre ingresado ya existe para un equipo") { }
    }
}
