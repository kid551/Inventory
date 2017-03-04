﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.BLL;

namespace Inventory.PLL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loadProfile_Click(object sender, EventArgs e)
        {
            ProfileBLL objBLL = new ProfileBLL();
            profileDataGrid.DataSource = objBLL.GetProfile();
            
        }
    }
}