using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    class CompetenciaDeportiva
    {
        //Atributos
        private int id_competencia;
        private Boolean estado;
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
        public Fixture _nombre
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
        public List<Deporte> _deportes
        {
            get
            {
                return this.deportes;
            }
            set
            {
                this.deportes = value;
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
        public int _id_deporte
        {
            get
            {
                return id_deporte;
            }
            set
            {
                id_deporte = value;
            }
        }
        public Boolean _estado
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

        //Constructor
        public CompetenciaDeportiva(int unId_competencia, Boolean unEstado, string unNombre, string unReglamento, Deporte unDeporte, List<LugarDeRealizacion> listaLugaresDeRealizacion, Modalidad unaModalidad)
        {
            this._id_competencia = unId_competencia;
            this._nombre = unNombre;
            this._estado = unEstado;
            this._reglamento = unReglamento;
            this._deporte = unDeporte;
            this._lugaresDeRealizacion = listaLugaresDeRealizacion;
            this._modalidad = unaModalidad;
        }
        
    }
}
