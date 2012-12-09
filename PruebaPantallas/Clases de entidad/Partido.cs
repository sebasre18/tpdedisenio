using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Partido
    {
        //Atributos
        private int id_partido;
        private Resultado resultado;
        private List<Participante> participantes;

        //Propiedades
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
        public Resultado _resultado
        {
            get
            {
                return resultado;
            }
            set
            {
                resultado = value;
            }
        }
        public List<Participante> _participantes
        {
            get
            {
                return participantes;
            }
            set
            {
                participantes = value;
            }
        }

        //Constructor
        public Partido() { }

        public Partido(int unId_partido, Resultado resultado, List<Participante> listaParticipantes)
        {
            this._id_partido = unId_partido;
            this._resultado = resultado;
            this._participantes = listaParticipantes;
        }
    }
}
