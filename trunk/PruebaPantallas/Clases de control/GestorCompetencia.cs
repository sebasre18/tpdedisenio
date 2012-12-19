using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_control
{
    public class GestorCompetencia
    {
        Clases_ABD.ABDcompetencia competenciaABD = new Clases_ABD.ABDcompetencia();
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
        
        /*public Clases_de_entidad.TablaPosiciones verTabla(Clases_de_entidad.CompetenciaDeportiva competencia)
        {
            Clases_de_entidad.TablaPosiciones tablaPos = new Clases_de_entidad.TablaPosiciones();
        //    tablaPos = Clases_ABD.ABDcompetencia.getTabla(competencia);
            return tablaPos;
        }*/

        public short compararNombre(string nombre)
        {
            //comparar nombre con la BD para ver si existe. Retorna 1 o 0.
            short existe = 0; // retornar short porque con boolean no andan las comparaciones!
            return existe;
        }

        public void setCompetencia(string unEstado, string unNombre, string unReglamento, Clases_de_entidad.Deporte unDeporte, List<Clases_de_entidad.LugarDeRealizacion> listaLugares, Clases_de_entidad.Modalidad unaModalidad, Clases_de_entidad.Usuario unUsuario)
        {
        }
    }
}
