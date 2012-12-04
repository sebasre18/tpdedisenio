using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class HdeLogueo
    {
        //Atributos
        private int id_hitorial;
        private int fecha; // Preg a nemi q onda con "DateTime", si la struct tiene fecha y hs...
        private int hora;
        private string pc; // noc si sera int o string...

        //Propiedades
        public int _id_historial
        {
            get
            {
                return id_hitorial;
            }
            set
            {
                id_hitorial = value;
            }
        }
        public int _fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }
        public int _hora
        {
            get
            {
                return hora;
            }
            set
            {
                hora = value;
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
        public HdeLogueo(int unId_historial, int unaFecha, int unaHora, string unaPc)
        {
            this._id_historial = unId_historial;
            this._fecha = unaFecha;
            this._hora = unaHora;
            this._pc = unaPc;
        }
    }
}
