using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorio_I;

namespace Pruebas
{
    [TestClass]
    public class PruebasPizarron
    {
        Utilidades utilidad = new Utilidades();

        [TestMethod]
        public void AgregarElementoOK()
        {
            Elemento e = utilidad.NuevoElemento();
            Pizarron p = utilidad.NuevoPizarron();
            p.AgregarElemento(e);
            Assert.IsTrue(p.Elementos.Contains(e));
        }

        [TestMethod]
        public void AgregarElementoMasGrandeQuePizarronNotOK()
        {
            Elemento e = utilidad.NuevoElemento();
            e.Alto = 100;
            e.Ancho = 80;
            Pizarron p = utilidad.NuevoPizarron();
            p.Alto = 80;
            p.Ancho = 80;
            Assert.IsFalse(p.SeAgregaElemento(e, p));
        }

        [TestMethod]
        public void AgregarFueraDelPizarronNotOK()
        {
            Elemento e = utilidad.NuevoElemento();
            e.Alto = 20;
            e.Ancho = 20;
            e.PuntoOrigen = new Elemento.Point(70, 60);
            Pizarron p = utilidad.NuevoPizarron();
            p.Alto = 80;
            p.Ancho = 80;
            Assert.IsFalse(p.SeAgregaElemento(e, p));
        }

        [TestMethod]
        public void AgregarAlPizarronOK()
        {
            Elemento e = utilidad.NuevoElemento();
            e.Alto = 20;
            e.Ancho = 20;
            e.PuntoOrigen = new Elemento.Point(60, 60);
            Pizarron p = utilidad.NuevoPizarron();
            p.Alto = 80;
            p.Ancho = 80;
            Assert.IsTrue(p.SeAgregaElemento(e, p));
        }
    }
}
