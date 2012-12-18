using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Modalidad
    {
        //Atributos
        private short id_modalidad;
        private string nombreMod;
        private short ptosPG;
        private Boolean empate;
        private short ptosEmpate;
        private short ptosPresentarse;
        private FormaPuntuacion formaPuntuacion;

        //Propiedades
        public short _id_modalidad
        {
            get
            {
                return id_modalidad;
            }
            set
            {
                id_modalidad = value;
            }
        }
        public string _nombreMod
        {
            get
            {
                return nombreMod;
            }
            set
            {
                nombreMod = value;
            }
        }
        public short _ptosPG
        {
            get
            {
                return ptosPG;
            }
            set
            {
                ptosPG = value;
            }
        }
        public Boolean _empate
        {
            get
            {
                return empate;
            }
            set
            {
                empate = value;
            }
            }
        public short _ptosEmpate
        {
            get
            {
                return ptosEmpate;
            }
            set
            {
                ptosEmpate = value;
            }
        }
        public short _ptosPresentarse
        {
            get
            {
                return ptosPresentarse;
            }
            set
            {
                ptosPresentarse = value;
            }
        }
        public FormaPuntuacion _formaPuntuacion
        {
            get
            {
                return formaPuntuacion;
            }
            set
            {
                formaPuntuacion = value;
            }
        }

        //Constructor
        public Modalidad() { }

        public Modalidad(string nombreMod, short pPG, Boolean esEmpate, short pEmpate, short pPresentarse, FormaPuntuacion unaFormaPuntuacion)
        {
            this._nombreMod = nombreMod;
            this._ptosPG = pPG;
            this._empate = esEmpate;
            this._ptosEmpate = pEmpate;
            this._ptosPresentarse = pPresentarse;
            this._formaPuntuacion = unaFormaPuntuacion;
        }    

    }
}
