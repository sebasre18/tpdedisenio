using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class CompetenciaDeportiva
    {
        //Atributos
        private short id_competencia;
        private string estado;
        private string nombre;
        private string reglamento;
        private Deporte deporte;
        private List<LugarDeRealizacion> lugaresDeRealizacion;
        private Usuario usuario;
        private Modalidad modalidad;
        private List<Participante> participantes;
        private TablaPosiciones tablaPosiciones;
        private Fixture fixture;
     
        //Propiedades
        public short _id_competencia
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
        public string _estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
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
        public string _reglamento
        {
            get
            {
                return reglamento;
            }
            set
            {
                reglamento = value;
            }
        }
        public Deporte _deporte
        {
            get
            {
                return deporte;
            }
            set
            {
                deporte = value;
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
        public Usuario _usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }
        public Modalidad _modalidad
        {
            get
            {
                return modalidad;
            }
            set
            {
                modalidad = value;
            }
        }
        public List<Participante> _participantes
        {
            get
            {
                return participantes;
            }
            set
            {
                participantes = value;
            }
        }
        public TablaPosiciones _tablaPosiciones
        {
            get
            {
                return tablaPosiciones;
            }
            set
            {
                tablaPosiciones = value;
            }
        }
        public Fixture _fixture
        {
            get
            {
                return fixture;
            }
            set
            {
                fixture = value;
            }
        }

        //Constructor
        public CompetenciaDeportiva() { }

        public CompetenciaDeportiva(string unEstado, string unNombre, string unReglamento, Clases_de_entidad.Deporte unDeporte, List<LugarDeRealizacion> listaLugares, Clases_de_entidad.Modalidad unaModalidad, Clases_de_entidad.Usuario unUsuario)
        {
            this._nombre = unNombre;
            this._estado = unEstado;
            this._reglamento = unReglamento;
            this._deporte = unDeporte;
            this._lugaresDeRealizacion = listaLugares;
            this._modalidad = unaModalidad;
            this._usuario = unUsuario;
        }
    }
}
