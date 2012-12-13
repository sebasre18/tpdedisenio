using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class TablaPosiciones
    {
        //Atributos
        private int id_tablaPos;
        private List<renglonTabla> renglones;
        private int id_competencia;

        //Propiedades
        public int _id_tablaPos
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
        public int _id_competencia
        {
            get
            {
                return id_competencia;
            }
            set
            {
                id_competencia = value;
            }
        }
        
        //Constructor
        public TablaPosiciones() { }

        public TablaPosiciones(int unId_tablaPos, List<renglonTabla> unosRenglones, int unId_competencia)
        {
            this._id_tablaPos = unId_tablaPos;
            this._renglones = unosRenglones;
            this._id_competencia = unId_competencia;
        }
    }
}
