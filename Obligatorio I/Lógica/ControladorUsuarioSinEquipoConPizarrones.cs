using Excepciones;
using Obligatorio_I;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ControladorUsuarioSinEquipoConPizarrones
    {
        Sistema s = Sistema.GetInstance();
        public void UsuarioSinEquipoConPizarrones(Usuario u)
        {
            List<Equipo> equipos = s.EquiposDeUsuario(u);
            foreach (Pizarron p in s.Pizarrones)
            {
                foreach (Equipo e in equipos)
                {
                    if (p.EquipoPerteneciente == e)
                    {
                        return;
                    }
                }
            }
            throw new ExcepcionUsuarioSinEquipoConPizarrones();
        }
    }
}
