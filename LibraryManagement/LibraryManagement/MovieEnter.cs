using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryManagement
{
    public partial class MovieEnter : Form
    {
        private string _FileLocation= "..\\..\\Data\\UserNate.xml";
        Classes.AddMedia MMedia = new Classes.AddMedia();

        public MovieEnter()
        {
            InitializeComponent();
        }

        public MovieEnter(string User)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            string summary = tbSummary.Text;
            string genre = cbGenre.SelectedText;

            if (CheckForData())
            {
                MMedia.AddMovie(_FileLocation, title, author, summary, genre);
                clear();
            }
            else
            {
                string message = "Enter required data";
                string caption = "Required";
                var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Question);
            }
        }
        private bool UnsavedData()
        {
            //throw new NotImplementedException();
            // Add Checks for data entry boxes
            if (tbTitle.Text == "" &&
                    tbAuthor.Text == "" &&
                    tbSummary.Text == "")
            {
                return false;
            }
            return true;
        }

        private void clear()
        {
            tbTitle.Text = "";
            tbAuthor.Text = "";
            tbSummary.Text = "";
            cbGenre.ResetText();

        }

        private void MovieEnter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UnsavedData())
            {
                string message = "Are you sure you want to close? Any unsaved data will be lost";
                string caption = "Close";
                var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                e.Cancel = (result == DialogResult.No);
            }
        }

        private bool CheckForData()
        {
            if (tbTitle.Text == null || tbTitle.Text == string.Empty)
            {
                return false;
            }
            else if (tbAuthor.Text == null || tbAuthor.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbTitle.Text = "Avengers: EndGame";
            tbAuthor.Text = "Russo Brothers";
            tbSummary.Text = "Avengers are broken, the world is half gone, what is next?";
            cbGenre.SelectedText = "Action";
        }
    }
}
