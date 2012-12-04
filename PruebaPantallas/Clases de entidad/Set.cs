using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    private class Set
    {
        //Atributos
        private int id_set;
        private int puntosP1;
        private int puntosP2;

        //Propiedades
        public int _id_set
        {
            get
            {
                return id_set;
            }
            set
            {
                id_set = value;
            }
        }
        public int _puntosP1
        {
            get
            {
                return puntosP1;
            }
            set
            {
                puntosP1 = value;
            }
        }
        public int _puntosP2
        {
            get
            {
                return puntosP2;
            }
            set
            {
                puntosP2 = value;
            }
        }

        //Constructor
        public Set(int unId_set, int unPuntosP1, int unPuntosP2)
        {
            this._id_set = unId_set;
            this._puntosP1 = unPuntosP1;
            this._puntosP2 = unPuntosP2;
        }
    }
}
