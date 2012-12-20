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
    }
}
