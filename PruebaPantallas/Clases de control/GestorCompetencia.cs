using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_control
{
    public class GestorCompetencia
    {
        public List<Clases_de_entidad.Deporte> buscarDeportes()
        {
            //buscar de la BD una coleccion con todos los deportes disponibles.
        }

        public List<Clases_de_entidad.Modalidad> buscarModalidades()
        {
            //buscar de la BD una coleccion con todos las modalidades disponibles.
        }
        
        /* public Clases_de_entidad.TablaPosiciones verTabla(Clases_de_entidad.CompetenciaDeportiva competencia)
        {
            Clases_ABD.ABDcompetencia ABDcompetencia = new Clases_ABD.ABDcompetencia();
            Clases_de_entidad.TablaPosiciones tablaPos;
            tablaPos = Clases_ABD.ABDcompetencia.getTabla(competencia);
        }*/
    }
}
