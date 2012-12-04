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
        private int pts;
        private int pGanado;
        private int pEmpatado;
        private int pPerdido;
        private int golesFavor;
        private int golesContra;
        private int diferencia;
        private List<Participante> participantes;
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
        public int _pts
        {
            get
            {
                return pts;
            }
            set
            {
                pts = value;
            }
        }
        public int _pGanado
        {
            get
            {
                return pGanado;
            }
            set
            {
                pGanado = value;
            }
        }
        public int _pEmpatado
        {
            get
            {
                return pEmpatado;
            }
            set
            {
                pEmpatado = value;
            }
        }
        public int _pPerdido
        {
            get
            {
                return pPerdido;
            }
            set
            {
                pPerdido = value;
            }
        }
        public int _golesFavor
        {
            get
            {
                return golesFavor;
            }
            set
            {
                golesFavor = value;
            }
        }
        public int _golesContra
        {
            get
            {
                return golesContra;
            }
            set
            {
                golesContra = value;
            }
        }
        public int _diferencia
        {
            get
            {
                return diferencia;
            }
            set
            {
                diferencia = value;
            }
        }
        public List<Participante> _participantes
        {
            get
            {
                return this.participantes;
            }
            set
            {
                this.participantes = value;
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
        public TablaPosiciones(int unId_tablaPos, int unPts, int unPGanado, int unPEmpatado, int unPPerdido, int unGolesFavor, int unGolesContra, int unaDiferencia, List<Participante> listaParticipantes, int unIdCompetencia)
        {
            this._id_tablaPos = unId_tablaPos;
            this._pts = unPts;
            this._pGanado = unPGanado;
            this._pEmpatado = unPEmpatado;
            this._pPerdido = unPPerdido;
            this._golesFavor = unGolesFavor;
            this._golesContra = unGolesContra;
            this._diferencia = unaDiferencia;
            this._participantes = listaParticipantes;
            this._id_competencia = unIdCompetencia;
        }

    }
}
//NO DEBERIAN SER PURAS LISTAS CON PTS Y ESO?? COMO SE ARMA ESO? hay q relacionar los puntos con cada participante... :P