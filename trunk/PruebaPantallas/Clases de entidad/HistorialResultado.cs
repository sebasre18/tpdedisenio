using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    class HistorialResultado : Resultado
    {
        //Atributos
        private int id_resultado;
        private int puntosP1;
        private int puntosP2;
        private Participante ganador;
        private bool empate;
        private int cantidad_set;
        private List<Set> sets;
        private int id_partido;
        private int id_histResultado;
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
        public HistorialResultado(int unId_resultado, int unPuntosP1, int unPuntosP2, Participante unGanador, bool unEmpate, int unaCantidad_set, List<Set> unosSets, int unId_partido, int unId_histResultado, DateTime unaFecha_modificacion) :
            base(unId_resultado, unPuntosP1, unPuntosP2, unGanador, unEmpate, unaCantidad_set, unosSets, unId_partido, unId_histResultado)
        {
            this._fecha_modificacion = unaFecha_modificacion;
        }

    }
}
