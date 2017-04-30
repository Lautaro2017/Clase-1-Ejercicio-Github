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

        [TestMethod]
        public void FiltrarPizarronPorFechaModOK()
        {
            Pizarron p1 = utilidad.NuevoPizarron();
            Pizarron p2 = utilidad.NuevoPizarron();
            Pizarron p3 = utilidad.NuevoPizarron();
            p1.FechaDeCreacion = new DateTime(2017, 30, 4);
            p2.FechaDeCreacion = new DateTime(2017, 30, 4);
            p3.FechaDeCreacion = new DateTime(2017, 29, 4);
            nuevoSistema.AgregarPizarron(p1);
            nuevoSistema.AgregarPizarron(p2);
            nuevoSistema.AgregarPizarron(p3);
            List<Pizarron> pizarrones = nuevoSistema.FiltroPizarronesPorFechaMod(new DateTime(2017,30,4));
            bool filtroCorrecto = pizarrones.contains(p1) && pizarrones.contains(p2) && !pizarrones.contains(p3);
            Assert.IsTrue(filtroCorrecto);
        }

        [TestMethod]
        public void FiltrarPizarronPorEquipoOK()
        {
            Equipo e1 = utilidad.NuevoEquipo();
            Equipo e2 = utilidad.NuevoEquipo();
            Pizarron p1 = utilidad.NuevoPizarron();
            Pizarron p2 = utilidad.NuevoPizarron();
            Pizarron p3 = utilidad.NuevoPizarron();
            e1.Nombre = "Equipo 1";
            e1.Nombre = "Equipo 2";
            p1.EquipoPerteneciente = e1;
            p2.EquipoPerteneciente = e1;
            p3.EquipoPerteneciente = e2;
            nuevoSistema.AgregarEquipo(e1);
            nuevoSistema.AgregarEquipo(e2);
            nuevoSistema.AgregarPizarron(p1);
            nuevoSistema.AgregarPizarron(p2);
            nuevoSistema.AgregarPizarron(p3);
            List<Pizarron> pizarrones = nuevoSistema.FiltroDePizarronesPorEquipo(e1);
            bool filtroCorrecto = pizarrones.contains(p1) && pizarrones.contains(p2) && !pizarrones.contains(p3);
            Assert.IsTrue(filtroCorrecto);
        }

        [TestMethod]
        public void EliminarPizarronOK()
        {
            Pizarron p1 = utilidad.NuevoPizarron();
            Pizarron p2 = utilidad.NuevoPizarron();
            Pizarron p3 = utilidad.NuevoPizarron();
            nuevoSistema.AgregarPizarron(p1);
            nuevoSistema.AgregarPizarron(p2);
            nuevoSistema.AgregarPizarron(p3);
            List<Pizarron> pizarrones = nuevoSistema.EliminarPizarron(p1);
            bool filtroCorrecto = !pizarrones.contains(p1) && pizarrones.contains(p2) && pizarrones.contains(p3);
            Assert.IsTrue(filtroCorrecto);
        }
    }
}