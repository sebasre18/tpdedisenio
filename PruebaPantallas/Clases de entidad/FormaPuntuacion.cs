using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class FormaPuntuacion
    {
        //Atributos
        private int id_forma;
        private string nombreForma;
        private int cantidadSet;
        private int tantosAusencia;

        //Propiedades
        public int _id_forma
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
        public int _cantidadSet
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
        public int _tantosAusencia
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

        public FormaPuntuacion(int unId_forma, int cantSet, int tantosAus)
        {
            this._id_forma = unId_forma;
            this._cantidadSet = cantSet;
            this._tantosAusencia = tantosAus;
        }
    }
}
