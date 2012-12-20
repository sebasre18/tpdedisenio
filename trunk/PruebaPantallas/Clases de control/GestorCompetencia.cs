using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_control
{
    public class GestorCompetencia
    {
        private Clases_ABD.ABDcompetencia competenciaABD = new Clases_ABD.ABDcompetencia();

        //busca de la BD una coleccion con todos los deportes disponibles.
        public List<Clases_de_entidad.Deporte> buscarDeportes()
        {
            List<Clases_de_entidad.Deporte> deportes = new List<Clases_de_entidad.Deporte>();
            return deportes = competenciaABD.getDeportes();
        }


        //busca de la BD una coleccion con todas las modalidades disponibles.
        public List<Clases_de_entidad.Modalidad> buscarModalidades()
        {
            List<Clases_de_entidad.Modalidad> listaModalidades = new List<Clases_de_entidad.Modalidad>();
            return listaModalidades = competenciaABD.getModalidades();
        }


        //busca de la BD una coleccion con todas las formas de puntuacion disponibles.
        public List<Clases_de_entidad.FormaPuntuacion> buscarFormasDePuntuacion()
        {
            List<Clases_de_entidad.FormaPuntuacion> listaFormas = new List<Clases_de_entidad.FormaPuntuacion>();
            return listaFormas = competenciaABD.getFormasDePuntuacion();            
        }
        


        public Clases_de_entidad.TablaPosiciones verTabla(short unId_competencia)
        {
            Clases_de_entidad.TablaPosiciones tablaPos = new Clases_de_entidad.TablaPosiciones();
            return tablaPos = competenciaABD.getTabla(unId_competencia);
        }


        //comparar nombre con la BD para ver si existe. Retorna 1 o 0.
        public Boolean compararNombre(string nombreComp)
        {
            return competenciaABD.compareNombre(nombreComp);
        }


        //busca de la BD una coleccion con todas las competencias creadas por un usuario
        public List<Clases_de_entidad.CompetenciaDeportiva> buscarCompetencias(Clases_de_entidad.Usuario usuarioAutenticado)
        {
            List<Clases_de_entidad.CompetenciaDeportiva> listaCompetencias = new List<Clases_de_entidad.CompetenciaDeportiva>();
            return listaCompetencias = competenciaABD.getCompetencias(usuarioAutenticado);
        }


        //busca de la BD una competencia especifica con todos sus datos
        public Clases_de_entidad.CompetenciaDeportiva buscarUnaCompetencia(short unId_competencia)
        {
            Clases_de_entidad.CompetenciaDeportiva unaCompetencia = new Clases_de_entidad.CompetenciaDeportiva();
            return unaCompetencia = competenciaABD.getUnaCompetencia(unId_competencia);
        }


        // Guarda una competencia nueva en la BD.
        public void guardar(Clases_de_entidad.CompetenciaDeportiva unaCompetencia)
        {
            competenciaABD.setCompetencia(unaCompetencia);
        }
    }
}
