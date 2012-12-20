using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Participante
    {
        //Atributos
        private short id_participante;
        private string nombre;
        private string email;
        private string imagen;
        private bool perdio;
        private bool eliminado;      


        //Propiedades
        public short _id_participante
        {
            get
            {
                return id_participante;
            }
            set
            {
                id_participante = value;
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
        public string _imagen
        {
            get
            {
                return imagen;
            }
            set
            {
                imagen = value;
            }
        }
        public bool _perdio
        {
            get
            {
                return perdio;
            }
            set
            {
                perdio = value;
            }
        }
        private bool _eliminado
        {
            get
            {
                return eliminado;
            }
            set
            {
                eliminado = value;
            }
        }


        //Constructor
        public Participante() { }

        public Participante(short unId_participante, string unNombre, string unEmail, string unaImagen, bool unPerdio, bool unEliminado)
        {
            this._id_participante = unId_participante;
            this._nombre = unNombre;
            this._email = unEmail;
            this._imagen = unaImagen;
            this._perdio = unPerdio;
            this._eliminado = unEliminado;                       
        }
    }
}
