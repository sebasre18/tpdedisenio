using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Partido
    {
        //Atributos
        private short id_partido;
        private Resultado resultado;
        private List<PartidoParticipante> pParticipantes;

        //Propiedades
        public short _id_partido
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
        public List<PartidoParticipante> _pParticipantes
        {
            get
            {
                return pParticipantes;
            }
            set
            {
                pParticipantes = value;
            }
        }

        //Constructor
        public Partido() { }

        public Partido(short unId_partido, Resultado resultado, List<PartidoParticipante> listaParticipantes)
        {
            this._id_partido = unId_partido;
            this._resultado = resultado;
            this._pParticipantes = listaParticipantes;
        }
    }
}
