using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_ABD
{
    public class ABDlugares
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        
        //lista los lugares de una competencia
        public List<Clases_de_entidad.LugarDeRealizacion> getLugares(string unNombreDeporte, string unEmail)
        {
            List<Clases_de_entidad.LugarDeRealizacion> listaLugares = new List<Clases_de_entidad.LugarDeRealizacion>();

            var lugares = from lugar in db.Lugar_de_Realización where (lugar.e_mail_usuario == unEmail) select lugar;

            foreach (var unLugar in lugares)
            {
                foreach (var unDeporte in unLugar.Deporte)
                {
                    if (unDeporte.nombre == unNombreDeporte)
                    {
                        Clases_de_entidad.LugarDeRealizacion unLugarDeRealizacion = new Clases_de_entidad.LugarDeRealizacion();
                        unLugarDeRealizacion._id_lugar = unLugar.id_lugar;
                        unLugarDeRealizacion._nombre = unLugar.Nombre;
                        unLugarDeRealizacion._descripcion = unLugar.Descripción;
                        unLugarDeRealizacion._disponibilidad = new Clases_de_entidad.Disponibilidad();
                        unLugarDeRealizacion._disponibilidad._turnosPorFecha = 0;
                        listaLugares.Add(unLugarDeRealizacion);
                    }
                }
            }
            return listaLugares;
        }
    }
}
