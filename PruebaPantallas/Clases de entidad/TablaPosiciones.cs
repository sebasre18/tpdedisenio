using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class TablaPosiciones
    {
        //Atributos
        private short id_tablaPos;
        private List<renglonTabla> renglones;

        //Propiedades
        public short _id_tablaPos
        {
            get
            {
                return id_tablaPos;
            }
            set
            {
                id_tablaPos = value;
            }
        }
        public List<renglonTabla> _renglones
        {
            get
            {
                return renglones;
            }
            set
            {
                renglones = value;
            }
        }

        
        //Constructor
        public TablaPosiciones() { }

        public TablaPosiciones(short unId_tablaPos, List<renglonTabla> unosRenglones)
        {
            this._id_tablaPos = unId_tablaPos;
            this._renglones = unosRenglones;
        }
    }
}
