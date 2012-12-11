using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{    
    public class PartidoParticipante
    {
        //Atributos
        private Participante participante;

        //Propiedades
        public Participante _participante
        {
            get
            {
                return participante;
            }
            set
            {
                participante = value;
            }
        }
        
        public PartidoParticipante() { }

        public PartidoParticipante(Participante unParticipante)
        {
            this._participante = unParticipante;
        }
    }
}
