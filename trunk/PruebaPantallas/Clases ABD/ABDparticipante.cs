using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_ABD
{
    public class ABDparticipante
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        
        //lista los participantes de una competencia       
        public List<Clases_de_entidad.Participante> getParticipantes(short unId_competencia)
        {
            List<Clases_de_entidad.Participante> listaParticipantes = new List<Clases_de_entidad.Participante>();
            var participantes = from participante in db.Participante where (participante.id_competencia == unId_competencia) select participante;

            foreach (var part in participantes)
            {
                Clases_de_entidad.Participante unParticipante = new Clases_de_entidad.Participante(part.id_participante,part.nombre,part.e_mail,part.imagen,Convert.ToBoolean(part.perdido),Convert.ToBoolean(part.eliminado));
                listaParticipantes.Add(unParticipante);
            }
            
            return listaParticipantes;
        }

        //retorna true si nombre del participante pasado por parametro existe en la BD
        public bool compareNombre(string nombre)
        {
            var participante = from participantes in db.Participante where (participantes.nombre == nombre) select participantes;
            foreach (var part in participante)
            {
                if (part.nombre == nombre)
                    return true;
            }
            return false;
        }

        //retorna true si el mail del participante pasado por parametro existe en la BD
        public bool compareMail(string email)
        {
            var participante = from participantes in db.Participante where (participantes.e_mail == email) select participantes;
            foreach (var part in participante)
            {
                if (part.e_mail == email)
                    return true;
            }
            return false;
        }

        public void setParticipante(Clases_de_entidad.Participante unParticipante)
        {
            //Se guarda el participante con sus atributos
            Participante nuevo = new Participante();
            nuevo.nombre = unParticipante._nombre;
            nuevo.e_mail = unParticipante._email;
            nuevo.imagen = unParticipante._imagen;
            db.Participante.InsertOnSubmit(nuevo);
            db.SubmitChanges();
        }
    }
}
