using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BOT_listas_campaing_BSR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String s = DateTime.Now.ToString();
            s = s.Replace("/", "-").Replace(":", ".");
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +"\\" + "EnviosBSRDigital" + "\\";
            DTMaker dTMaker = new DTMaker();    


            generarCVS();
            generarExcels();


             void generarCVS()
            {
                foreach (DataTable table in dTMaker.LlenarTablasCVS().Tables)
                {
                    Console.WriteLine("Generando CVS para " + table.TableName.ToString());
                    table.ToCSV(path + table.TableName.ToString() + s + ".cvs");
                }
            }


            //Tablas para Operaciones

            void generarExcels()
            {
                
                foreach(DataTable table in dTMaker.LlenarTablasExcel().Tables)
                {
                    Console.WriteLine("Generando Excel para " + table.TableName.ToString());
                    table.ExportToExcel(path + table.TableName.ToString() + s + ".xlsx");
                }
            }


        }
    }
}
