using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Inventory.DAL
{
    public class Connection
    {
        public MySqlConnection con = new MySqlConnection("server=localhost;" + "uid=root;" + "pwd=toor;" + "database=inventrydb;");

    }
}
