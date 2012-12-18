using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class FormaPuntuacion
    {
        //Atributos
        private short id_forma;
        private string nombreForma;
        private short cantidadSet;
        private short tantosAusencia;

        //Propiedades
        public short _id_forma
        {
            get
            {
                return id_forma;
            }
            set
            {
                id_forma = value;
            }
        }
        public string _nombreForma
        {
            get
            {
                return nombreForma;
            }
            set
            {
                nombreForma = value;
            }
        }
        public short _cantidadSet
        {
            get
            {
                return cantidadSet;
            }
            set
            {
                cantidadSet = value;
            }
        }
        public short _tantosAusencia
        {
            get
            {
                return tantosAusencia;
            }
            set
            {
                tantosAusencia = value;
            }
        }

        //Constructor
        public FormaPuntuacion() { }

        public FormaPuntuacion(string nombreForma, short cantSet, short tantosAus)
        {
            this._nombreForma = unNombreForma;
            this._cantidadSet = cantSet;
            this._tantosAusencia = tantosAus;
        }
    }
}
