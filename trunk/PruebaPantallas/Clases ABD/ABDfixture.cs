using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_ABD
{
    class ABDfixture
    {
        //Setea resultado para FormaPuntuacion por puntos
        public void setResultadoPtos(Clases_de_entidad.Partido unPartido, int ptosP1, int ptosP2)
        {
            //Aca va a la base de datos el resultado del partido seleccionado

        }

        //Setea resultado para FormaPuntuacion por resultado final
        public void setResultadoGanador(Clases_de_entidad.Partido unPartido, Clases_de_entidad.Participante ganador)
        {
            //Aca va a la base de datos el resultado del partido seleccionado

        }

        //Setea resultado para FormaPuntuacion por resultado final que esa empate
        public void setResultadoGanadorEmp(Clases_de_entidad.Partido unPartido, bool empate)
        {
            //Aca va a la base de datos el resultado del partido seleccionado

        }

        //Setea resultado para FormaPuntuacion por sets
        public void setResultadoSets(Clases_de_entidad.Partido unPartido, List<Clases_de_entidad.Set> sets)
        {
            //Aca va a la base de datos el resultado del partido seleccionado

        }

    }
}
