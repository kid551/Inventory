using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Inventory.DAL
{
    public class ProfileDAL
    {
        DataTable dt = new DataTable();

        public DataTable ReadProfile()
        {
            Connection conn = new Connection();
            
            if(ConnectionState.Closed == conn.con.State)
            {
                conn.con.Open();
            }
            MySqlCommand cmd = new MySqlCommand("Select * from Profile_Master", conn.con);

            try
            {
                MySqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch
            {
                throw;
            }
        }
    }
}
