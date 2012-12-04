using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Localidad
    {
        //Atributos
        private string id_localidad;
        private string nombre;
        private List<Localidad> localidades;

        //Propiedades
        public string _id_localidad
        {
            get
            {
                return id_localidad;
            }
            set
            {
                id_localidad = value;
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
        public List<Localidad> _localidades
        {
            get
            {
                return this.localidades;
            }
            set
            {
                this.localidades = value;
            }
        }

        //Constructores
        public Localidad(string unId_localidad, string unNombre, List<Localidad> unaListaDeLocalidades)
        {
            this._id_localidad = unId_localidad;
            this._nombre = unNombre;
            this._localidades = unaListaDeLocalidades;
        }
    }
}
