using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_I
{
    public class Utilidades
    {
        public Usuario NuevoUsuarioVacio()
        {
            Usuario u = new Usuario();
            return u;
        }

        public Usuario NuevoUsuario()
        {
            Usuario u = new Usuario("Lautaro", "Gutierrez", "lautarogutierrez4@gmail.com", new DateTime(1994, 1, 2), "lautaro1994", false);
            return u;
        }

        public Usuario OtroUsuario()
        {
            Usuario u = new Usuario("Marcelo", "Mancini", "manchiny24@hotmail.com", new DateTime(1990, 9, 24), "manchiny24", false);
            return u;
        }

        public Equipo NuevoEquipo()
        {
            Usuario u = this.NuevoUsuario();
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(u);
            Equipo e = new Equipo("Equipo Rocket", "Gestión de gastos", 3, usuarios);
            return e;
        }

        public bool IngresoDeUsuarioValido(Usuario u, List<Usuario> usuarios)
        {
            return !usuarios.Contains(u);
        }

        public Equipo NuevoEquipoSinUsuarios()
        {
            Equipo e = new Equipo("Equipo Rocket", "Gestión de gastos", 3, new List<Usuario>());
            return e;
        }

        public Pizarron NuevoPizarronVacio()
        {
            Pizarron p = new Pizarron();
            return p;
        }

        public bool IngresoDeEquipoValido(Equipo e, List<Equipo> equipos)
        {
            return !equipos.Contains(e);
        }

        public Pizarron NuevoPizarron()
        {
            Equipo e = this.NuevoEquipo();
            Usuario u = this.NuevoUsuario();
            Pizarron p = new Pizarron("Gastos varios", e, "Gestión de gastos varios", 120, 240, u);
            return p;
        }

        public Elemento NuevoElemento()
        {
            Comentario c1 = this.NuevoComentario();
            List<Comentario> comentarios = new List<Comentario>();
            comentarios.Add(c1);
            Pizarron p = this.NuevoPizarron();
            Elemento.Point origen = new Elemento.Point(23, 33);
            Elemento e = new Elemento('T', 122, 233, comentarios, origen, p);
            return e;
        }

        public Comentario NuevoComentario()
        {
            Usuario u1 = this.NuevoUsuario();
            Usuario u2 = this.OtroUsuario();
            Pizarron p = this.NuevoPizarron();
            Comentario c = new Comentario(new DateTime(2017, 4, 29), u1, u2, p);
            return c;
        }
        
        public string GenerarContraseña()
        {
            string guid = Guid.NewGuid().ToString();
            string contraseña = "";
            bool ok = true;
            for (int i = 0; ok && i < guid.ToString().Length; i++)
            {                
                if (guid[i] == '-')
                {
                    ok = false;
                }
                else
                {
                    contraseña += guid[i];
                }
            }
            return contraseña;
        }

        public bool PizarronValido(Pizarron p, List<Pizarron> pizarrones)
        {
            return !pizarrones.Contains(p);
        }

        public List<Comentario> FiltrarComentariosPorUsuarioResolutor(List<Comentario> comentarios, Usuario u)
        {
            List<Comentario> nuevaLista = new List<Comentario>();
            foreach (Comentario c in comentarios)
            {
                if (c.Resolutivo.Equals(u))
                {
                    nuevaLista.Add(c);
                }
            }
            return nuevaLista;
        }

        public List<Comentario> FiltrarComentariosPorUsuarioCreador(List<Comentario> comentarios, Usuario u)
        {
            List<Comentario> nuevaLista = new List<Comentario>();
            foreach (Comentario c in comentarios)
            {
                if (c.Creador.Equals(u))
                {
                    nuevaLista.Add(c);
                }
            }
            return nuevaLista;
        }

        public List<Comentario> FiltrarComentariosPorFechaDeCreacion(List<Comentario> comentarios, DateTime fecha)
        {
            List<Comentario> nuevaLista = new List<Comentario>();
            foreach (Comentario c in comentarios)
            {
                if (c.FechaCreacion.Equals(fecha))
                {
                    nuevaLista.Add(c);
                }
            }
            return nuevaLista;
        }

        public List<Comentario> FiltrarComentariosPorFechaDeResolucion(List<Comentario> comentarios, DateTime fecha)
        {
            List<Comentario> nuevaLista = new List<Comentario>();
            foreach (Comentario c in comentarios)
            {
                if (c.FechaResolucion.Equals(fecha))
                {
                    nuevaLista.Add(c);
                }
            }
            return nuevaLista;
        }
    }
}