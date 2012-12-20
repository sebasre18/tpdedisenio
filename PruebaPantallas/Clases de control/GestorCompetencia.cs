using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_control
{
    public class GestorCompetencia
    {
        private Clases_ABD.ABDcompetencia competenciaABD = new Clases_ABD.ABDcompetencia();

        public List<Clases_de_entidad.Deporte> buscarDeportes()
        {
            List<Clases_de_entidad.Deporte> deportes = new List<Clases_de_entidad.Deporte>();
            //busca de la BD una coleccion con todos los deportes disponibles.
            deportes = competenciaABD.getDeportes();
            return deportes;
        }

        public List<Clases_de_entidad.Modalidad> buscarModalidades()
        {
            List<Clases_de_entidad.Modalidad> listaModalidades = new List<Clases_de_entidad.Modalidad>();
            //busca de la BD una coleccion con todas las modalidades disponibles.
            listaModalidades = competenciaABD.getModalidades();
            return listaModalidades;
        }

        public List<Clases_de_entidad.FormaPuntuacion> buscarFormasDePuntuacion()
        {
            List<Clases_de_entidad.FormaPuntuacion> listaFormas = new List<Clases_de_entidad.FormaPuntuacion>();
            //busca de la BD una coleccion con todas las formas de puntuacion disponibles.
            listaFormas = competenciaABD.getFormasDePuntuacion();
            return listaFormas;
        }
        
        public Clases_de_entidad.TablaPosiciones verTabla(Clases_de_entidad.CompetenciaDeportiva competencia)
        {
            Clases_de_entidad.TablaPosiciones tablaPos = new Clases_de_entidad.TablaPosiciones();
        //    tablaPos = Clases_ABD.ABDcompetencia.getTabla(competencia);
            return tablaPos;
        }

        public Boolean compararNombre(string nombreComp)
        {
            //comparar nombre con la BD para ver si existe. Retorna 1 o 0.
            return competenciaABD.compareNombre(nombreComp);
        }

        public List<Clases_de_entidad.CompetenciaDeportiva> buscarCompetencias(Clases_de_entidad.Usuario usuarioAutenticado)
        {
            List<Clases_de_entidad.CompetenciaDeportiva> listaCompetencias = new List<Clases_de_entidad.CompetenciaDeportiva>();
            //busca de la BD una coleccion con todas las competencias creadas por un usuario
            return listaCompetencias = competenciaABD.getCompetencias(usuarioAutenticado);
        }

        public Clases_de_entidad.CompetenciaDeportiva buscarUnaCompetencia(short unId_competencia)
        {
            Clases_de_entidad.CompetenciaDeportiva unaCompetencia = new Clases_de_entidad.CompetenciaDeportiva();
            //busca de la BD una competencia especifica con todos sus datos
            return unaCompetencia = competenciaABD.getUnaCompetencia(unId_competencia);
        }

        public void guardar(Clases_de_entidad.CompetenciaDeportiva unaCompetencia)
        {
            // Guarda una competencia nueva en la BD.
            competenciaABD.setCompetencia(unaCompetencia);
        }
    }
}
