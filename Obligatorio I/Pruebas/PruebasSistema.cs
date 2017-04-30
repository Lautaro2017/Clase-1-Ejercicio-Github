using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio_I;

namespace Pruebas
{
    [TestClass]
    public class PruebasSistema
    {
        Utilidades utilidad = new Utilidades();
        Sistema nuevoSistema = new Sistema();

        [TestMethod]
        public void AgregarUsuarioOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            nuevoSistema.AgregarUsuario(u);
            Assert.IsTrue(nuevoSistema.Usuarios.contains(u));
        }

        [TestMethod]
        public void AgregarUsuarioYaExistenteNotOK()
        {
            Usuario u1 = utilidad.NuevoUsuario();
            Usuario u2 = utilidad.NuevoUsuario();
            nuevoSistema.AgregarUsuario(u1);
            nuevoSistema.AgregarUsuario(u2);
            Assert.IsFalse(nuevoSistema.Usuarios.contains(u2));
        }

        [TestMethod]
        public void AgregarEquipoOK()
        {
            Equipo e = utilidad.NuevoEquipo();
            nuevoSistema.AgregarEquipo(e);
            Assert.IsTrue(nuevoSistema.Equipos.contains(e));
        }

        [TestMethod]
        public void AgregarEquipoYaExistenteNotOK()
        {
            Equipo e1 = utilidad.NuevoEquipo();
            Equipo e2 = utilidad.NuevoEquipo();
            nuevoSistema.AgregarEquipo(e1);
            nuevoSistema.AgregarEquipo(e2);
            Assert.IsFalse(nuevoSistema.Equipos.contains(e2));
        }

        [TestMethod]
        public void AgregarPizarronOK()
        {
            Pizarron p = utilidad.NuevoPizarron();
            nuevoSistema.AgregarPizarron(p);
            Assert.IsTrue(nuevoSistema.Pizarrones.contains(p));
        }
    }
}