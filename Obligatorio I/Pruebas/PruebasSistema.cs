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
            Assert.IsTrue(nuevoSistema.UsuarioYaIngresado(u));
        }

        [TestMethod]
        public void AgregarEquipoOK()
        {
            Equipo e = utilidad.NuevoEquipo();
            nuevoSistema.AgregarEquipo(e);
            Assert.IsTrue(nuevoSistema.EquipoYaIngresado(e));
        }
    }
}