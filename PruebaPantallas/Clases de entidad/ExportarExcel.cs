using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;

namespace TPdeDiseño.Clases_de_entidad
{
    class ExportarExcel
    {
         public ExportarExcel(System.Windows.Forms.DataGridView dgvConsulta) 
        {
            exportaExcel(dgvConsulta);
        }
        
        public void exportaExcel(System.Windows.Forms.DataGridView dgvConsulta)
        {
            try
            {
                string temp;
                int iColumnas = 0;
                Application xlsApp = new Application();//creo una aplicación Excel
                xlsApp.DisplayAlerts = false;
                Worksheet xlsSheet; //creo una hoja
                Workbook xlsBook; //creo un libro
                xlsApp.Visible = false; //la aplicación no es visible
                xlsBook = xlsApp.Workbooks.Add(true);//añado el libro a la aplicación
                xlsSheet = (Worksheet)xlsBook.ActiveSheet; //activo la hoja, para el libro
                //titulo
                xlsSheet.Cells[1, 1] = "UTM";
                xlsSheet.Cells[2, 1] = "Lista de Alumnos";
                for (int iCol = 0; iCol < dgvConsulta.Columns.Count; iCol++)
                {
                    if (dgvConsulta.Columns[iCol].Visible == true)
                    {
                        xlsSheet.Cells[3, iCol+1] =dgvConsulta.Columns[iCol].HeaderText;
                        iColumnas++;
                    }
                }

                for (int iRow = 0; iRow < dgvConsulta.Rows.Count; iRow++)
                {
                    for (int iCol = 0; iCol < dgvConsulta.Columns.Count; iCol++)
                    {
                        if (dgvConsulta.Columns[iCol].Visible == true)
                        {
                            temp = dgvConsulta[iCol, iRow].Value.ToString();
                            xlsSheet.Cells[iRow + 4, iCol+1] = temp;
                        }
                    }
                }
                //Definir el rango y aplicarle un formato.
                Range rango = xlsSheet.get_Range(xlsSheet.Cells[1, 1], xlsSheet.Cells[dgvConsulta.Rows.Count + 3, iColumnas]);
                rango.Cells.AutoFormat(XlRangeAutoFormat.xlRangeAutoFormatList1, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                xlsSheet.Columns.AutoFit(); //Ajusta ancho de todas las columnas
                xlsApp.Visible = true;
              // xlsApp.Quit();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
