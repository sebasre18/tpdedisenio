using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_ABD
{
    public class ABDcompetencia
    {
        public Clases_de_entidad.TablaPosiciones getTabla(Clases_de_entidad.CompetenciaDeportiva competencia)
        {
            return competencia._tablaPosiciones;
        }
    }
}
