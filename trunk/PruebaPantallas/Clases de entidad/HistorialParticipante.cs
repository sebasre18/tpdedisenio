using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class HistorialParticipante : Participante
    {
        //Atributos
        private int id_participante;
        private string nombre;
        private string email;
        private string imagen;
        private bool perdio;
        private bool eliminado;
        private int id_competencia;
        private int id_historial;
        private int id_partido;
        private int id_tablaPos;
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
        public HistorialParticipante(int unId_participante, string unNombre, string unEmail, string unaImagen, bool unPerdio, bool unEliminado, int unId_competencia, int unId_historial, int unId_partido, int unId_tablaPos, DateTime unaFecha_modificacion, string unaPc) :
            base(unId_participante, unNombre, unEmail, unaImagen, unPerdio, unEliminado, unId_competencia, unId_historial, unId_partido, unId_tablaPos)
        {
            this._fecha_modificacion = unaFecha_modificacion;
            this._pc = unaPc;
        }
    }
}
