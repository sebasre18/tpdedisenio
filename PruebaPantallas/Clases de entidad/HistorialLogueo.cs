using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class HistorialLogueo : Usuario
    {
        //Atributos
        private string email;
        private string contraseña;
        private string apellido;
        private string nombre;
        private string tipo_dni;
        private int nro_dni;
        private int id_hitorial;
        private DateTime fecha;
        private DateTime hora;
        private string pc;

        //Propiedades
        public int _id_historial
        {
            get
            {
                return id_hitorial;
            }
            set
            {
                id_hitorial = value;
            }
        }
        public DateTime _fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }
        public DateTime _hora
        {
            get
            {
                return hora;
            }
            set
            {
                hora = value;
            }
        }
        public string _pc
        {
            get
            {
                return pc;
            }
            set
            {
                pc = value;
            }
        }

        //Constructor
        public HistorialLogueo(string unEmail, string unaContraseña, string unApellido, string unNombre, string unTipo_dni, int unNro_dni, int unId_historial, DateTime unaFecha, DateTime unaHora, string unaPc) : 
            base(unEmail, unaContraseña, unApellido, unNombre, unTipo_dni, unNro_dni)
        {
            this._id_historial = unId_historial;
            this._fecha = unaFecha;
            this._hora = unaHora;
            this._pc = unaPc;
        }
    }
}
