using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio_I
{
    public class Usuario
    {
        private string nombre { set; get; }
        private string apellido { set; get; }
        private string email { set; get; }
        private DateTime FechaDeNacimiento { set; get; }
        private string contraseña { set; get; }
        private bool esAdministrador { set; get; }

        public Usuario()
        {
            this.nombre = "";
            this.apellido = "";
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

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                this.apellido = value;
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
            this.nombre = nuevoNombre;
            this.apellido = nuevoApellido;
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
            return this.nombre + " " + this.apellido;
        }
    }
}
