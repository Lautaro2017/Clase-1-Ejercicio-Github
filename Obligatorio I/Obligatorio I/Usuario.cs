using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_I
{
    public class Usuario
    {
        private string Nombre { set; get; }
        private string Apellido { set; get; }
        private string email { set; get; }
        private DateTime FechaDeNacimiento { set; get; }
        private string contraseña { set; get; }
        private bool esAdministrador { set; get; }

        public Usuario()
        {
            this.Nombre = "";
            this.Apellido = "";
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                this.email = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }
            set
            {
                this.contraseña = value;
            }
        }

        public bool EsAdministrador
        {
            get
            {
                return esAdministrador;
            }
            set
            {
                this.esAdministrador = value;
            }
        }

        public Usuario(string nuevoNombre, string nuevoApellido, string nuevoEmail, DateTime nuevaFechaNac, string nuevaContraseña, bool nuevoEsAdministrador)
        {
            this.Nombre = nuevoNombre;
            this.Apellido = nuevoApellido;
            //Unico
            this.Email = nuevoEmail;
            this.FechaDeNacimiento = nuevaFechaNac;
            //Suponemos contraseña de largo 7 minimo con al menos una letra y un numero
            this.Contraseña = nuevaContraseña;
            this.EsAdministrador = nuevoEsAdministrador;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Usuario;

            if (item == null)
            {
                return false;
            }

            if (item.Email == null)
            {
                return this.Email == null;
            }

            return this.Email.Equals(item.Email);
        }

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }
    }
}
