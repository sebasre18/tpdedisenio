using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class HistorialResultado : Resultado
    {
        //Atributos
        private short id_resultado;
        private int puntosP1;
        private int puntosP2;
        private Participante ganador;
        private Participante ausente;
        private bool empate;
        private int cantidad_set;
        private List<Set> sets;
        private short id_partido;
        private DateTime fecha_modificacion;

        //Propiedades
        public DateTime _fecha_modificacion
        {
            get
            {
                return fecha_modificacion;
            }
            set
            {
                fecha_modificacion = value;
            }
        }

        //Constructor
        public HistorialResultado() { }

        public HistorialResultado(short unId_resultado, int unPuntosP1, int unPuntosP2, Participante unGanador,Participante unAusente, bool unEmpate, int unaCantidad_set, List<Set> unosSets, short unId_partido, List<HistorialResultado> unosHistResultado, DateTime unaFecha_modificacion) :
            base(unId_resultado, unPuntosP1, unPuntosP2, unGanador, unAusente, unEmpate, unaCantidad_set, unosSets, unId_partido, unosHistResultado)
        {
            this._fecha_modificacion = unaFecha_modificacion;
        }
    
    }
}
