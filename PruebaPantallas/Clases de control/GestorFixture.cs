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

            //asigno un "equipo fantasma" para poder realizar el ordenamiento de partidos
            if (cantParticipantes % 2 == 1)
            {
                equipoFantasma = 1;
                Clases_de_entidad.Participante partFantasma = new Clases_de_entidad.Participante();
                partFantasma._nombre = "equipoFantasma";
                listaParticipantes.Add(partFantasma);
                cantParticipantes = cantParticipantes + equipoFantasma;
            }

            for (int nroRonda = 0; nroRonda < (cantParticipantes - 1); nroRonda++) //cantidad de participantes = cantidad de rondas (fechas)
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
                        //se crea el partido con dos participantes
                        Clases_de_entidad.Partido partido = new Clases_de_entidad.Partido();
                        partido._participantes = new List<Clases_de_entidad.Participante>();
                        if ((i == 0) && (nroRonda % 2 == 1))
                        {
                            partido._participantes.Add(listaParticipantes[i]);                      //primer partido: primer part vs ultimo part; segundo partido: segundo part vs ante-ultimo part; etc
                            partido._participantes.Add(listaParticipantes[(cantParticipantes - 1) - i]);
                        }
                        else
                        {
                            partido._participantes.Add(listaParticipantes[(cantParticipantes - 1) - i]);
                            partido._participantes.Add(listaParticipantes[i]);                      //se rotan los partidos impares
                        }
                        ronda._partidos.Add(partido);                          //si hay equipo fantasma se ubican los partidos una posicion anterior en la lista (2do partido en primer lugar)
                    }
                };
                //se agrega la ronda al fixture
                fixture._rondas.Add(ronda);

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
    }
}
