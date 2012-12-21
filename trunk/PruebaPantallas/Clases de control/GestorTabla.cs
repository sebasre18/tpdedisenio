using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPdeDiseño.Clases_de_control
{
    public class GestorTabla
    {
        public Clases_de_entidad.TablaPosiciones crearTabla(Clases_de_entidad.CompetenciaDeportiva unaCompetencia)
        {
            Clases_ABD.ABDcompetencia competenciaABD = new Clases_ABD.ABDcompetencia();
            Clases_de_entidad.TablaPosiciones unaTabla = new Clases_de_entidad.TablaPosiciones();
            unaTabla._renglones = new List<Clases_de_entidad.renglonTabla>();

            foreach (var part in unaCompetencia._participantes)
            {
                if (part._nombre != "EQUIPOFANTASMA")
                    unaTabla._renglones.Add(creaRenglones(part));
            }

            unaTabla._id_tablaPos = competenciaABD.crearTabla(unaTabla, unaCompetencia._id_competencia);

            return unaTabla;
        }
        
        public Clases_de_entidad.renglonTabla creaRenglones(Clases_de_entidad.Participante unParticipante)
        {
            Clases_de_entidad.renglonTabla renglon = new Clases_de_entidad.renglonTabla();
            renglon._nombreParticipante = unParticipante._nombre;
            renglon._id_participante = unParticipante._id_participante;
            renglon._pts = 0;
            renglon._pPerdido = 0;
            renglon._pGanado = 0;
            renglon._pEmpatado = 0;
            renglon._golesFavor = 0;
            renglon._golesContra = 0;
            renglon._diferencia = 0;
            return renglon;
        }
        

        public void actualizaRenglon(Clases_de_entidad.Participante unParticipante, Clases_de_entidad.Resultado unResultado, Clases_de_entidad.CompetenciaDeportiva unaCompetencia)
        {
            Clases_ABD.ABDcompetencia ABDcomp = new Clases_ABD.ABDcompetencia();
            Clases_de_entidad.renglonTabla renglonTabla = new Clases_de_entidad.renglonTabla();
            int ptosPresentarse, ptosEmpate, ptosPGanado, cantRenglones, tantosGanador, tantosPerdedor;

            cantRenglones = unaCompetencia._tablaPosiciones._renglones.Count;
            for (int i = 0; i < cantRenglones; i++)
            {
                if (unaCompetencia._tablaPosiciones._renglones[i]._id_participante == unParticipante._id_participante)
                {
                    renglonTabla = unaCompetencia._tablaPosiciones._renglones[i];
                    break;
                }
            }

            if (unResultado._ausente != null)
            {
                if (unResultado._ausente._id_participante == unParticipante._id_participante)
                {
                    renglonTabla._pPerdido = renglonTabla._pPerdido + 1;
                }
                else
                {
                    ptosPresentarse = unaCompetencia._modalidad._ptosPresentarse;
                    renglonTabla._pGanado = renglonTabla._pGanado + 1;
                    renglonTabla._pts = renglonTabla._pts + ptosPresentarse;
                }
            }
            else if (unResultado._empate == true)
            {
                ptosEmpate = unaCompetencia._modalidad._ptosEmpate;
                renglonTabla._pEmpatado = renglonTabla._pEmpatado + 1;
                renglonTabla._pts = renglonTabla._pts + ptosEmpate;
                renglonTabla._golesFavor = renglonTabla._golesFavor + unResultado._puntosP1;
                renglonTabla._golesContra = renglonTabla._golesContra + unResultado._puntosP2;
                renglonTabla._diferencia = renglonTabla._diferencia + (renglonTabla._golesFavor - renglonTabla._golesContra);

            }
            else if (unResultado._ganador != null)
            {
                if (unResultado._puntosP1 < unResultado._puntosP2)
                {
                    tantosGanador = unResultado._puntosP2;
                    tantosPerdedor = unResultado._puntosP1;
                }
                else
                {
                    tantosPerdedor = unResultado._puntosP2;
                    tantosGanador = unResultado._puntosP1;
                }

                ptosPGanado = unaCompetencia._modalidad._ptosPG;
                if (unResultado._ganador._id_participante == unParticipante._id_participante)
                {
                    renglonTabla._golesContra = renglonTabla._golesContra + tantosPerdedor;
                    renglonTabla._golesFavor = renglonTabla._golesFavor + tantosGanador;
                    renglonTabla._diferencia = renglonTabla._diferencia + (renglonTabla._golesFavor - renglonTabla._golesContra);
                    renglonTabla._pGanado = renglonTabla._pGanado + 1;
                    renglonTabla._pts = renglonTabla._pts + ptosPGanado;
                }
                else
                {
                    renglonTabla._golesContra = renglonTabla._golesContra + tantosGanador;
                    renglonTabla._golesFavor = renglonTabla._golesFavor + tantosPerdedor;
                    renglonTabla._diferencia = renglonTabla._diferencia + (renglonTabla._golesFavor - renglonTabla._golesContra);
                    renglonTabla._pPerdido = renglonTabla._pPerdido + 1;

                }
            }

            ABDcomp.setRenglon(renglonTabla);
        }
    }
}