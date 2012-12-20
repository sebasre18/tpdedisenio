using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_control
{
    public class GestorParticipante
    {
        Clases_ABD.ABDparticipante participanteABD = new Clases_ABD.ABDparticipante();
        
        public Boolean compararNombre(string nombre)
        {
            // Busca en la BD si el nombre del usuario ya está en uso. Si es asi retorna True.
            return participanteABD.compareNombre(nombre);
        }

        public Boolean compararMail(string email)
        {
            // Busca en la BD si el email ingresado por el usuario ya está en uso. Si es asi retorna True.
            return participanteABD.compareMail(email);
        } 

        public void guardar(Clases_de_entidad.Participante unParticipante, short unId_competencia)
        {
            // Guarda un participante nuevo en la BD.
            participanteABD.setParticipante(unParticipante, unId_competencia);
        }
         
    }
}
