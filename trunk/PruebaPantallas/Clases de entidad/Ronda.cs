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
        public int _nro_ronda
        {
            get
            {
                return nro_ronda;
            }
            set
            {
                nro_ronda = value;
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
        public Ronda() { }
        
        public Ronda(int unNro_ronda, string unNombre)
        {
            this._id_deporte = unNro_ronda;
            this._nombre = unNombre;
        }
    }
}
