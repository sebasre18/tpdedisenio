using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Resultado
    {
        //Atributos
        private int id_resultado;
        private int puntosP1;
        private int puntosP2;
        private Participante ganador; //VER
        private bool empate;
        private int cantidad_set;
        private List<Set> sets;
        private int id_partido;
        private int id_histResultado;

        //Propiedades
        public int _id_resultado
        {
            get
            {
                return id_resultado;
            }
            set
            {
                id_resultado = value;
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
        public Participante _ganador
        {
            get
            {
                return ganador;
            }
            set
            {
                ganador = value;
            }
        }
        public bool _empate
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
        public int _cantidad_set
        {
            get
            {
                return cantidad_set;
            }
            set
            {
                cantidad_set = value;
            }
        }
        public List<Set> _sets
        {
            get
            {
                return sets;
            }
            set
            {
                sets = value;
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
        public int _id_histResultado
        {
            get
            {
                return id_histResultado;
            }
            set
            {
                id_histResultado = value;
            }
        }

        //Constructor
        public Resultado(int unId_resultado, int unPuntosP1, int unPuntosP2, Participante unGanador, bool unEmpate, int unaCantidad_set, List<Set> unosSets, int unId_partido, int unId_histResultado)
        {
            this._id_resultado = unId_resultado;
            this._puntosP1 = unPuntosP1;
            this._puntosP2 = unPuntosP2;
            this._ganador = unGanador;
            this._empate = unEmpate;
            this._cantidad_set = unaCantidad_set;
            this._sets = unosSets;
            this._id_partido = unId_partido;
            this._id_histResultado = unId_histResultado;
        }
    }
}
