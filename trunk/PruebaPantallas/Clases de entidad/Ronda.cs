using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Ronda
    {
        //Atributos
        private int nro_ronda; 
        private string nombre;
        private List<Partido> partidos;
        private Participante libre;

        //Propiedades
        public int _nro_ronda
        {
            get
            {
                return nro_ronda;
            }
            set
            {
                nro_ronda = value;
            }
        }
        public string _nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public List<Partido> _partidos
        {
            get
            {
                return partidos;
            }
            set
            {
                partidos = value;
            }
        }
        public Participante _libre
        {
            get
            {
                return libre;
            }
            set
            {
                libre = value;
            }
        }


        //Constructor
        public Ronda() { }
        
        public Ronda(int unNro_ronda, string unNombre, List<Partido> listaDePartidos, Participante unLibre)
        {
            this._nro_ronda = unNro_ronda;
            this._nombre = unNombre;
            this._partidos = listaDePartidos;
            this._libre = unLibre;
        }
    }
}
