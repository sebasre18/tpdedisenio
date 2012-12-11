using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Usuario
    {
        //Atributos
        private string email;
        private string contraseña;
        private string apellido;
        private string nombre;
        private string tipo_dni;
        private int nro_dni;

        //Propiedades
        public string _email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string _contraseña
        {
            get
            {
                return contraseña;
            }
            set
            {
                contraseña = value;
            }
        }
        public string _apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public string _nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string _tipo_dni
        {
            get
            {
                return tipo_dni;
            }
            set
            {
                tipo_dni = value;
            }
        }
        public int _nro_dni
        {
            get
            {
                return nro_dni;
            }
            set
            {
                nro_dni = value;
            }
        }

        //Constructor
        public Usuario() { }
        public Usuario(string unEmail, string unaContraseña, string unApellido, string unNombre, string unTipo_dni, int unNro_dni)
        {
            this._email = unEmail;
            this._contraseña = unaContraseña;
            this._apellido = unApellido;
            this._nombre = unNombre;
            this._tipo_dni = unTipo_dni;
            this._nro_dni = unNro_dni;
        }
        public Usuario(string unEmail, string unaContraseña, string unApellido, string unNombre)
        {
            this._email = unEmail;
            this._contraseña = unaContraseña;
            this._apellido = unApellido;
            this._nombre = unNombre;
        }
    }
}
