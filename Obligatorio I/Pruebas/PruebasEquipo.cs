using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasEquipo
    {
        Utilidades utilidad = new Utilidades();

        [TestMethod]
        public void AgregarUsuarioOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            Equipo e = utilidad.NuevoEquipoSinUsuarios();
            e.AgregarUsuario(u);
            Assert.IsTrue(e.contains(u));
        }

        [TestMethod]
        public void UsuarioYaExistenteOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            Equipo e = utilidad.NuevoEquipoSinUsuarios();
            e.AgregarUsuario(u);
            Assert.IsTrue(UsuarioYaExistente(u));
        }

        [TestMethod]
        public void UsuarioYaExistenteNotOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            Usuario u2 = utilidad.OtroUsuario();
            Equipo e = utilidad.NuevoEquipoSinUsuarios();
            e.AgregarUsuario(u);
            Assert.IsFalse(UsuarioYaExistente(u2));
        }

        [TestMethod]
        public void SonElMismoUsuarioOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            Usuario u2 = new Usuario("Rafael", "Santino", "lautarogutierrez4@gmail.com",new DateTime(1,3,1990), "rafa2017", false);                        
            Assert.IsTrue(u.Equals(u2));
        }

        [TestMethod]
        public void SonElMismoUsuarioNotOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            Usuario u2 = new Usuario("Lautaro", "Gutiérrez", "lautarogutierrez5@gmail.com", new DateTime(1994,1,2), "lautaro1994", false);
            Assert.IsFalse(u.Equals(u2));
        }
    }
}
