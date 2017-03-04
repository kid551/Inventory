using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Inventory.DAL;

namespace Inventory.BLL
{
    public class ProfileBLL
    {
        public DataTable GetProfile()
        {
            ProfileDAL objDAL = new ProfileDAL();
            return objDAL.ReadProfile();
        }
    }
}
