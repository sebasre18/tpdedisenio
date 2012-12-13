using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_ABD
{
    public class ABDcompetencia
    {
        public Clases_de_entidad.TablaPosiciones getTabla(Clases_de_entidad.CompetenciaDeportiva unaCompetencia)
        {
            return unaCompetencia._tablaPosiciones;
        }

        public static void setEstado(short unId_competencia, string unEstado)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var competencia = from unaCompetencia in db.CompetenciaDeportiva where (unaCompetencia.id_competencia == unId_competencia) select unaCompetencia;

            foreach (var seleccionada in competencia)
            {
                seleccionada.Estado = unEstado;
                db.SubmitChanges();
            }
        }

        public List<Clases_de_entidad.Deporte> getDeportes()
        {
            List<Clases_de_entidad.Deporte> listaDeportes = new List<Clases_de_entidad.Deporte>();
            DataClasses1DataContext db = new DataClasses1DataContext();

            var dep = from deportes in db.Deporte select deportes;

            foreach (var deporte in dep)
            {
                Clases_de_entidad.Deporte unDeporte = new Clases_de_entidad.Deporte();
                unDeporte._id_deporte = deporte.id_deporte;
                unDeporte._nombre = deporte.nombre;
                listaDeportes.Add(unDeporte);
            }

            return listaDeportes;
        }

        public List<Clases_de_entidad.Modalidad> getModalidades()
        {
            List<Clases_de_entidad.Modalidad> listaModalidades = new List<Clases_de_entidad.Modalidad>();
            DataClasses1DataContext db = new DataClasses1DataContext();

            var mod = from modalidades in db.Modalidad select modalidades;

            foreach (var modalidad in mod)
            {
                Clases_de_entidad.Modalidad unaModalidad = new Clases_de_entidad.Modalidad();
                unaModalidad._id_modalidad = modalidad.id_modalidad;
                unaModalidad._nombreMod = modalidad.nombre;
                listaModalidades.Add(unaModalidad);
            }

            return listaModalidades;
        }

        public List<Clases_de_entidad.FormaPuntuacion> getFormasDePuntuacion()
        {
            List<Clases_de_entidad.FormaPuntuacion> listaFormasDePuntuacion = new List<Clases_de_entidad.FormaPuntuacion>();
            DataClasses1DataContext db = new DataClasses1DataContext();

            var fp = from formas in db.Forma_de_Puntuacion select formas;

            foreach (var forma in fp)
            {
                Clases_de_entidad.FormaPuntuacion unaFormaDePuntuacion = new Clases_de_entidad.FormaPuntuacion();
                unaFormaDePuntuacion._id_forma = forma.id_forma;
                unaFormaDePuntuacion._nombreForma = forma.nombre;
                listaFormasDePuntuacion.Add(unaFormaDePuntuacion);
            }

            return listaFormasDePuntuacion;
        }
    }
}
