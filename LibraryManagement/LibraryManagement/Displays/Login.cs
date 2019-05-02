using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Displays
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void lblReg_Click(object sender, EventArgs e)
        {
            Classes.User newUse = new Classes.User();
            // Display RegWindow forms

            // on btn Press
            // Check for correct data
            //newUse.AddUser(username, password);


        }
    }
}
