﻿using System;
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

        private static Sistema instance;
        private static object synclock = new object();
        public static Sistema GetInstance()
        {
            Utilidades ut = new Utilidades();
            Usuario u = ut.NuevoUsuario();
            Usuario u2 = ut.OtroUsuario();
            u2.Email = "admin";
            u2.Contraseña = "admin";
            Equipo e = ut.NuevoEquipo();
            u2.EsAdministrador = true;
            Pizarron p = ut.NuevoPizarron();
            p.Ancho = 200;
            p.Alto = 200;
            p.EquipoPerteneciente = e;
            if (instance == null)
            {
                lock (synclock)
                {
                    if (instance == null)
                    {                        
                        instance = new Sistema();
                        instance.AgregarUsuario(u);
                        instance.AgregarUsuario(u2);
                        instance.AgregarEquipo(e);
                        instance.AgregarPizarron(p);
                    }
                }
            }
            return instance;
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
            foreach (Pizarron p in this.Pizarrones)
            {
                foreach (Elemento e in p.Elementos)
                {
                    foreach (Comentario c in e.Comentarios)
                    {
                        if (c.Resolutivo == u)
                        {
                            comentarios.Add(c);
                        }
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

        public bool EmailCorrecto(string email)
        {
            foreach (Usuario u in this.Usuarios)
            {
                if (u.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public bool DatosDeUsuarioCorrectos(string email, string contraseña)
        {
            foreach (Usuario u in this.Usuarios)
            {
                if (u.Email == email)
                {
                    return u.Contraseña == contraseña;
                }
            }
            return false;
        }

        public bool ContraseñaIncorrecta(string email, string contraseña)
        {
            foreach (Usuario u in this.Usuarios)
            {
                if (u.Email == email)
                {
                    return u.Contraseña != contraseña;
                }
            }
            return true;
        }

        public Usuario BuscarUsuarioPorMail(string email)
        {
            foreach (Usuario u in this.Usuarios)
            {
                if (u.Email.ToLower() == email.ToLower())
                {
                    return u;
                }
            }
            return null;
        }

        public bool NombrePizarronRepetido(string nombre, Equipo e)
        {
            foreach (Pizarron p in this.Pizarrones)
            {
                if (p.EquipoPerteneciente.Equals(e))
                {
                    return p.Nombre == nombre;
                }
            }
            return false;
        }

        public bool TieneEquipo(Usuario u)
        {
            foreach (Equipo e in this.Equipos)
            {
                if (e.usuarios.Contains(u))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Equipo> EquiposDeUsuario(Usuario u)
        {
            List<Equipo> equipos = new List<Equipo>();
            foreach (Equipo e in this.Equipos)
            {
                if (e.usuarios.Contains(u))
                {
                    equipos.Add(e);
                }
            }
            return equipos;
        }

        public bool NombreEquipoRepetido(string nombre)
        {
            foreach (Equipo e in this.Equipos)
            {
                if (e.Nombre == nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Usuario> UsuariosNoAgregadosEnEquipo(Equipo e)
        {
            List<Usuario> usuarios = new List<Usuario>();
            foreach(Usuario u in this.Usuarios)
            {
                if (!e.usuarios.Contains(u))
                {
                    usuarios.Add(u);
                }
            }
            return usuarios;
        }

        public Pizarron BuscarPizarronPorNombreYEquipo(string nombre, string equipo)
        {
            foreach (Pizarron p in this.Pizarrones)
            {
                if (p.EquipoPerteneciente.Nombre == equipo)
                {
                    if (p.Nombre == nombre)
                    {
                        return p;
                    }
                }
            }
            return null;
        }

        public Comentario BuscarComentarioPorUsuarioYFecha(Usuario u, DateTime fecha)
        {
            foreach (Pizarron p in this.Pizarrones)
            {
                foreach (Elemento e in p.Elementos)
                {
                    foreach (Comentario c in e.Comentarios)
                    {
                        if (c.Creador.Equals(u) && c.FechaCreacion.ToString().Equals(fecha.ToString()))
                        {
                            return c;
                        }
                    }
                }
            }
            return null;
        }

        public List<Pizarron> PizarronesDondeUsuarioEsCreador(Usuario u)
        {
            List<Pizarron> pizarrones = new List<Pizarron>();
            foreach (Pizarron p in this.Pizarrones)
            {
                if (p.Creador.Equals(u))
                {
                    pizarrones.Add(p);
                }
            }
            return pizarrones;
        }

        public void EliminarUsuario(Usuario u)
        {
            bool salir = false;
            for (int i = 0; !salir && i < this.Usuarios.Count; i++)
            {
                if (this.Usuarios[i] == u)
                {
                    this.Usuarios.Remove(u);
                    salir = true;
                }
            }
            salir = false;
            for (int i = 0; !salir && i < this.Equipos.Count; i++)
            {
                if (this.Equipos[i].usuarios.Contains(u) && this.Equipos[i].usuarios.Count == 1)
                {
                    for (int j = 0; j < this.Pizarrones.Count; j++)
                    {
                        if (this.Pizarrones[j].EquipoPerteneciente == this.Equipos[i])
                        {
                            this.Pizarrones.Remove(this.Pizarrones[j]);
                            j--;
                        }
                    }
                    Equipos.Remove(this.Equipos[i]);
                    i--;
                }
            }
            foreach (Pizarron p in this.Pizarrones)
            {
                if (p.Creador == u)
                {
                    p.Creador = null;
                }
            }
        }

        public Equipo BuscarEquipoPorNombre(string nombre)
        {
            foreach (Equipo e in this.Equipos)
            {
                if (e.Nombre == nombre)
                {
                    return e;
                }
            }
            return null;
        }

        public void EliminarEquipo(Equipo e)
        {
            bool salir = false;
            for (int i = 0; !salir && i < this.Equipos.Count; i++)
            {
                if (this.Equipos[i].Equals(e))
                {
                    this.Equipos.Remove(e);
                    salir = true;
                }
            }
            salir = false;
            for (int i = 0; i < this.Pizarrones.Count; i++)
            {
                if (this.Pizarrones[i].EquipoPerteneciente.Equals(e))
                {
                    this.Pizarrones.Remove(this.Pizarrones[i]);
                    i--;
                }
            }
        }
    }
}