using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_I
{
    public class Equipo
    {
        public string Nombre { set; get; }
        public DateTime FechaDeCreacion { set; get; }
        public string Descripcion { set; get; }
        public int CantMaxUsuarios { set; get; }
        public List<Usuario> usuarios { set; get; }

        //Consideramos fecha de creacion la actual?
        public Equipo(string nuevoNombre, string nuevaDescripcion, int nuevaCantMaxUsuarios, List<Usuario> nuevosUsuarios)
        {
            this.Nombre = nuevoNombre;
            this.FechaDeCreacion = DateTime.Now;
            this.Descripcion = nuevaDescripcion;
            this.CantMaxUsuarios = nuevaCantMaxUsuarios;
            this.usuarios = nuevosUsuarios;
        }

        public void AgregarUsuario(Usuario u)
        {
            if (!this.usuarios.Contains(u))
            {
                this.usuarios.Add(u);
            }
        }
    }
}