using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Disponibilidad
    {
        //Atributos
        private int turnosPorFecha;
        
        //Propiedades
        public int _turnosPorFecha
        {
            get
            {
                return turnosPorFecha;
            }
            set
            {
                turnosPorFecha = value;
            }
        }
        
        //Constructor
        public Disponibilidad() { }

        public Disponibilidad(int unTurnosPorFecha)
        {
            this._turnosPorFecha = unTurnosPorFecha;
        }
    }
}
