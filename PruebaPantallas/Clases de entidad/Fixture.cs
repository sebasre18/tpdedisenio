using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Fixture
    {
        //Atributos
        private int id_fixture;
        private Boolean eliminado;
        private List<Ronda> rondas;

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

        //Constructor TERMINAR
        public Fixture() { }

        public Fixture(int unId_fixture, Boolean elim, List<Ronda> listaRondas)
        {
            this._id_fixture = unId_fixture;
            this._eliminado = elim;
            this._rondas = listaRondas;
        }

    }
}
