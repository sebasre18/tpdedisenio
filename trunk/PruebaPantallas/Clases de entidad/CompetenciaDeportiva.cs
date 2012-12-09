using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_entidad
{
    public class CompetenciaDeportiva
    {
        //Atributos
        private int id_competencia;
        private string estado;
        private string nombre;
        private string reglamento;
        private List<Deporte> deportes;
        private List<LugarDeRealizacion> lugaresDeRealizacion;
        private Usuario usuario;
        private Modalidad modalidad;
        private List<Participante> participantes;
        private TablaPosiciones tablaPosiciones;
        private Fixture fixture;
     
        //Propiedades
        public int _id_competencia
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
        public List<Deporte> _deportes
        {
            get
            {
                return deportes;
            }
            set
            {
                deportes = value;
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

        public CompetenciaDeportiva(int unId_competencia, string unEstado, string unNombre, string unReglamento, List<Deporte> listaDeportes, List<LugarDeRealizacion> listaLugaresDeRealizacion, Modalidad unaModalidad)
        {
            this._id_competencia = unId_competencia;
            this._nombre = unNombre;
            this._estado = unEstado;
            this._reglamento = unReglamento;
            this._deportes = listaDeportes;
            this._lugaresDeRealizacion = listaLugaresDeRealizacion;
            this._modalidad = unaModalidad;
        }
    }
}
