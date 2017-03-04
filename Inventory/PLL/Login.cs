using System;
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(DialogResult.Yes == res)
            {
                Application.Exit();
            }
        }

        // Ask the same question when the cross button is clicked
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            try
            {
                if(msg.WParam.ToInt32() == (int)Keys.Escape)
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == res)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }
            }
            catch
            {

                MessageBox.Show("Key Press Error..!");
            }

            return false;  
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if("Admin" == usernameTextbox.Text && "Password" == passwordTextbox.Text)
            {
                Home.HomeInventory home = new Home.HomeInventory();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your username and password.");
            }
        }

        private void forgetLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login ss = new Login();
            ss.Show(); 
        }
    }
}
