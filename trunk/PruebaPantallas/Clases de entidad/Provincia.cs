using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class Provincia
    {
        //Atributos
        private string id_provincia;
        private string nombre;
        private List<Provincia> provincias;

        //Propiedades
        public string _id_provincia
        {
            get
            {
                return id_provincia;
            }
            set
            {
                id_provincia = value;
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
        public List<Provincia> _provincias
        {
            get
            {
                return this.provincias;
            }
            set
            {
                this.provincias = value;
            }
        }

        //Constructores
        public Provincia(string unId_provincia, string unNombre, List<Provincia> unaListaDeProvincias)
        {
            this._id_provincia = unId_provincia;
            this._nombre = unNombre;
            this._provincias = unaListaDeProvincias;
        }
    }
}
