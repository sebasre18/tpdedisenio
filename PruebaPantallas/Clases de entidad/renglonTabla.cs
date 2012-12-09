using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class renglonTabla
    {
        //Atributos
        private int id_renglonTabla;
        private int id_tablaPos;
        private int pts;
        private int pGanado;
        private int pEmpatado;
        private int pPerdido;
        private int golesFavor;
        private int golesContra;
        private int diferencia;
        private int id_participante;
        private string nombreParticipante;

        //Propiedades
        public int _id_renglonTabla
        {
            get
            {
                return id_renglonTabla;
            }
            set
            {
                id_renglonTabla = value;
            }
        }
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
        public int _id_participante
        {
            get
            {
                return this.id_participante;
            }
            set
            {
                this.id_participante = value;
            }
        }
        public string _nombreParticipante
        {
            get
            {
                return nombreParticipante;
            }
            set
            {
                nombreParticipante = value;
            }
        }

        //Constructor
        public renglonTabla(int unId_renglonTabla, int unId_tablaPos, int unPts, int unPGanado, int unPEmpatado, int unPPerdido, int unGolesFavor, int unGolesContra, int unaDiferencia, int unId_participante, string unNombreParticipante)
        {
            this._id_renglonTabla = unId_renglonTabla;
            this._id_tablaPos = unId_tablaPos;
            this._pts = unPts;
            this._pGanado = unPGanado;
            this._pEmpatado = unPEmpatado;
            this._pPerdido = unPPerdido;
            this._golesFavor = unGolesFavor;
            this._golesContra = unGolesContra;
            this._diferencia = unaDiferencia;
            this._id_participante = unId_participante;
            this._nombreParticipante = unNombreParticipante;
        }
    }
}