using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Modalidad
    {
        //Atributos
        private int id_modalidad;
        private string nombreMod;
        private int ptosPG;
        private Boolean empate;
        private int ptosEmpate;
        private int ptosPresentarse;
        private FormaPuntuacion formaPuntuacion;

        //Propiedades
        public int _id_modalidad
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
        public int _ptosPG
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
        public int _ptosEmpate
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
        public int _ptosPresentarse
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

        public Modalidad(int unId_modalidad, int pPG, Boolean esEmpate, int pEmpate, int pPresentarse, FormaPuntuacion unaFormaPuntuacion)
        {
            this._id_modalidad = unId_modalidad;
            this._ptosPG = pPG;
            this._empate = esEmpate;
            this._ptosEmpate = pEmpate;
            this._ptosPresentarse = pPresentarse;
            this._formaPuntuacion = unaFormaPuntuacion;
        }    

    }
}
