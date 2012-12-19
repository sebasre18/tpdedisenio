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

        public void setEstado(short unId_competencia, string unEstado)
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

        public void setRenglon(Clases_de_entidad.renglonTabla unRenglon)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var renglon = from renglonTabla in db.Tabla_Participante where (renglonTabla.id_tabla == unRenglon._id_renglonTabla) select unRenglon;

            foreach (var seleccionado in renglon)
            {
                seleccionado._id_renglonTabla = unRenglon._id_renglonTabla;
                seleccionado._id_participante = unRenglon._id_participante;
                seleccionado._nombreParticipante = unRenglon._nombreParticipante;
                seleccionado._diferencia = unRenglon._diferencia;
                seleccionado._golesContra = unRenglon._golesContra;
                seleccionado._golesFavor = unRenglon._golesFavor;
                seleccionado._pEmpatado = unRenglon._pEmpatado;
                seleccionado._pGanado = unRenglon._pGanado;
                seleccionado._pPerdido = unRenglon._pPerdido;
                seleccionado._pts = unRenglon._pts;
                db.SubmitChanges();
            }
        }

        public void crearRenglon(Clases_de_entidad.CompetenciaDeportiva unaCompetencia)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Tabla_de_Posiciones tablaPos = new Tabla_de_Posiciones();
            tablaPos.id_competencia = unaCompetencia._id_competencia;
            db.SubmitChanges();
            foreach ()
            {
                Tabla_Participante tablaPart = new Tabla_Participante();
                unaCompetencia._tablaPosiciones._renglones
                tablaPart.
            }

        }
    }
}
