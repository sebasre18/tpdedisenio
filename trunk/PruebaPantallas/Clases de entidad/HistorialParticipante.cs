using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class HistorialParticipante : Participante
    {
        //Atributos
        private short id_participante;
        private string nombre;
        private string email;
        private string imagen;
        private bool perdio;
        private bool eliminado;
        private short id_historial;        
        private DateTime fecha_modificacion;
        private string pc;

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
        public string _pc
        {
            get
            {
                return pc;
            }
            set
            {
                pc = value;
            }
        }

        //Constructor
        public HistorialParticipante(short unId_participante, string unNombre, string unEmail, string unaImagen, bool unPerdio, bool unEliminado, short unId_competencia, short unId_historial, short unId_partido, short unId_tablaPos, DateTime unaFecha_modificacion, string unaPc) :
            base(unId_participante, unNombre, unEmail, unaImagen, unPerdio, unEliminado)
        {
            this._fecha_modificacion = unaFecha_modificacion;
            this._pc = unaPc;
        }
    }
}
