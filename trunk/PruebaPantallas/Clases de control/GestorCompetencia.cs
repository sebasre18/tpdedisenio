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
            List<Clases_de_entidad.Deporte> deporte = new List<Clases_de_entidad.Deporte>();
            //buscar de la BD una coleccion con todos los deportes disponibles.
            return deporte;
        }

        public List<Clases_de_entidad.Modalidad> buscarModalidades()
        {
            List<Clases_de_entidad.Modalidad> modalidad = new List<Clases_de_entidad.Modalidad>();
            //buscar de la BD una coleccion con todos las modalidades disponibles.
            return modalidad;
        }
        
        /* public Clases_de_entidad.TablaPosiciones verTabla(Clases_de_entidad.CompetenciaDeportiva competencia)
        {
            Clases_ABD.ABDcompetencia ABDcompetencia = new Clases_ABD.ABDcompetencia();
            Clases_de_entidad.TablaPosiciones tablaPos;
            tablaPos = Clases_ABD.ABDcompetencia.getTabla(competencia);
        }*/
    }
}
