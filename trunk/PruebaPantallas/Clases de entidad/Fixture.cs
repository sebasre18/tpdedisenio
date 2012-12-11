using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Fixture
    {
        //Atributos
        private short id_fixture;
        private Boolean eliminado;
        private List<Ronda> rondas;
        private short rondaActual;

        //Propiedades
        public short _id_fixture
        {
            get
            {
                return id_fixture;
            }
            set
            {
                id_fixture = value;
            }
        }
        public Boolean _eliminado
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
        public List<Ronda> _rondas
        {
            get
            {
                return rondas;
            }
            set
            {
                rondas = value;
            }
        }
        public short _rondaActual
        {
            get
            {
                return rondaActual;
            }
            set
            {
                rondaActual = value;
            }
        }

        //Constructor TERMINAR
        public Fixture() { }

        public Fixture(short unId_fixture, Boolean elim, List<Ronda> listaRondas, short rondaActual)
        {
            this._id_fixture = unId_fixture;
            this._eliminado = elim;
            this._rondas = listaRondas;
            this._rondaActual = rondaActual;
        }

    }
}
