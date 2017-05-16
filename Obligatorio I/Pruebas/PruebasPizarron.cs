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
    }
}
