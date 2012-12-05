using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    class Ronda
    {
        //Atributos
        private int nro_ronda;
        private string nombre;

        //Propiedades
        public int _id_deporte
        {
            get
            {
                return id_deporte;
            }
            set
            {
                id_deporte = value;
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

        //Constructor
        public Deporte() { }
        
        public Deporte(int unId_deporte, string unNombre)
        {
            this._id_deporte = unId_deporte;
            this._nombre = unNombre;
        }
    }
}
