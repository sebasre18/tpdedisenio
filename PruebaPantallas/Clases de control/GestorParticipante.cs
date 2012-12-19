using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_control
{
    class GestorParticipante
    {
        Clases_ABD.ABDparticipante participanteABD = new Clases_ABD.ABDparticipante();
        
        public Boolean compararNombre(string nombre)
        {
            Boolean nombreValido = participanteABD.compareNombre(nombre);
        }

        public Boolean compararMail(string email)
        {
            Boolean emailValido = participanteABD.compareMail(email);
        } 
         
    }
}
