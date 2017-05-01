using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio_I;
using System.Collections.Generic;

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
            Assert.AreEqual(u1, u2);
        }

        [TestMethod]
        public void NuevoUsuarioOK()
        {
            Usuario u1 = utilidad.NuevoUsuario();
            Usuario u2 = new Usuario("Lautaro", "Gutierrez", "lautarogutierrez4@gmail.com",new DateTime(1994,1,2), "lautaro1994", false);
            Assert.AreEqual(u1, u2);
        }

        [TestMethod]
        public void OtroUsuarioOK()
        {
            Usuario u1 = utilidad.OtroUsuario();
            Usuario u2 = new Usuario("Marcelo", "Mancini", "manchiny24@hotmail.com",new DateTime(1990,9,24), "manchiny24", false);
            Assert.AreEqual(u1, u2);
        }

        [TestMethod]
        public void NuevoEquipoOK()
        {
            Equipo e1 = utilidad.NuevoEquipo();
            Usuario u1 = utilidad.NuevoUsuario();
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(u1);
            Equipo e2 = new Equipo("Equipo Rocket", "Gestión de gastos", 3, usuarios);
            Assert.AreEqual(e1, e2);
        }

        [TestMethod]
        public void NuevoEquipoSinIntegrantesOK()
        {
            Equipo e1 = utilidad.NuevoEquipoSinUsuarios();
            Equipo e2 = new Equipo("Equipo Rocket", "Gestión de gastos", 3, new List<Usuario>());
            Assert.AreEqual(e1, e2);
        }

        [TestMethod]
        public void NuevoPizarronVacioOK()
        {
            Pizarron p1 = utilidad.NuevoPizarronVacio();
            Pizarron p2 = new Pizarron();
            Assert.AreEqual(p1, p2);
        }

        [TestMethod]
        public void NuevoPizarronOK()
        {
            Pizarron p1 = utilidad.NuevoPizarron();
            Equipo e = utilidad.NuevoEquipo();
            Usuario u = utilidad.NuevoUsuario();
            Pizarron p2 = new Pizarron("Gastos varios", e, "Gestión de gastos varios", 120, 240, u);
            Assert.AreEqual(p1, p2);
        }

        [TestMethod]
        public void NuevoElementoOK()
        {
            Elemento e1 = utilidad.NuevoElemento();
            Comentario c1 = utilidad.NuevoComentario();
            List <Comentario> comentarios = new List<Comentario>();
            comentarios.Add(c1);
            Pizarron p = utilidad.NuevoPizarron();
            Elemento.Point origen = new Elemento.Point(23, 33);
            Elemento e2 = new Elemento('T', 100, 240, comentarios, origen, p);
            Assert.AreEqual(e1, e2);
        }

        [TestMethod]
        public void NuevoComentarioOK()
        {
            Comentario c1 = utilidad.NuevoComentario();
            Usuario u1 = utilidad.NuevoUsuario();
            Usuario u2 = utilidad.OtroUsuario();
            Pizarron p = utilidad.NuevoPizarron();
            Comentario c2 =  new Comentario(new DateTime(2017,4,29), u1, u2, p);
            Assert.AreEqual(c1, c2);
        }

        [TestMethod]
        public void GenerarContraseñaOK()
        {
            string contraseña = utilidad.GenerarContraseña();
            Assert.IsNotNull(contraseña);
        }
    }
}