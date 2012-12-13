using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_ABD
{
    public class ABDfixture
    {
        public void deleteFixture(Clases_de_entidad.CompetenciaDeportiva unaCompetencia)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            //Selecciono el fixture que este relacionado con la competencia
            var borrarFixture = from unFixture in db.Fixture
                                where (unFixture.id_competencia == unaCompetencia._id_competencia)
                                select unFixture;

            foreach (var seleccionado in borrarFixture)
            {
                db.Fixture.DeleteOnSubmit(seleccionado);
                db.SubmitChanges();
            }
        }

        public void guardarFixture(Clases_de_entidad.CompetenciaDeportiva unaCompetencia)
        {    
            DataClasses1DataContext db = new DataClasses1DataContext();
            //Se guarda el fixture con sus atributos
            Fixture nuevo = new Fixture();
            nuevo.id_competencia = unaCompetencia._id_competencia;
            nuevo.id_ronda_actual = unaCompetencia._fixture._rondaActual;
            db.Fixture.InsertOnSubmit(nuevo);
            db.SubmitChanges(); 

            //Se guarda cada una de las rondas asignandolas al fixture creado
            foreach (Clases_de_entidad.Ronda unaRonda in unaCompetencia._fixture._rondas)
            {
                Ronda ronda = new Ronda();
                ronda.nro_ronda = unaRonda._nro_ronda;
                if (unaRonda._libre != null)
                    ronda.id_libre = unaRonda._libre._id_participante;
                ronda.id_fixture = nuevo.id_fixture;
                db.Ronda.InsertOnSubmit(ronda);
                db.SubmitChanges(); 
                
                //Por cada ronda se guardan los partidos que pertenecen a la ronda
                foreach (Clases_de_entidad.Partido unPartido in unaRonda._partidos)
                {
                    Partido partido = new Partido();
                    partido.id_ronda = ronda.id_ronda;
                    db.Partido.InsertOnSubmit(partido);
                    db.SubmitChanges(); 

                    Partido_Participante partidoParticipante1 = new Partido_Participante();
                    partidoParticipante1.id_partido = partido.id_partido;
                    partidoParticipante1.id_participante = unPartido._pParticipantes[0]._participante._id_participante;
                    db.Partido_Participante.InsertOnSubmit(partidoParticipante1);
                    db.SubmitChanges(); 

                    Partido_Participante partidoParticipante2 = new Partido_Participante();
                    partidoParticipante2.id_partido = partido.id_partido;
                    partidoParticipante2.id_participante = unPartido._pParticipantes[1]._participante._id_participante;
                    db.Partido_Participante.InsertOnSubmit(partidoParticipante2);
                    db.SubmitChanges();   
                }
            }

            //Se setea la competencia como PLANIFICADA en la BD
            ABDcompetencia.setEstado(unaCompetencia._id_competencia, unaCompetencia._estado);
        }
        
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
