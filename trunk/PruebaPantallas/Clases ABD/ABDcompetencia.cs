using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_ABD
{
    public class ABDcompetencia
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        ABDfixture fixtureABD = new ABDfixture();
        ABDparticipante participanteABD = new ABDparticipante();
        ABDlugares lugaresABD = new ABDlugares();

        //retorna la tabla de posiciones 
        //TERMINAR
        public Clases_de_entidad.TablaPosiciones getTabla(short unId_competencia)
        {
            Clases_de_entidad.TablaPosiciones tablaPosiciones = new Clases_de_entidad.TablaPosiciones();

            var tablas = from tabla in db.Tabla_de_Posiciones where (tabla.id_competencia == unId_competencia) select tabla;


            return tablaPosiciones;
        }


        //setea el estado de la competencia PONER IF
        public void setEstado(short unId_competencia, string unEstado)
        {            
            var competencia = from unaCompetencia in db.CompetenciaDeportiva where (unaCompetencia.id_competencia == unId_competencia) select unaCompetencia;

            foreach (var seleccionada in competencia)
            {
                seleccionada.Estado = unEstado;
                db.SubmitChanges();
            }
        }


        //retorna la lista de todos los deportes para interfaz
        public List<Clases_de_entidad.Deporte> getDeportes()
        {
            List<Clases_de_entidad.Deporte> listaDeportes = new List<Clases_de_entidad.Deporte>();
            int existeNombre = 0;
            var dep = from deportes in db.Deporte select deportes;
            foreach (var deporte in dep)
            {
                existeNombre = 0;
                foreach (var unDep in listaDeportes)
                {
                    if (deporte.nombre == unDep._nombre)
                    {
                        existeNombre = 1;
                    }
                }
                if ((listaDeportes.Count == 0) || (existeNombre == 0))
                {
                    Clases_de_entidad.Deporte unDeporte = new Clases_de_entidad.Deporte();
                    unDeporte._id_deporte = deporte.id_deporte;
                    unDeporte._nombre = deporte.nombre;
                    listaDeportes.Add(unDeporte);
                }
            }
            return listaDeportes;
        }


        //retorna la lista de todas las modalidades para interfaz
        public List<Clases_de_entidad.Modalidad> getModalidades()
        {
            List<Clases_de_entidad.Modalidad> listaModalidades = new List<Clases_de_entidad.Modalidad>();            
            int existeNombre = 0;

            var mod = from modalidades in db.Modalidad select modalidades;
            foreach (var modalidad in mod)
            {
                existeNombre = 0;
                foreach (var unaMod in listaModalidades)
                {
                    if (modalidad.nombre == unaMod._nombreMod)
                    {
                        existeNombre = 1;
                    }
                }
                if ((listaModalidades.Count == 0) || (existeNombre == 0))
                {
                    Clases_de_entidad.Modalidad unaModalidad = new Clases_de_entidad.Modalidad();
                    unaModalidad._id_modalidad = modalidad.id_modalidad;
                    unaModalidad._nombreMod = modalidad.nombre;
                    listaModalidades.Add(unaModalidad);
                }
            }
            return listaModalidades;
        }


        //retorna la lista de todas las formas de puntuacion para interfaz
        public List<Clases_de_entidad.FormaPuntuacion> getFormasDePuntuacion()
        {
            List<Clases_de_entidad.FormaPuntuacion> listaFormasDePuntuacion = new List<Clases_de_entidad.FormaPuntuacion>();
            int existeNombre = 0;

            var fp = from formas in db.Forma_de_Puntuacion select formas;
            foreach (var forma in fp)
            {
                existeNombre = 0;
                foreach (var unaForma in listaFormasDePuntuacion)
                {
                    if (forma.nombre == unaForma._nombreForma)
                    {
                        existeNombre = 1;
                    }
                }
                if ((listaFormasDePuntuacion.Count == 0) || (existeNombre == 0))
                {
                    Clases_de_entidad.FormaPuntuacion unaFormaDePuntuacion = new Clases_de_entidad.FormaPuntuacion();
                    unaFormaDePuntuacion._id_forma = forma.id_forma;
                    unaFormaDePuntuacion._nombreForma = forma.nombre;
                    listaFormasDePuntuacion.Add(unaFormaDePuntuacion);
                }
            }
            return listaFormasDePuntuacion;
        }


        //retorna true si nombre de la competencia pasada por parametro existe en la BD
        public bool compareNombre(string nombreComp)
        {            
            var competencia = from competencias in db.CompetenciaDeportiva where (competencias.nombre == nombreComp) select competencias;
            foreach (var comp in competencia)
            {
                if (comp.nombre == nombreComp)
                    return true;
            }
            return false;
        }


        //retorna una lista de todas las competencias creadas por un usuario determinado
        public List<Clases_de_entidad.CompetenciaDeportiva> getCompetencias(Clases_de_entidad.Usuario usuarioAutenticado)
        {
            var competencia = from competencias in db.CompetenciaDeportiva where (competencias.e_mail_usuario == usuarioAutenticado._email) select competencias;
            List<Clases_de_entidad.CompetenciaDeportiva> listaCompetencias = new List<Clases_de_entidad.CompetenciaDeportiva>();
            //Se recorren cada una de las competencias creadas por el usuario
            foreach (var comp in competencia)
            {
                Clases_de_entidad.CompetenciaDeportiva unaCompetencia = new Clases_de_entidad.CompetenciaDeportiva();
                unaCompetencia._id_competencia = comp.id_competencia;
                unaCompetencia._estado = comp.Estado;
                unaCompetencia._nombre = comp.nombre;

                //se asigna el deporte asociado a la competencia
                unaCompetencia._deporte = new Clases_de_entidad.Deporte(comp.id_deporte, comp.Deporte.nombre);

                //se asigna la modalidad y la forma de puntuacion asociada a la competencia
                unaCompetencia._modalidad = new Clases_de_entidad.Modalidad();
                unaCompetencia._modalidad._id_modalidad = comp.Modalidad.id_modalidad;
                unaCompetencia._modalidad._nombreMod = comp.Modalidad.nombre;
                unaCompetencia._modalidad._ptosPG = Convert.ToInt32(comp.Modalidad.ptos_por_PG);
                unaCompetencia._modalidad._empate = Convert.ToBoolean(comp.Modalidad.empate);
                unaCompetencia._modalidad._ptosEmpate = Convert.ToInt32(comp.Modalidad.ptos_empate);
                unaCompetencia._modalidad._ptosPresentarse = Convert.ToInt32(comp.Modalidad.ptos_por_presentarse);

                unaCompetencia._modalidad._formaPuntuacion = new Clases_de_entidad.FormaPuntuacion(
                    comp.Modalidad.Forma_de_Puntuacion.id_forma, comp.Modalidad.Forma_de_Puntuacion.nombre,
                    Convert.ToInt16(comp.Modalidad.Forma_de_Puntuacion.cant_sets), Convert.ToInt16(comp.Modalidad.Forma_de_Puntuacion.tantos_x_ausencia_del_rival));
                listaCompetencias.Add(unaCompetencia);
            }
            return listaCompetencias;
        }


        //Retorna una competencia completa
        public Clases_de_entidad.CompetenciaDeportiva getUnaCompetencia(short unId_competencia)
        {
            var competencia = from competencias in db.CompetenciaDeportiva where (competencias.id_competencia == unId_competencia) select competencias;
            //Se recorren cada una de las competencias creadas por el usuario
            Clases_de_entidad.CompetenciaDeportiva unaCompetencia = new Clases_de_entidad.CompetenciaDeportiva();
            foreach (var comp in competencia)
            {
                unaCompetencia._id_competencia = comp.id_competencia;
                unaCompetencia._estado = comp.Estado;
                unaCompetencia._nombre = comp.nombre;
                unaCompetencia._reglamento = comp.Reglamento;
                
            //se asigna el deporte asociado a la competencia
                unaCompetencia._deporte = new Clases_de_entidad.Deporte(comp.id_deporte,comp.Deporte.nombre);

            //se asignan los lugares de realizacion para la competencia
                if (comp.Competencia_Lugar.Count > 0)
                {
                    unaCompetencia._lugaresDeRealizacion = new List<Clases_de_entidad.LugarDeRealizacion>();
                    foreach (var unLugar in comp.Competencia_Lugar)
                    {
                        Clases_de_entidad.LugarDeRealizacion unLugarDeRealizacion = new Clases_de_entidad.LugarDeRealizacion();
                        unLugarDeRealizacion._id_lugar = unLugar.Lugar_de_Realización.id_lugar;
                        unLugarDeRealizacion._disponibilidad = new Clases_de_entidad.Disponibilidad(Convert.ToInt32(unLugar.turnos_por_fecha));
                        unLugarDeRealizacion._nombre = unLugar.Lugar_de_Realización.Nombre;
                        unLugarDeRealizacion._descripcion = unLugar.Lugar_de_Realización.Descripción;
                        unaCompetencia._lugaresDeRealizacion.Add(unLugarDeRealizacion);
                    }
                }

            //se vincula el usuario autenticado a la competencia correspondiente
                unaCompetencia._usuario = new Clases_de_entidad.Usuario();
                unaCompetencia._usuario._email = comp.Usuario.e_mail;
                unaCompetencia._usuario._contraseña = comp.Usuario.contraseña;
                unaCompetencia._usuario._nombre = comp.Usuario.Nombre;
                unaCompetencia._usuario._apellido = comp.Usuario.Apellido;
                unaCompetencia._usuario._tipo_dni = comp.Usuario.tipo_DNI;
                unaCompetencia._usuario._nro_dni = Convert.ToInt32(comp.Usuario.nro_DNI);


            //se asigna la modalidad y la forma de puntuacion asociada a la competencia
                unaCompetencia._modalidad = new Clases_de_entidad.Modalidad();
                unaCompetencia._modalidad._id_modalidad = comp.Modalidad.id_modalidad;
                unaCompetencia._modalidad._nombreMod = comp.Modalidad.nombre;
                unaCompetencia._modalidad._ptosPG = Convert.ToInt32(comp.Modalidad.ptos_por_PG);
                unaCompetencia._modalidad._empate = Convert.ToBoolean(comp.Modalidad.empate);
                unaCompetencia._modalidad._ptosEmpate = Convert.ToInt32(comp.Modalidad.ptos_empate);
                unaCompetencia._modalidad._ptosPresentarse = Convert.ToInt32(comp.Modalidad.ptos_por_presentarse);

                unaCompetencia._modalidad._formaPuntuacion = new Clases_de_entidad.FormaPuntuacion(
                    comp.Modalidad.Forma_de_Puntuacion.id_forma, comp.Modalidad.Forma_de_Puntuacion.nombre, 
                    Convert.ToInt16(comp.Modalidad.Forma_de_Puntuacion.cant_sets), Convert.ToInt16(comp.Modalidad.Forma_de_Puntuacion.tantos_x_ausencia_del_rival));                                

            //se asigna la lista de participantes de la competencia
                unaCompetencia._participantes = new List<Clases_de_entidad.Participante>();
                foreach (var participante in comp.Participante)
                {
                    Clases_de_entidad.Participante unParticipante = new Clases_de_entidad.Participante(participante.id_participante, participante.nombre, participante.e_mail, participante.imagen, Convert.ToBoolean(participante.perdido), Convert.ToBoolean(participante.eliminado));
                    unaCompetencia._participantes.Add(unParticipante);
                }

            //se asigna la tabla de posiciones correspondiente a la competencia
                if (comp.Tabla_de_Posiciones.Count != 0)
                {
                    unaCompetencia._tablaPosiciones = new Clases_de_entidad.TablaPosiciones();
                    unaCompetencia._tablaPosiciones._id_tablaPos = comp.Tabla_de_Posiciones[0].id_tabla;
                    unaCompetencia._tablaPosiciones._renglones = new List<Clases_de_entidad.renglonTabla>();
                    foreach (var renglon in comp.Tabla_de_Posiciones[0].Tabla_Participante)
                    {
                        Clases_de_entidad.renglonTabla unRenglon = new Clases_de_entidad.renglonTabla(
                            renglon.id_renglon, Convert.ToInt32(renglon.PTS),
                            Convert.ToInt32(renglon.PG), Convert.ToInt32(renglon.PE),
                            Convert.ToInt32(renglon.PP), Convert.ToInt32(renglon.GF),
                            Convert.ToInt32(renglon.GC), Convert.ToInt32(renglon.D),
                            renglon.id_participante, renglon.nombrePart);
                        unaCompetencia._tablaPosiciones._renglones.Add(unRenglon);
                    }
                }

            //si hay fixture se asigna con sus resultados correspondientes a la competencia
                if (comp.Fixture.Count != 0)
                {
                    unaCompetencia._fixture = new Clases_de_entidad.Fixture();
                    unaCompetencia._fixture._id_fixture = comp.Fixture[0].id_fixture;
                    unaCompetencia._fixture._rondaActual = Convert.ToInt32(comp.Fixture[0].ronda_actual);
                    unaCompetencia._fixture._rondas = new List<Clases_de_entidad.Ronda>();
                    foreach (var ronda in comp.Fixture[0].Ronda)
                    {
                        Clases_de_entidad.Ronda unaRonda = new Clases_de_entidad.Ronda();
                        unaRonda._nro_ronda = ronda.nro_ronda;
                        if (ronda.id_libre != null) //si hay participante libre
                        {
                            unaRonda._libre = new Clases_de_entidad.Participante(
                                ronda.Participante.id_participante, ronda.Participante.nombre, ronda.Participante.e_mail, ronda.Participante.imagen, 
                                Convert.ToBoolean(ronda.Participante.perdido), Convert.ToBoolean(ronda.Participante.eliminado));
                        }
                        unaRonda._partidos = new List<Clases_de_entidad.Partido>();

                        var listaPartidos = from unaLista in db.Partido where (unaLista.id_ronda == ronda.id_ronda) select unaLista;

                        foreach (var partido in listaPartidos)
                        {
                            Clases_de_entidad.Partido unPartido = new Clases_de_entidad.Partido();
                            unPartido._id_partido = partido.id_partido;
                            unPartido._pParticipantes = new List<Clases_de_entidad.PartidoParticipante>();
                            
                            Clases_de_entidad.PartidoParticipante pParticipante1 = new Clases_de_entidad.PartidoParticipante();
                            pParticipante1._participante = new Clases_de_entidad.Participante(
                                partido.Partido_Participante[0].Participante.id_participante, partido.Partido_Participante[0].Participante.nombre,
                                partido.Partido_Participante[0].Participante.e_mail, partido.Partido_Participante[0].Participante.imagen,
                                Convert.ToBoolean(partido.Partido_Participante[0].Participante.perdido), Convert.ToBoolean(partido.Partido_Participante[0].Participante.eliminado));
                            unPartido._pParticipantes.Add(pParticipante1);

                            Clases_de_entidad.PartidoParticipante pParticipante2 = new Clases_de_entidad.PartidoParticipante();
                            pParticipante2._participante = new Clases_de_entidad.Participante(
                                partido.Partido_Participante[1].Participante.id_participante, partido.Partido_Participante[1].Participante.nombre,
                                partido.Partido_Participante[1].Participante.e_mail, partido.Partido_Participante[1].Participante.imagen,
                                Convert.ToBoolean(partido.Partido_Participante[1].Participante.perdido), Convert.ToBoolean(partido.Partido_Participante[1].Participante.eliminado));
                            unPartido._pParticipantes.Add(pParticipante2);

                            if (partido.Rdo_Partido.Count != 0) //si hay resultado cargado
                            {
                                unPartido._resultado = new Clases_de_entidad.Resultado();
                                unPartido._resultado._id_resultado = partido.Rdo_Partido[0].Resultado.id_rdo;
                                unPartido._resultado._puntosP1 = Convert.ToInt32(partido.Rdo_Partido[0].Resultado.puntosP1);
                                unPartido._resultado._puntosP2 = Convert.ToInt32(partido.Rdo_Partido[0].Resultado.puntosP2);
                                unPartido._resultado._empate = Convert.ToBoolean(partido.Rdo_Partido[0].Resultado.empate);
                                //unPartido._resultado._ausente = Convert.ToBoolean(partido.Rdo_Partido[0].ausente);                           REVISAR
                                //unPartido._resultado._ganador = new Clases_de_entidad.Participante(partido.Rdo_Partido[0].Resultado.ganador    REVISAR
                                unPartido._resultado._cantidad_set = Convert.ToInt32(partido.Rdo_Partido[0].Resultado.cantSets);

                                if (partido.Rdo_Partido[0].Resultado.Set.Count != 0) //si hay al menos un set
                                {
                                    unPartido._resultado._sets = new List<Clases_de_entidad.Set>();
                                    foreach (var sets in partido.Rdo_Partido[0].Resultado.Set)
                                    {
                                        Clases_de_entidad.Set unSet = new Clases_de_entidad.Set(
                                            sets.id_set, Convert.ToInt32(sets.puntosP1), Convert.ToInt32(sets.puntosP2), sets.nro_set);
                                        unPartido._resultado._sets.Add(unSet);
                                    }
                                }
                            }
                            unaRonda._partidos.Add(unPartido);
                        }
                        unaCompetencia._fixture._rondas.Add(unaRonda);
                    }
                }
            }
            return unaCompetencia;
        }


        //Se guarda la competencia en la BD y retornamos el id asignado
        public short setCompetencia(Clases_de_entidad.CompetenciaDeportiva unaCompetencia)
        {
            Forma_de_Puntuacion formaNueva = new Forma_de_Puntuacion();
            formaNueva.nombre = unaCompetencia._modalidad._formaPuntuacion._nombreForma;
            formaNueva.cant_sets = unaCompetencia._modalidad._formaPuntuacion._cantidadSet;
            formaNueva.tantos_x_ausencia_del_rival = unaCompetencia._modalidad._formaPuntuacion._tantosAusencia;
            db.Forma_de_Puntuacion.InsertOnSubmit(formaNueva);
            db.SubmitChanges();

            Modalidad modalidadNueva = new Modalidad();
            modalidadNueva.nombre = unaCompetencia._modalidad._nombreMod;
            modalidadNueva.empate = unaCompetencia._modalidad._empate;
            modalidadNueva.ptos_empate = unaCompetencia._modalidad._ptosEmpate;
            modalidadNueva.ptos_por_PG = unaCompetencia._modalidad._ptosPG;
            modalidadNueva.ptos_por_presentarse = unaCompetencia._modalidad._ptosPresentarse;
            modalidadNueva.id_forma = formaNueva.id_forma;
            db.Modalidad.InsertOnSubmit(modalidadNueva);
            db.SubmitChanges();

            //Se guarda la competencia con sus atributos
            CompetenciaDeportiva nueva = new CompetenciaDeportiva();
            nueva.nombre = unaCompetencia._nombre;            
            nueva.Estado = unaCompetencia._estado;
            nueva.Reglamento = unaCompetencia._reglamento;
            nueva.id_deporte = unaCompetencia._deporte._id_deporte;
            nueva.e_mail_usuario = unaCompetencia._usuario._email;
            nueva.id_modalidad = modalidadNueva.id_modalidad;            
            db.CompetenciaDeportiva.InsertOnSubmit(nueva);
            db.SubmitChanges();

            //Se asigna la disponibilidad a los lugares relacionados con la competencia
            foreach (var lugar in unaCompetencia._lugaresDeRealizacion)
            {
                Competencia_Lugar lugarNuevo = new Competencia_Lugar();
                lugarNuevo.turnos_por_fecha = lugar._disponibilidad._turnosPorFecha;
                lugarNuevo.id_lugar = lugar._id_lugar;
                lugarNuevo.id_competencia = nueva.id_competencia;
                db.Competencia_Lugar.InsertOnSubmit(lugarNuevo);
                db.SubmitChanges();
            }

            return nueva.id_competencia;
        }


        public void setRenglon(Clases_de_entidad.renglonTabla unRenglon)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var renglon = from renglonTabla in db.Tabla_Participante where (renglonTabla.id_tabla == unRenglon._id_renglonTabla) select renglonTabla;

            foreach (var seleccionado in renglon)
            {
                seleccionado.D = unRenglon._diferencia;
                seleccionado.GC = unRenglon._golesContra;
                seleccionado.GF = unRenglon._golesFavor;
                seleccionado.PE = unRenglon._pEmpatado;
                seleccionado.PG = unRenglon._pGanado;
                seleccionado.PP = unRenglon._pPerdido;
                seleccionado.PTS = unRenglon._pts;
                db.SubmitChanges();
            }
        }

        
        public short crearTabla (Clases_de_entidad.TablaPosiciones unaTabla, short unId_competencia)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            Tabla_de_Posiciones tablaPos = new Tabla_de_Posiciones();
            tablaPos.id_competencia = unId_competencia;
            db.Tabla_de_Posiciones.InsertOnSubmit(tablaPos);
            db.SubmitChanges();

            foreach (var renglon in unaTabla._renglones)
            {
                Tabla_Participante tablaPart = new Tabla_Participante();
                tablaPart.id_tabla = tablaPos.id_tabla;
                tablaPart.nombrePart = renglon._nombreParticipante;
                tablaPart.id_participante = renglon._id_participante;
                tablaPart.PE = renglon._pEmpatado;
                tablaPart.PG = renglon._pGanado;
                tablaPart.PP = renglon._pPerdido;
                tablaPart.PTS = renglon._pts;
                tablaPart.GF = renglon._golesFavor;
                tablaPart.GC = renglon._golesContra;
                tablaPart.D = renglon._diferencia;
                db.Tabla_Participante.InsertOnSubmit(tablaPart);
                db.SubmitChanges();
            }
            return tablaPos.id_tabla;
        }
    }
}
