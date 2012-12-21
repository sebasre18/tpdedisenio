using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_ABD
{
    public class ABDfixture
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        //elimina el fixture de una competencia
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


        //guarda el fixture de una competencia
        public Clases_de_entidad.Fixture guardarFixture(Clases_de_entidad.CompetenciaDeportiva unaCompetencia)
        {    
            //Se guarda el fixture con sus atributos
            Fixture nuevo = new Fixture();
            nuevo.id_competencia = unaCompetencia._id_competencia;
            nuevo.ronda_actual = unaCompetencia._fixture._rondaActual;
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
                    
                    unPartido._id_partido = partido.id_partido;
                }
            }
            unaCompetencia._fixture._id_fixture = nuevo.id_fixture;

            //Se setea la competencia como PLANIFICADA en la BD
            ABDcompetencia competenciaABD = new ABDcompetencia();
            competenciaABD.setEstado(unaCompetencia._id_competencia, unaCompetencia._estado);
            return unaCompetencia._fixture;
        }


        //Setea los datos en el resultado
        public short setResultado(Clases_de_entidad.Partido unPartido)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            int entro = 0;
            var resultados = from result in db.Rdo_Partido where (result.id_partido == unPartido._id_partido) select result;

            foreach (var unResultado in resultados)
            {
                entro = 1;
                unResultado.Resultado.cantSets = unPartido._resultado._cantidad_set;
                unResultado.Resultado.empate = unPartido._resultado._empate;
                if (unPartido._resultado._ganador != null)
                    unResultado.Resultado.id_ganador = unPartido._resultado._ganador._id_participante;
                unResultado.Resultado.puntosP1 = unPartido._resultado._puntosP1;
                unResultado.Resultado.puntosP2 = unPartido._resultado._puntosP2;
                //unResultado.id_partido = unPartido._id_partido;
                if (unPartido._resultado._ausente != null)
                    unResultado.id_ausente = unPartido._resultado._ausente._id_participante;
                //unResultado.id_rdo = unPartido._resultado._id_resultado;
                for (short i = 0; i < unPartido._resultado._cantidad_set; i++)
                {
                    unResultado.Resultado.Set[i + 1].puntosP1 = unPartido._resultado._sets[i]._puntosP1;
                    unResultado.Resultado.Set[i + 1].puntosP2 = unPartido._resultado._sets[i]._puntosP2;
                    //db.Set.InsertOnSubmit(unResultado.Resultado.Set[i + 1]);
                    db.SubmitChanges();
                }
                db.SubmitChanges();
                return unResultado.id_rdo;
            }
            if (entro == 0)
                unPartido._resultado._id_resultado = creaResultado(unPartido);
            return unPartido._resultado._id_resultado;
        }

        
        //Se crea el resultado en la BD
        public short creaResultado(Clases_de_entidad.Partido unPartido)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Resultado result = new Resultado();
            Rdo_Partido nuevo = new Rdo_Partido();
            
            result.cantSets = unPartido._resultado._cantidad_set;
            result.empate = unPartido._resultado._empate;
            if (unPartido._resultado._ganador != null)
                result.id_ganador = unPartido._resultado._ganador._id_participante;
            result.puntosP1 = unPartido._resultado._puntosP1;
            result.puntosP2 = unPartido._resultado._puntosP2;            
            db.Resultado.InsertOnSubmit(result);
            db.SubmitChanges();

            nuevo.id_partido = unPartido._id_partido;
            if (unPartido._resultado._ausente != null)
                nuevo.id_ausente = unPartido._resultado._ausente._id_participante;
            nuevo.id_rdo = result.id_rdo;
            db.Rdo_Partido.InsertOnSubmit(nuevo);
            db.SubmitChanges();

            for (short i = 0; i < unPartido._resultado._cantidad_set; i++)
            {
                Set set = new Set();
                set.puntosP1 = unPartido._resultado._sets[i]._puntosP1;
                set.puntosP2 = unPartido._resultado._sets[i]._puntosP2;
                set.nro_set = i;
                set.id_rdo = result.id_rdo;
                db.Set.InsertOnSubmit(set);
                db.SubmitChanges();
            }
            return result.id_rdo;
        }


        //Crea el historial de resultado
        public void creaHistorialResultado(Clases_de_entidad.HistorialResultado unHistorial)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Historial_de_Resultado histRes = new Historial_de_Resultado();

            histRes.empate = unHistorial._empate;
            if (unHistorial._ganador != null)
                histRes.ganador = unHistorial._ganador._id_participante; //Se guarda el id del participante ganador
            histRes.id_rdo = unHistorial._id_resultado;
            histRes.fecha = unHistorial._fecha_modificacion;
            histRes.puntosP1 = unHistorial._puntosP1;
            histRes.puntosP2 = unHistorial._puntosP2;
            histRes.nro_set = Convert.ToInt16(unHistorial._cantidad_set);
            if (unHistorial._ausente != null)
                histRes.ausente = unHistorial._ausente._id_participante;
            db.Historial_de_Resultado.InsertOnSubmit(histRes);
            db.SubmitChanges();
        }


        public void setRondaActual(short unId_fixture)
        {
            var listaFixtures = from fixtures in db.Fixture where (fixtures.id_fixture == unId_fixture) select fixtures;

            foreach (var unFixture in listaFixtures)
            {
                unFixture.ronda_actual = unFixture.ronda_actual + 1;
                db.SubmitChanges();
            }
        }
    }
}
