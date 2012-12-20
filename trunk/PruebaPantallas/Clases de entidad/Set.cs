using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Set
    {
        //Atributos
        private short id_set;
        private int puntosP1;
        private int puntosP2;
        private short nroSet;

        //Propiedades
        public short _id_set
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
        public short _nroSet
        {
            get
            {
                return nroSet;
            }
            set
            {
                nroSet = value;
            }
        }


        //Constructor
        public Set() { }

        public Set(short unId_set, int unPuntosP1, int unPuntosP2, short unNroSet)
        {
            this._id_set = unId_set;
            this._puntosP1 = unPuntosP1;
            this._puntosP2 = unPuntosP2;
            this._nroSet = unNroSet;
        }
    }
}
