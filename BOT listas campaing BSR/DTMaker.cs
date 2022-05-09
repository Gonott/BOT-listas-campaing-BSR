using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BOT_listas_campaing_BSR
{
    class DTMaker
    {

        DAO objetoDatos = new DAO();
        
        

        public DataSet LlenarTablasCVS()
        {
            DataSet dsCVS = new DataSet();

            try
            {
                Console.WriteLine("Leyendo datos de No Vistos para MovilGate");
                DataTable tablaNoVistosMG = objetoDatos.TraerTabla("SP_LISTAR_NO_VISTOS_SMS_BSR_DIGITAL", "SMSNoVistos");
                dsCVS.Tables.Add(tablaNoVistosMG);
         
                Console.WriteLine("Leyendo datos de Interesados portal para MovilGate");
                DataTable tablaInteresadosMG = objetoDatos.TraerTabla("SP_LISTAR_INTERESADOS_PORTAL_SMS_BSR_DIGITAL", "SMSInteresados");
                dsCVS.Tables.Add(tablaInteresadosMG);

                Console.WriteLine("Leyendo datos de No vistos para EnvialoSimple");
                DataTable tablaNoVistosES = objetoDatos.TraerTabla("SP_LISTAR_NO_VISTOS_EMAIL_BSR_DIGITAL", "EMAILNoVistos");
                dsCVS.Tables.Add(tablaNoVistosES);

        
                Console.WriteLine("Leyendo datos de Interesados portal para EnvialoSimple");
                DataTable tablaInteresadosES = objetoDatos.TraerTabla("SP_LISTAR_INTERESADOS_PORTAL_EMAIL_BSR_DIGITAL", "EMAILInteresados");
                dsCVS.Tables.Add(tablaInteresadosES);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dsCVS;
        }



        public DataSet LlenarTablasExcel()
        {
            DataSet dsExcel = new DataSet();

            try
            {
                Console.WriteLine("Leyendo datos de No Vistos SMS para Operaciones");
                DataTable tablaOpsNoVistosMG = objetoDatos.TraerTabla("SP_LISTA_OPS_SMS_NO_VISTO_BSR_DIGITAL", "OPSNoVistosSMS");
                dsExcel.Tables.Add(tablaOpsNoVistosMG);

                Console.WriteLine("Leyendo datos de Interesados SMS para Operaciones");
                DataTable tablaOpsInteresadosMG = objetoDatos.TraerTabla("SP_LISTA_OPS_SMS_INTERESADOS_PORTAL_BSR_DIGITAL", "OPSInteresadosSMS");
                dsExcel.Tables.Add(tablaOpsInteresadosMG);

                Console.WriteLine("Leyendo datos de No vistos EMAIL para Operaciones");
                DataTable tablaOpsNoVistosES = objetoDatos.TraerTabla("SP_LISTA_OPS_NO_VISTO_EMAIL_BSR_DIGITAL", "OPSNoVistosEMAIL");
                dsExcel.Tables.Add(tablaOpsNoVistosES);


                Console.WriteLine("Leyendo datos de Interesados EMAIL para Operaciones");
                DataTable tablaOpsInteresadosES = objetoDatos.TraerTabla("SP_LISTA_OPS_INTERESADOS_PORTAL_EMAIL_BSR_DIGITAL", "OPSInteresadosEnvialoSimpleEMAIL");
                dsExcel.Tables.Add(tablaOpsInteresadosES);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return dsExcel;

        }

    }
}
