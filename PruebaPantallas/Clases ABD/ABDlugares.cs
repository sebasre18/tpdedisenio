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
        public List<Clases_de_entidad.LugarDeRealizacion> getLugares(short unId_competencia)
        {
            List<Clases_de_entidad.LugarDeRealizacion> listaLugares = new List<Clases_de_entidad.LugarDeRealizacion>();

            var lugares = from lugar in db.Competencia_Lugar where (lugar.id_competencia == unId_competencia) select lugar;

            foreach (var unLugar in lugares)
            {
                if (unLugar.id_competencia == unId_competencia)
                {
                    Clases_de_entidad.LugarDeRealizacion unLugarDeRealizacion = new Clases_de_entidad.LugarDeRealizacion();
                    unLugarDeRealizacion._id_lugar = unLugar.id_lugar;
                    unLugarDeRealizacion._disponibilidad = new Clases_de_entidad.Disponibilidad();
                    unLugarDeRealizacion._disponibilidad._turnosPorFecha = Convert.ToInt32(unLugar.turnos_por_fecha);

                    var coleccionLugares = from lugar in db.Lugar_de_Realización where (lugar.id_lugar == unLugar.id_lugar) select lugar;
                    foreach (var lugarSeleccionado in coleccionLugares)
                    {
                        if (lugarSeleccionado.id_lugar == unLugar.id_lugar)
                        {
                            unLugarDeRealizacion._nombre = lugarSeleccionado.Nombre;
                            unLugarDeRealizacion._descripcion = lugarSeleccionado.Descripción;
                        }
                    }
                    listaLugares.Add(unLugarDeRealizacion);
                }
            }
            return listaLugares;
        }
    }
}
