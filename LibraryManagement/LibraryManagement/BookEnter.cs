using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class BookEnter : Form
    {
        public BookEnter()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title;
            string author;
            string ISBN;
            string summary;

            //Using connection set up in program.cs
            //add
        }
        private void clear()
        {

        }
        private void BookEnter_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Are you sure you want to close? any unsaved data will be lost";
            string caption = "Close";
            var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);

        }
    }
}
