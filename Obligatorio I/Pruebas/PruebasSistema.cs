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
            Assert.IsTrue(nuevoSistema.Pizarrones.Contains(p));
        }

        [TestMethod]
        public void IngresoDePizarronValidoNotOK()
        {
            Pizarron p1 = utilidad.NuevoPizarron();
            Pizarron p2 = utilidad.NuevoPizarron();
            nuevoSistema.AgregarPizarron(p1);
            Assert.IsFalse(utilidad.PizarronValido(p2, nuevoSistema.Pizarrones));
        }

        [TestMethod]
        public void FiltroComentariosPorUsuarioCreadorOK()
        {
            Elemento e = utilidad.NuevoElemento();
            e.Comentarios = new List<Comentario>();
            Comentario c1 = utilidad.NuevoComentario();
            Comentario c2 = utilidad.NuevoComentario();
            Usuario u1 = utilidad.NuevoUsuario();
            Usuario u2 = utilidad.OtroUsuario();
            c1.Creador = u1;
            c2.Creador = u2;
            e.AgregarComentario(c1);
            e.AgregarComentario(c2);
            nuevoSistema.AgregarElemento(e);
            List<Comentario> comentarios = nuevoSistema.FiltrarComentarioPorUsuarioCreador(u2);
            bool condicion = comentarios.Contains(c2) && !comentarios.Contains(c1);
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void FiltroComentariosPorUsuarioCreadorNoAgregadoOK()
        {
            Elemento e = utilidad.NuevoElemento();
            e.Comentarios = new List<Comentario>();
            Comentario c1 = utilidad.NuevoComentario();
            Comentario c2 = utilidad.NuevoComentario();
            Usuario u1 = utilidad.NuevoUsuario();
            Usuario u2 = utilidad.OtroUsuario();
            c1.Creador = u1;
            c2.Creador = u1;
            e.AgregarComentario(c1);
            e.AgregarComentario(c2);
            nuevoSistema.AgregarElemento(e);
            List<Comentario> comentarios = nuevoSistema.FiltrarComentarioPorUsuarioCreador(u2);
            bool condicion = !comentarios.Contains(c2) && !comentarios.Contains(c1);
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void FiltroComentariosPorFechaCreacionOK()
        {
            Elemento e = utilidad.NuevoElemento();
            e.Comentarios = new List<Comentario>();
            Comentario c1 = utilidad.NuevoComentario();
            Comentario c2 = utilidad.NuevoComentario();
            c1.FechaCreacion = new DateTime(2017, 5, 6);
            c2.FechaCreacion = new DateTime(2017, 5, 5);
            e.AgregarComentario(c1);
            e.AgregarComentario(c2);
            nuevoSistema.AgregarElemento(e);
            List<Comentario> comentarios = nuevoSistema.FiltroComentarioPorFechaCreacion(new DateTime(2017, 5, 6));
            bool condicion = comentarios.Contains(c1) && !comentarios.Contains(c2);
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void FiltroComentariosPorFechaCreacionNoAgregadaOK()
        {
            Elemento e = utilidad.NuevoElemento();
            e.Comentarios = new List<Comentario>();
            Comentario c1 = utilidad.NuevoComentario();
            Comentario c2 = utilidad.NuevoComentario();
            c1.FechaCreacion = new DateTime(2017, 5, 6);
            c2.FechaCreacion = new DateTime(2017, 5, 5);
            e.AgregarComentario(c1);
            e.AgregarComentario(c2);
            nuevoSistema.AgregarElemento(e);
            List<Comentario> comentarios = nuevoSistema.FiltroComentarioPorFechaCreacion(new DateTime(2017, 5, 7));
            bool condicion = !comentarios.Contains(c1) && !comentarios.Contains(c2);
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void FiltroComentariosPorUsuarioResolutorOK()
        {
            Elemento e = utilidad.NuevoElemento();
            e.Comentarios = new List<Comentario>();         
            Comentario c1 = utilidad.NuevoComentario();
            Comentario c2 = utilidad.NuevoComentario();
            Usuario u1 = utilidad.NuevoUsuario();
            Usuario u2 = utilidad.OtroUsuario();
            c1.Resolutivo = u1;
            c2.Resolutivo = u2;
            e.AgregarComentario(c1);
            e.AgregarComentario(c2);
            nuevoSistema.AgregarElemento(e);
            List<Comentario> comentarios = nuevoSistema.FiltrarComentarioPorUsuarioResolutor(u2);
            bool condicion = comentarios.Contains(c2) && !comentarios.Contains(c1);
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void FiltroComentariosPorUsuarioResolutorNoAgregadoOK()
        {
            Elemento e = utilidad.NuevoElemento();
            e.Comentarios = new List<Comentario>();
            Comentario c1 = utilidad.NuevoComentario();
            Comentario c2 = utilidad.NuevoComentario();
            Usuario u1 = utilidad.NuevoUsuario();
            Usuario u2 = utilidad.OtroUsuario();
            c1.Resolutivo = u1;
            c2.Resolutivo = u1;
            e.AgregarComentario(c1);
            e.AgregarComentario(c2);
            nuevoSistema.AgregarElemento(e);
            List<Comentario> comentarios = nuevoSistema.FiltrarComentarioPorUsuarioResolutor(u2);
            bool condicion = !comentarios.Contains(c2) && !comentarios.Contains(c1);
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void FiltroComentariosPorFechaResolucionOK()
        {
            Elemento e = utilidad.NuevoElemento();
            e.Comentarios = new List<Comentario>();
            Comentario c1 = utilidad.NuevoComentario();
            Comentario c2 = utilidad.NuevoComentario();
            c1.FechaCreacion = new DateTime(2017, 5, 6);
            c2.FechaCreacion = new DateTime(2017, 5, 5);
            e.AgregarComentario(c1);
            e.AgregarComentario(c2);
            nuevoSistema.AgregarElemento(e);
            List<Comentario> comentarios = nuevoSistema.FiltroComentarioPorFechaCreacion(new DateTime(2017, 5, 6));
            bool condicion = comentarios.Contains(c1) && !comentarios.Contains(c2);
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void FiltroComentariosPorFechaResolucionNoAgregadaOK()
        {
            Elemento e = utilidad.NuevoElemento();
            e.Comentarios = new List<Comentario>();
            Comentario c1 = utilidad.NuevoComentario();
            Comentario c2 = utilidad.NuevoComentario();
            c1.FechaResolucion = new DateTime(2017, 5, 6);
            c2.FechaResolucion = new DateTime(2017, 5, 5);
            e.AgregarComentario(c1);
            e.AgregarComentario(c2);
            nuevoSistema.AgregarElemento(e);
            List<Comentario> comentarios = nuevoSistema.FiltroComentarioPorFechaResolucion(new DateTime(2017, 5, 7));
            bool condicion = !comentarios.Contains(c1) && !comentarios.Contains(c2);
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void EmailPerteneceAUsuarioOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            Assert.IsTrue(nuevoSistema.EmailCorrecto("lautarogutierrez4@gmail.com"));
        }

        [TestMethod]
        public void EmailPerteneceAUsuarioNotOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            Assert.IsTrue(nuevoSistema.EmailCorrecto("lautarogutierrez4@gmail.com.uy"));
        }

        [TestMethod]
        public void DatosDeUsuarioCorrectosOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            nuevoSistema.AgregarUsuario(u);
            Assert.IsTrue(nuevoSistema.DatosDeUsuarioCorrectos("lautarogutierrez4@gmail.com.uy","lautaro1994"));
        }

        [TestMethod]
        public void DatosDeUsuarioCorrectosNotOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            nuevoSistema.AgregarUsuario(u);
            Assert.IsFalse(nuevoSistema.DatosDeUsuarioCorrectos("lautarogutierrez4@gmail.com.uy", "lautaro94"));
        }

        [TestMethod]
        public void ContraseñaIncorrectOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            nuevoSistema.AgregarUsuario(u);
            Assert.IsTrue(nuevoSistema.ContraseñaIncorrecta("lautarogutierrez4@gmail.com.uy", "lautaro94"));
        }

        [TestMethod]
        public void ContraseñaIncorrectNotOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            nuevoSistema.AgregarUsuario(u);
            Assert.IsFalse(nuevoSistema.ContraseñaIncorrecta("lautarogutierrez4@gmail.com.uy", "lautaro1994"));
        }

        [TestMethod]
        public void BuscarUsuarioPorMailOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            bool condicion = nuevoSistema.BuscarUsuarioPorMail("lautarogutierrez4@gmail.com") == u;
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void BuscarUsuarioPorMailNotOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            bool condicion = nuevoSistema.BuscarUsuarioPorMail("lautarogutierrez@gmail.com") == null;
            Assert.IsFalse(condicion);
        }

        [TestMethod]
        public void NombrePizarronRepetidoOK()
        {
            Pizarron p = utilidad.NuevoPizarron();
            Equipo e = utilidad.NuevoEquipo();
            nuevoSistema.AgregarPizarron(p);
            Assert.IsTrue(nuevoSistema.NombrePizarronRepetido("Gastos varios", e));
        }

        [TestMethod]
        public void NombrePizarronRepetidoNotOK()
        {
            Pizarron p = utilidad.NuevoPizarron();
            Equipo e = utilidad.NuevoEquipo();
            Equipo e1 = utilidad.NuevoEquipo();
            e1.Nombre = "Equipo 2";
            nuevoSistema.AgregarPizarron(p);
            Assert.IsFalse(nuevoSistema.NombrePizarronRepetido("Gastos varios", e1));
        }

        [TestMethod]
        public void UsuarioConEquipoOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            Equipo e = utilidad.NuevoEquipo();
            nuevoSistema.AgregarEquipo(e);
            bool condicion = nuevoSistema.TieneEquipo(u);
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void UsuarioSinEquipoOK()
        {
            Usuario u = utilidad.NuevoUsuario();
            Usuario u2 = utilidad.OtroUsuario();
            Equipo e = utilidad.NuevoEquipo();
            nuevoSistema.AgregarEquipo(e);
            bool condicion = nuevoSistema.TieneEquipo(u2);
            Assert.IsFalse(condicion);
        }

        [TestMethod]
        public void EquiposDeUsuarioOK()
        {
            Equipo e = utilidad.NuevoEquipo();
            Usuario u = utilidad.NuevoUsuario();
            List<Equipo> equipos = nuevoSistema.EquiposDeUsuario(u);
            Assert.IsTrue(equipos.Contains(e));
        }

        [TestMethod]
        public void EquiposDeUsuarioVacioOK()
        {
            Equipo e = utilidad.NuevoEquipo();
            Usuario u = utilidad.NuevoUsuario();
            Usuario u2 = utilidad.OtroUsuario();
            List<Equipo> equipos = nuevoSistema.EquiposDeUsuario(u2);
            Assert.IsTrue(equipos.Count == 0);
        }

        [TestMethod]
        public void NombreEquipoRepetidoOK()
        {
            Equipo e = utilidad.NuevoEquipo();
            nuevoSistema.AgregarEquipo(e);
            Assert.IsTrue(nuevoSistema.NombreEquipoRepetido("Equipo Rocket"));
        }

        [TestMethod]
        public void NombreEquipoRepetidoNotOK()
        {
            Equipo e = utilidad.NuevoEquipo();
            nuevoSistema.AgregarEquipo(e);
            Assert.IsTrue(nuevoSistema.NombreEquipoRepetido("EquipoRocket"));
        }

        [TestMethod]
        public void UsuariosNoAgregadosEnEquipoOK()
        {
            Equipo e = utilidad.NuevoEquipo();
            Usuario u1 = utilidad.OtroUsuario();
            Usuario u2 = utilidad.NuevoUsuario();
            nuevoSistema.AgregarUsuario(u1);
            nuevoSistema.AgregarUsuario(u1);
            nuevoSistema.AgregarEquipo(e);
            List<Usuario> usuarios = nuevoSistema.UsuariosNoAgregadosEnEquipo(e);
            bool condicion = !usuarios.Contains(u1) && usuarios.Contains(u2);
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void BuscarPizarronPorNombreYEquipoOK()
        {
            Pizarron p = utilidad.NuevoPizarron();
            Equipo e = utilidad.NuevoEquipo();
            nuevoSistema.AgregarEquipo(e);
            nuevoSistema.AgregarPizarron(p);
            bool condicion = nuevoSistema.BuscarPizarronPorNombreYEquipo("Gastos varios", "Equipo Rocket") == p;
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void BuscarComentarioPorUsuarioYFechaOK()
        {
            DateTime fecha = new DateTime();
            Comentario c = utilidad.NuevoComentario();
            Usuario u = utilidad.NuevoUsuario();
            c.FechaCreacion = fecha;
            c.Creador = u;
            Comentario buscar = nuevoSistema.BuscarComentarioPorUsuarioYFecha(u,fecha);
            bool condicion = c.Equals(u);
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void BuscarComentarioPorUsuarioYFechaNotOK()
        {
            DateTime fecha = new DateTime(2017,2,2);
            DateTime fecha2 = new DateTime(2017, 3, 2);
            Comentario c = utilidad.NuevoComentario();
            Usuario u = utilidad.NuevoUsuario();
            c.FechaCreacion = fecha;
            c.Creador = u;
            Comentario buscar = nuevoSistema.BuscarComentarioPorUsuarioYFecha(u,fecha2);
            bool condicion = c.Equals(null);
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void PizarronesDondeUsuarioEsCreadorOK()
        {
            Pizarron p = utilidad.NuevoPizarron();
            Usuario u = utilidad.NuevoUsuario();
            bool condicion = nuevoSistema.PizarronesDondeUsuarioEsCreador(u).Contains(p);
            Assert.IsTrue(condicion);
        }

        [TestMethod]
        public void PizarronesDondeUsuarioEsCreadorNotOK()
        {
            Pizarron p = utilidad.NuevoPizarron();
            Usuario u = utilidad.OtroUsuario();
            bool condicion = nuevoSistema.PizarronesDondeUsuarioEsCreador(u).Contains(p);
            Assert.IsFalse(condicion);
        }
    }
}