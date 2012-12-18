using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_control
{
    public class GestorTabla
    {
        int numParticipantes;

        public void creaRenglones(Clases_de_entidad.CompetenciaDeportiva unaCompetencia)
        {
            numParticipantes = unaCompetencia._participantes.Count;
            for (short i = 0; i < numParticipantes; i++)
            {
                Clases_de_entidad.renglonTabla renglon = new Clases_de_entidad.renglonTabla(i, 0, 0, 0, 0, 0, 0, 0, unaCompetencia._participantes[i]._id_participante, unaCompetencia._participantes[i]._nombre);
            }
            //PREG A ANDRES SI "TABLA-PARTICIPANTE" EN EL DATACLASSES SERIA EL RENGLON-TABLA POR CADA PARTICIPANTE...
        }

        public void actualizaRenglon(Clases_de_entidad.Participante unParticipante, Clases_de_entidad.Resultado unResultado, Clases_de_entidad.CompetenciaDeportiva unaCompetencia)
        {

        }
    }
}
