using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_control
{
    public class GestorLugarRealizacion
    {
        public Clases_ABD.ABDlugares lugaresABD = new Clases_ABD.ABDlugares();

        public List<Clases_de_entidad.LugarDeRealizacion> buscarLugares(string unDeporte, string email)
        {
            List<Clases_de_entidad.LugarDeRealizacion> lugares = new List<Clases_de_entidad.LugarDeRealizacion>();
            // Buscar lista de lugares en BD.
            return lugares = lugaresABD.getLugares(unDeporte, email); ;
        }
    }
}
