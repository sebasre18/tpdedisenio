using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class LugarDeRealizacion
    {
        //Atributos
        private short id_lugar;
        private string nombre;
        private string descripcion;
        private Disponibilidad disponibilidad;
       
       //Propiedades
        public short _id_lugar
        {
            get
            {
                return id_lugar;
            }
            set
            {
                id_lugar = value;
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
        public Disponibilidad _disponibilidad
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

        public LugarDeRealizacion(short unId_lugar, string unNombre, string unaDescripcion, Disponibilidad unaDisponibilidad)
        {
            this._id_lugar = unId_lugar;
            this._nombre = unNombre;
            this._descripcion = unaDescripcion;
            this._disponibilidad = unaDisponibilidad;
        }

    }
}
