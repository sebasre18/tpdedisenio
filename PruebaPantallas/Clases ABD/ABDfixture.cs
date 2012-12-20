using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_ABD
{
    public class ABDfixture
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
//        ABDcompetencia competenciaABD = new ABDcompetencia();


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
        public void guardarFixture(Clases_de_entidad.CompetenciaDeportiva unaCompetencia)
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
                }
            }
            //Se setea la competencia como PLANIFICADA en la BD
            ABDcompetencia competenciaABD = new ABDcompetencia();
            competenciaABD.setEstado(unaCompetencia._id_competencia, unaCompetencia._estado);
        }



        //retorna el fixture de una competencia
        //TERMINAR
        public Clases_de_entidad.Fixture getFixture(short unId_competencia)
        {
            Clases_de_entidad.Fixture fixture = new Clases_de_entidad.Fixture();
            return fixture;
        }


        //Setea los datos en el resultado
        public void setResultado(Clases_de_entidad.Partido unPartido)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            if (unPartido._resultado == null)
                creaResultado(unPartido);
            else
            {
                var result = from unResultado in db.Resultado where (unPartido._resultado._id_resultado == unResultado.id_rdo) select unResultado;
                foreach (var seleccionado in result)
                {
                    seleccionado.cantSets = unPartido._resultado._cantidad_set;
                    //seleccionado.empate = unPatido._resultado._empate;   PASAR DE BOOLEAN A BINARY NO SE COMO SE HACE.
                    seleccionado.id_ganador = unPartido._resultado._ganador._id_participante;
                    seleccionado.puntosP1 = unPartido._resultado._puntosP1;
                    seleccionado.puntosP2 = unPartido._resultado._puntosP2;
                    seleccionado.Rdo_Partido[0].id_ausente = unPartido._resultado._ausente._id_participante;
                    seleccionado.Rdo_Partido[0].id_partido = unPartido._id_partido;
                    seleccionado.Rdo_Partido[0].id_rdo = unPartido._resultado._id_resultado;
                    for (short i = 0; i < unPartido._resultado._cantidad_set; i++)
                    {
                        Set set = new Set();
                        set.puntosP1 = unPartido._resultado._sets[i]._puntosP1;
                        set.puntosP2 = unPartido._resultado._sets[i]._puntosP2;
                        set.nro_set = i;
                        db.Set.InsertOnSubmit(set);
                    }
                    db.SubmitChanges();
                }
            }
        }

        
        //Se crea el resultado en la BD
        public void creaResultado(Clases_de_entidad.Partido unPartido)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Resultado result = new Resultado();

            result.cantSets = null;
            result.empate = false;
            result.id_ganador = null;
            result.puntosP1 = null;
            result.puntosP2 = null;
            result.Rdo_Partido[0].id_ausente = null;
            result.Rdo_Partido[0].id_partido = unPartido._id_partido;
            result.Rdo_Partido[0].id_rdo = null; //Noc si se setea esto.
            for (short i = 1; i <= unPartido._resultado._cantidad_set; i++)
            {
                Set set = new Set();
                set.puntosP1 = null;
                set.puntosP2 = null;
                set.nro_set = i;
                db.Set.InsertOnSubmit(set);
            }



        }

        //REVEER... ver lo de los sets...
        public void creaHistorialResultado(Clases_de_entidad.HistorialResultado unHistorial)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Historial_de_Resultado histRes = new Historial_de_Resultado();

            histRes.empate = unHistorial._empate;
            histRes.ganador = unHistorial._ganador._id_participante; //Se guarda el id del participante ganador
            histRes.id_rdo = unHistorial._id_resultado;
            histRes.fecha = unHistorial._fecha_modificacion;
            histRes.puntosP1 = unHistorial._puntosP1;
            histRes.puntosP2 = unHistorial._puntosP2;
            histRes.nro_set = Convert.ToInt16(unHistorial._cantidad_set);

            db.SubmitChanges();

        }
    }

}
