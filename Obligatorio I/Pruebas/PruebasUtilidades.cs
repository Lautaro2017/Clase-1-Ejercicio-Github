using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasUtilidades
    {
        Utilidades utilidad = new Utilidades();

        [TestMethod]
        public void NuevoUsuarioVacioOK()
        {
            Usuario u1 = utilidad.NuevoUsuarioVacio();
            Usuario u2 = new Usuario();
            Assert.AreSame(u1, u2);
        }

        [TestMethod]
        public void NuevoUsuarioOK()
        {
            Usuario u1 = utilidad.NuevoUsuario();
            Usuario u2 = new Usuario("Lautaro", "Gutierrez", "lautarogutierrez4@gmail.com",new DateTime(1994,1,2), "lautaro1994", false);
            Assert.AreSame(u1, u2);
        }

        [TestMethod]
        public void OtroUsuarioOK()
        {
            Usuario u1 = utilidad.OtroUsuario();
            Usuario u2 = new Usuario("Marcelo", "Mancini", "manchiny24@hotmail.com",new DateTime(1990,9,24), "manchiny24", false);
            Assert.AreSame(u1, u2);
        }

        [TestMethod]
        public void NuevoEquipoOK()
        {
            Equipo e1 = utilidad.NuevoEquipo();
            Usuario u1 = utilidad.NuevoUsuario();
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.add(u1);
            Equipo e2 = new Equipo("Equipo Rocket", "Gestión de gastos", 3, usuarios);
            Assert.AreSame(e1, e2);
        }

        [TestMethod]
        public void NuevoEquipoSinIntegrantesOK()
        {
            Equipo e1 = utilidad.NuevoEquipoSinUsuarios();
            Equipo e2 = new Equipo("Equipo Rocket", "Gestión de gastos", 3, new List<Usuario>());
            Assert.AreSame(e1, e2);
        }

        [TestMethod]
        public void NuevoPizarronVacioOK()
        {
            Pizarron p1 = utilidad.NuevoPizarronVacio();
            Pizarron p2 = new Pizarron();
            Assert.AreSame(p1, p2);
        }

        [TestMethod]
        public void NuevoPizarronOK()
        {
            Pizarron p1 = utilidad.NuevoPizarron();
            Equipo e = utilidad.NuevoEquipo();
            Usuario u = utilidad.NuevoUsuario;
            Pizarron p2 = new Pizarron("Gastos varios", e, "Gestión de gastos varios", 120, 240, u);
            Assert.AreSame(p1, p2);
        }

        [TestMethod]
        public void NuevoElementoVacioOK()
        {
            Elemento e1 = utilidad.NuevoElementoVacio();
            Elemento e2 = new Elemento();
            Assert.AreSame(e1, e2);
        }

        [TestMethod]
        public void NuevoElementoOK()
        {
            Elemento e1 = utilidad.NuevoElemento();
            Comentario c1 = utilidad.NuevoComentario();
            List<Comentario> comentarios = new List<Comentario>();
            comentarios.add(c1);
            Elemento e2 = new Elemento('T', 100, 240, comentarios, (100, 120));
            Assert.AreSame(e1, e2);
        }

        [TestMethod]
        public void NuevoComentarioVacioOK()
        {
            Comentario c1 = utilidad.NuevoComentarioVacio();
            Comentario c2 = new Comentario();
            Assert.AreSame(c1, c2);
        }

        [TestMethod]
        public void NuevoComentarioOK()
        {
            Comentario c1 = utilidad.NuevoComentario();
            Usuario u1 = utilidad.NuevoUsuario();
            Usuario u2 = utilidad.OtroUsuario();
            Comentario c2 =  new Comentario(new DateTime(2017,4,29), u1, u2);
            Assert.AreSame(c1, c2);
        }

        [TestMethod]
        public void GenerarContraseñaOK()
        {
            string contraseña = utilidad.GenerarContraseña();
            Assert.IsNotNull(contraseña);
        }
    }
}