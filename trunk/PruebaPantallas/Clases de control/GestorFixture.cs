using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_control
{
    public class GestorFixture
    {
        //funcion para Generar el Fixture de Modalidad Liga
        public Clases_de_entidad.Fixture generarFixtureLiga(List<Clases_de_entidad.Participante> listaParticipantes)
        {
            int cantParticipantes = 0, equipoFantasma = 0;
            Clases_de_entidad.Fixture fixture = new Clases_de_entidad.Fixture();
            fixture._rondas = new List<Clases_de_entidad.Ronda>();

            cantParticipantes = listaParticipantes.Count;

            //agrego un "equipo fantasma" a la lista de participantes para poder realizar el ordenamiento de partidos
            if (cantParticipantes % 2 == 1)
            {
                equipoFantasma = 1;
                Clases_de_entidad.Participante partFantasma = new Clases_de_entidad.Participante();
                partFantasma._nombre = "EQUIPOFANTASMA";
                listaParticipantes.Add(partFantasma);
                cantParticipantes = cantParticipantes + equipoFantasma;
            }

            for (short nroRonda = 1; nroRonda < cantParticipantes ; nroRonda++) //cantidad de participantes = cantidad de rondas (fechas)
            {
                Clases_de_entidad.Ronda ronda = new Clases_de_entidad.Ronda();
                ronda._partidos = new List<Clases_de_entidad.Partido>();
                ronda._nro_ronda = nroRonda;

                //si hay impar cant de participantes se setea el que queda libre en cada ronda
                if (equipoFantasma == 1)
                    ronda._libre = listaParticipantes[0];

                for (int i = 0; i < (cantParticipantes / 2); i++)
                {
                    if ((equipoFantasma == 0) || (i != 0)) //en caso de que haya participante libre no se crea el primer partido ya q el primer part es el libre y el ultimo el equipo fantasma
                    {
                        Clases_de_entidad.Partido partido = new Clases_de_entidad.Partido();
                        partido._pParticipantes = new List<Clases_de_entidad.PartidoParticipante>();
                        Clases_de_entidad.PartidoParticipante participante1 = new Clases_de_entidad.PartidoParticipante();
                        Clases_de_entidad.PartidoParticipante participante2 = new Clases_de_entidad.PartidoParticipante();
                        participante1._participante = listaParticipantes[i];
                        participante2._participante = listaParticipantes[(cantParticipantes - 1) - i];

                        if ((i == 0) && (nroRonda % 2 == 0))
                        {
                            //primer partido: primer part vs ultimo part; segundo partido: segundo part vs ante-ultimo part; etc
                            partido._pParticipantes.Add(participante1);
                            partido._pParticipantes.Add(participante2);
                        }
                        else
                        {
                            //se rotan los partidos pares para cambiar la condicion de localia
                            partido._pParticipantes.Add(participante2);
                            partido._pParticipantes.Add(participante1);
                        }
                        ronda._partidos.Add(partido);
                    }
                }
                //se agrega la ronda al fixture
                fixture._rondas.Add(ronda);
                fixture._rondaActual = 1;

                //ROTAMOS la lista de participantes para que los encuentros no se repitan Ej L: 0,1,2,3,4
                Clases_de_entidad.Participante partEstatico = new Clases_de_entidad.Participante();
                Clases_de_entidad.Participante partTemp = new Clases_de_entidad.Participante();
                //se determina el ultimo elemento de la lista y se lo elimina (elemento que queda en la ultima posicion, estatico) L: 0,1,2,3
                partEstatico = listaParticipantes.Last();
                listaParticipantes.Remove(partEstatico);
                //se determina el ultimo elemento de la lista y se lo elimina (elemento que luego se coloca al principio de la lista) L: 0,1,2
                partTemp = listaParticipantes.Last();
                listaParticipantes.Remove(partTemp);
                //se invierte la lista y se coloca el part temporal al principio de la lista L: 3,0,1,2
                listaParticipantes.Reverse();
                listaParticipantes.Add(partTemp);
                listaParticipantes.Reverse();
                //se invierte la lista nuevamente y se coloca el part estatico al final de la lista L: 3,0,1,2,4
                listaParticipantes.Add(partEstatico);
            }

            return fixture;
        }


        //
        //METODOS PARA GUARDAR EN BASE DE DATOS LOS RESULTADOS!!
        //

        public Clases_de_entidad.Partido guardaResultado(Clases_de_entidad.Partido unPartido)
        {
            Clases_ABD.ABDfixture ABDfix = new Clases_ABD.ABDfixture();

            unPartido._resultado._id_resultado = ABDfix.setResultado(unPartido);

            creaHistorialResultado(unPartido);

            ABDfix.creaHistorialResultado(unPartido._resultado._histResultado[unPartido._resultado._histResultado.Count - 1]);

            return unPartido;
        }

        public Clases_de_entidad.Partido creaHistorialResultado(Clases_de_entidad.Partido unPartido)
        {
            Clases_de_entidad.HistorialResultado histRes = new Clases_de_entidad.HistorialResultado();

            if (unPartido._resultado._ausente != null)
                histRes._ausente = unPartido._resultado._ausente;
            histRes._cantidad_set = unPartido._resultado._cantidad_set;
            histRes._empate = unPartido._resultado._empate;
            if (unPartido._resultado._ganador != null)
                histRes._ganador = unPartido._resultado._ganador;
//            histRes._id_partido = unPartido._id_partido;
            histRes._id_resultado = unPartido._resultado._id_resultado;
            histRes._puntosP1 = unPartido._resultado._puntosP1;
            histRes._puntosP2 = unPartido._resultado._puntosP2;

            if (unPartido._resultado._cantidad_set > 0)
            {
                histRes._sets = new List<Clases_de_entidad.Set>();
                for (int i = 0; i < unPartido._resultado._cantidad_set; i++)
                {
                    Clases_de_entidad.Set set = new Clases_de_entidad.Set();
                    set._puntosP1 = unPartido._resultado._sets[i]._puntosP1;
                    set._puntosP2 = unPartido._resultado._sets[i]._puntosP2;
                    set._id_set = unPartido._resultado._sets[i]._id_set;
                    histRes._sets.Add(set);
                }
            }
            histRes._fecha_modificacion = DateTime.Now;

            if (unPartido._resultado._histResultado == null)
                unPartido._resultado._histResultado = new List<Clases_de_entidad.HistorialResultado>();
            
            unPartido._resultado._histResultado.Add(histRes);
            
            return unPartido;
        }

        public string cambiarEstado(Clases_de_entidad.CompetenciaDeportiva unaCompetencia, string unEstado)
        {
            Clases_ABD.ABDcompetencia competenciaABD = new Clases_ABD.ABDcompetencia();
            Clases_ABD.ABDfixture fixtureABD = new Clases_ABD.ABDfixture();

            switch (unEstado)
            {
                case "DISPUTA":
                    competenciaABD.setEstado(unaCompetencia._id_competencia, unEstado);
                    break;
                case "FINALIZADA":
                    competenciaABD.setEstado(unaCompetencia._id_competencia, unEstado);
                    break;
                case "RONDA":
                    fixtureABD.setRondaActual(unaCompetencia._fixture._id_fixture);
                    break;
            }
            return unEstado;
        }
    }
}
