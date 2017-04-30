using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PruebasValidaciones
    {
        Validaciones validador = new Validaciones();
        Utilidades utilidad = new Utilidades();

        [TestMethod]
        public void EsContraseñaValidaOK()
        {
            string contraseña = "hola2017";
            Assert.IsTrue(validador.EsContraseñaValida(contraseña));
        }

        [TestMethod]
        public void LargoContraseñaNotOK()
        {
            string contraseña = "hola20";
            Assert.IsFalse(validador.EsContraseñaValida(contraseña));
        }

        [TestMethod]
        public void SoloLetrasEnContraseñaNotOK()
        {
            string contraseña = "holamundo";
            Assert.IsFalse(validador.EsContraseñaValida(contraseña));
        }

        [TestMethod]
        public void SoloNumerosEnContraseñaNotOK()
        {
            string contraseña = "1234567";
            Assert.IsFalse(validador.EsContraseñaValida(contraseña));
        }

        [TestMethod]
        public void EmailValidoOK()
        {
            string email = "lautarogutierrez4@gmail.com";
            Assert.IsTrue(validador.EsEmailValido(email));
        }

        [TestMethod]
        public void EmailSinPuntoComNotOK()
        {
            string email = "lautarogutierrez4@gmail";
            Assert.IsFalse(validador.EsEmailValido(email));
        }

        [TestMethod]
        public void EmailSinArrobaNotOK()
        {
            string email = "lautarogutierrez4gmail.com";
            Assert.IsFalse(validador.EsEmailValido(email));
        }

        [TestMethod]
        public void EmailSinComNotOK()
        {
            string email = "lautarogutierrez4gmail.";
            Assert.IsFalse(validador.EsEmailValido(email));
        }

        [TestMethod]
        public void EmailSinNombreNotOK()
        {
            string email = "@gmail.com";
            Assert.IsFalse(validador.EsEmailValido(email));
        }

        [TestMethod]
        public void TextoVacioOK()
        {
            string texto = "";
            Assert.IsTrue(validador.ElTextoEsVacio(texto));
        }

        [TestMethod]
        public void TextoVacioNotOK()
        {
            string texto = "a";
            Assert.IsFalse(validador.ElTextoEsVacio(texto));
        }

        [TestMethod]
        public void EsNumeroOK()
        {
            string numero = "2";
            Assert.IsTrue(validador.EsNumero(numero));
        }

        [TestMethod]
        public void EsNumeroNotOK()
        {
            string numero = "Dos";
            Assert.IsFalse(validador.EsNumero(numero));
        }
    }
}