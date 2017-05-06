using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_I
{
    public class Sistema
    {
        public List<Usuario> Usuarios { set; get; }
        public List<Equipo> Equipos { set; get; }
        public List<Pizarron> Pizarrones { set; get; }

        public Sistema()
        {
            this.Usuarios = new List<Usuario>();
            this.Equipos = new List<Equipo>();
            this.Pizarrones = new List<Pizarron>();
        }

        public void AgregarUsuario(Usuario u)
        {
            bool yaExiste = this.Usuarios.Contains(u);

            if (!yaExiste)
            {
                this.Usuarios.Add(u);
            }            
        }

        public void AgregarEquipo(Equipo e)
        {
            bool yaExiste = this.Equipos.Contains(e);
            if (!yaExiste)
            {
                this.Equipos.Add(e);
            }
        }

        public void AgregarPizarron(Pizarron p)
        {
            this.Pizarrones.Add(p);
        }

        public List<Pizarron> FiltroPizarronesPorFechaMod(DateTime fecha)
        {
            List<Pizarron> pizarron = new List<Pizarron>();
            foreach (Pizarron p in this.Pizarrones)
            {
                if (p.FechaDeCreacion == fecha)
                {
                    pizarron.Add(p);
                }
            }
            return pizarron;
        }

        public List<Pizarron> FiltroDePizarronesPorEquipo(Equipo equipo)
        {
            List<Pizarron> pizarron = new List<Pizarron>();
            foreach (Pizarron p in this.Pizarrones)
            {
                if (p.EquipoPerteneciente == equipo)
                {
                    pizarron.Add(p);
                }
            }
            return pizarron;
        }

        public void EliminarPizarron(Pizarron unPizarron)
        {
            foreach (Pizarron p in this.Pizarrones)
            {
                if (p == unPizarron)
                {
                    this.Pizarrones.Remove(unPizarron);
                    return;
                }
            }
        }

        public void AgregarElemento(Elemento e)
        {
            throw new NotImplementedException();
        }

        public List<Comentario> FiltroComentarioPorFechaCreacion(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public List<Comentario> FiltroComentarioPorFechaResolucion(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public List<Comentario> FiltrarComentarioPorUsuarioResolutor(Usuario u2)
        {
            throw new NotImplementedException();
        }

        public List<Comentario> FiltrarComentarioPorUsuarioCreador(Usuario u2)
        {
            throw new NotImplementedException();
        }
    }
}
