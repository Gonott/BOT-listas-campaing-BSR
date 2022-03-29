using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace BOT_listas_campaing_BSR
{
    public  class DAO
    {
        
        SqlConnection cnx = new SqlConnection("Data Source=192.168.120.120;Initial Catalog=at;Persist Security Info=True;User ID=ActiveWeb;Password=SKYFALL77*");
       

        public DataTable TraerTabla(string nombreStore,string nombreTabla)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(nombreStore, cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(nombreTabla);
                ad.Fill(dt);
                return dt;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            { 
            
            if (cnx.State != ConnectionState.Closed)
                {
                    cnx.Close();
                }
            }


        }







    }
}
