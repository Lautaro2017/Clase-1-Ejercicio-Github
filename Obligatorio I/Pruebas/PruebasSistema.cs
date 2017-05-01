using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio_I;
using System.Collections.Generic;

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
            Assert.IsTrue(nuevoSistema.Usuarios.Contains(u));
        }

        [TestMethod]
        public void AgregarUsuarioYaExistenteNotOK()
        {
            Usuario u1 = utilidad.NuevoUsuario();
            Usuario u2 = utilidad.NuevoUsuario();
            nuevoSistema.AgregarUsuario(u1);
            nuevoSistema.AgregarUsuario(u2);
            Assert.IsFalse(utilidad.IngresoDeUsuarioValido(u2,nuevoSistema.Usuarios));
        }

        [TestMethod]
        public void AgregarEquipoOK()
        {
            Equipo e = utilidad.NuevoEquipo();
            nuevoSistema.AgregarEquipo(e);
            Assert.IsTrue(nuevoSistema.Equipos.Contains(e));
        }

        [TestMethod]
        public void AgregarEquipoYaExistenteNotOK()
        {
            Equipo e1 = utilidad.NuevoEquipo();
            Equipo e2 = utilidad.NuevoEquipo();
            nuevoSistema.AgregarEquipo(e1);
            nuevoSistema.AgregarEquipo(e2);
            Assert.IsFalse(utilidad.IngresoDeEquipoValido(e2,nuevoSistema.Equipos));
        }

        [TestMethod]
        public void AgregarPizarronOK()
        {
            Pizarron p = utilidad.NuevoPizarron();
            nuevoSistema.AgregarPizarron(p);
            Assert.IsTrue(nuevoSistema.Pizarrones.Contains(p));
        }

        [TestMethod]
        public void FiltrarPizarronPorFechaModOK()
        {
            Pizarron p1 = utilidad.NuevoPizarron();
            Pizarron p2 = utilidad.NuevoPizarron();
            Pizarron p3 = utilidad.NuevoPizarron();
            p1.Nombre = "Equipo Rocket";
            p2.Nombre = "Griffyndor";
            p3.Nombre = "Targaryen";
            p1.FechaDeCreacion = new DateTime(2017, 4, 30);
            p2.FechaDeCreacion = new DateTime(2017, 4, 30);
            p3.FechaDeCreacion = new DateTime(2017, 4, 29);
            nuevoSistema.AgregarPizarron(p1);
            nuevoSistema.AgregarPizarron(p2);
            nuevoSistema.AgregarPizarron(p3);
            List<Pizarron> pizarrones = nuevoSistema.FiltroPizarronesPorFechaMod(new DateTime(2017,4,30));            
            bool aux1 = pizarrones.Contains(p1);
            bool aux2 = pizarrones.Contains(p2);
            bool aux3 = pizarrones.Contains(p3);
            bool filtroCorrecto = pizarrones.Contains(p1) && pizarrones.Contains(p2) && !(pizarrones.Contains(p3));
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
            bool filtroCorrecto = pizarrones.Contains(p1) && pizarrones.Contains(p2) && !pizarrones.Contains(p3);
            Assert.IsTrue(filtroCorrecto);
        }

        [TestMethod]
        public void EliminarPizarronOK()
        {
            Pizarron p1 = utilidad.NuevoPizarron();
            Pizarron p2 = utilidad.NuevoPizarron();
            Pizarron p3 = utilidad.NuevoPizarron();
            p1.Nombre = "Slytherin";
            p2.Nombre = "San Lorenzo";
            p3.Nombre = "Ferrocarril Oeste";
            nuevoSistema.AgregarPizarron(p1);
            nuevoSistema.AgregarPizarron(p2);
            nuevoSistema.AgregarPizarron(p3);
            nuevoSistema.EliminarPizarron(p1);
            bool filtroCorrecto = !nuevoSistema.Pizarrones.Contains(p1) && nuevoSistema.Pizarrones.Contains(p2) && nuevoSistema.Pizarrones.Contains(p3);
            Assert.IsTrue(filtroCorrecto);
        }

        [TestMethod]
        public void IngresoDePizarronValidoOK()
        {
            Pizarron p = utilidad.NuevoPizarron();
            nuevoSistema.AgregarPizarron(p);
            Assert.IsTrue(utilidad.PizarronValido(p,nuevoSistema.Pizarrones()));
        }

        [TestMethod]
        public void IngresoDePizarronValidoNotOK()
        {
            Pizarron p1 = utilidad.NuevoPizarron();
            Pizarron p2 = utilidad.NuevoPizarron();
            nuevoSistema.AgregarPizarron(p1);
            Assert.IsFalse(utilidad.PizarronValido(p2, nuevoSistema.Pizarrones()));
        }
    }
}