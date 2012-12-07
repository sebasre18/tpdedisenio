using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_control
{
    public class GestorCompetencia
    {
        public Clases_de_entidad.TablaPosiciones verTabla(Clases_de_entidad.CompetenciaDeportiva competencia)
        {
            Clases_ABD.ABDcompetencia ABDcompetencia = new Clases_ABD.ABDcompetencia();
            Clases_de_entidad.TablaPosiciones tablaPos = Clases_ABD.ABDcompetencia.getTabla(competencia);
        }
    }
}
