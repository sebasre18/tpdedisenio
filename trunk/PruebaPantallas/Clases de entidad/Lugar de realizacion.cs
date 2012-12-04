using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class LugarDeRealizacion
    {
        //Atributos
        private int codigo;
        private string nombre;
        private string descripcion;
        //private int disponibilidad; ---> NOSE SI TIENE QUE IR YA QUE ESTA COMO OTRA ENTIDAD.... igualmente esta toda declarada aca como comentario.
        private List<LugarDeRealizacion> lugaresDeRealizacion;

        //Propiedades
        public int _codigo
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
/*        public int _disponibilidad
        {
            get
            {
                return disponibilidad;
            }
            set
            {
                disponibilidad = value;
            }
        }*/
        public List<Factor> _factores
        {
            get
            {
            
            return this.factores;
            }
            set
            {
                this.factores = value;
            }
        }
        public List<LugarDeRealizacion> _lugaresDeRealizacion
        {
            get
            {
                return this.lugaresDeRealizacion;
            }
            set
            {
                this.lugaresDeRealizacion = value;
            }
        }

        //Constructor
        public LugarDeRealizacion(int unCodigo, string unNombre, string unaDescripcion,/* int unaDisponibilidad,*/ List<LugarDeRealizacion> unaListaDeLugaresDeRealizacion)
        {
            this._codigo = unCodigo;
            this._nombre = unNombre;
            this._descripcion = unaDescripcion;
            /*this._disponibilidad = unaDisponibilidad;*/
            this._lugaresDeRealizacion = unaListaDeLugaresDeRealizacion;
        }

    }
}
