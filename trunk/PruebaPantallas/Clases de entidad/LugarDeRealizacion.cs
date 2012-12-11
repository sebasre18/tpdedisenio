using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class LugarDeRealizacion
    {
        //Atributos
        private short codigo;
        private string nombre;
        private string descripcion;
        private short disponibilidad;
       
       //Propiedades
        public short _codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
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
        public string _descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
        public short _disponibilidad
        {
            get
            {
                return disponibilidad;
            }
            set
            {
                disponibilidad = value;
            }
        }
        
        //Constructor

        public LugarDeRealizacion() { }

        public LugarDeRealizacion(string unNombre)
        {
            this._nombre = unNombre;
        }

        public LugarDeRealizacion(short unCodigo, string unNombre, string unaDescripcion, int unaDisponibilidad, List<LugarDeRealizacion> unaListaDeLugaresDeRealizacion)
        {
            this._codigo = unCodigo;
            this._nombre = unNombre;
            this._descripcion = unaDescripcion;
            this._disponibilidad = unaDisponibilidad;
        }

    }
}
