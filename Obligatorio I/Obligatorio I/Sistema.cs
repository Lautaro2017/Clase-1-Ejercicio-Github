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
        public List<Elemento> Elementos { set; get; }

        public Sistema()
        {
            this.Usuarios = new List<Usuario>();
            this.Equipos = new List<Equipo>();
            this.Pizarrones = new List<Pizarron>();
            this.Elementos = new List<Elemento>();
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
            this.Elementos.Add(e);
        }

        public List<Comentario> FiltroComentarioPorFechaCreacion(DateTime fecha)
        {
            List<Comentario> comentarios = new List<Comentario>();
            foreach (Elemento e in this.Elementos)
            {
                foreach (Comentario c in e.Comentarios)
                {
                    if (c.FechaCreacion == fecha)
                    {
                        comentarios.Add(c);
                    }
                }
            }
            return comentarios;
        }

        public List<Comentario> FiltroComentarioPorFechaResolucion(DateTime fecha)
        {
            List<Comentario> comentarios = new List<Comentario>();
            foreach (Elemento e in this.Elementos)
            {
                foreach (Comentario c in e.Comentarios)
                {
                    if (c.FechaResolucion == fecha)
                    {
                        comentarios.Add(c);
                    }
                }
            }
            return comentarios;
        }

        public List<Comentario> FiltrarComentarioPorUsuarioResolutor(Usuario u)
        {
            List<Comentario> comentarios = new List<Comentario>();
            foreach (Elemento e in this.Elementos)
            {
                foreach (Comentario c in e.Comentarios)
                {
                    if (c.Resolutivo == u)
                    {
                        comentarios.Add(c);
                    }
                }
            }
            return comentarios;
        }

        public List<Comentario> FiltrarComentarioPorUsuarioCreador(Usuario u)
        {
            List<Comentario> comentarios = new List<Comentario>();
            foreach (Elemento e in this.Elementos)
            {
                foreach (Comentario c in e.Comentarios)
                {
                    if (c.Creador == u)
                    {
                        comentarios.Add(c);
                    }
                }
            }
            return comentarios;
        }

        public bool EmailCorrecto(string v)
        {
            throw new NotImplementedException();
        }

        public bool DatosDeUsuarioCorrectos(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}