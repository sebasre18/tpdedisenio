using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Participante
    {
        //Atributos
        private int id_participante;
        private string nombre;
        private string email;
        private string imagen;
        private bool perdio;
        private bool eliminado;
        private int id_competencia;
        private int id_historial;
        private int id_partido;
        private int id_tablaPos;

        //Propiedades
        public int _id_participante
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
        public int _id_competencia
        {
            get
            {
                return id_competencia;
            }
            set
            {
                id_competencia = value;
            }
        }
        public int _id_historial
        {
            get
            {
                return id_historial;
            }
            set
            {
                id_historial = value;
            }
        }
        public int _id_partido
        {
            get
            {
                return id_partido;
            }
            set
            {
                id_partido = value;
            }
        }
        public int _id_tablaPos
        {
            get
            {
                return id_tablaPos;
            }
            set
            {
                id_tablaPos = value;
            }
        }

        //Constructor
        public Participante(int unId_participante, string unNombre, string unEmail, string unaImagen, bool unPerdio, bool unEliminado, int unId_competencia, int unId_historial, int unId_partido, int unId_tablaPos)
        {
            this._id_participante = unId_participante;
            this._nombre = unNombre;
            this._email = unEmail;
            this._imagen = unaImagen;
            this._perdio = unPerdio;
            this._eliminado = unEliminado;
            this._id_competencia = unId_competencia;
            this._id_historial = unId_historial;
            this._id_partido = unId_partido;
            this._id_tablaPos = unId_tablaPos;
        }
    }
}
