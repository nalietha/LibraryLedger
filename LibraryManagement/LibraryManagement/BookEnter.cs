using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace LibraryManagement
{

    public partial class BookEnter : Form
    {
        Classes.AddMedia Media = new Classes.AddMedia();

        private string _FileLocation = "..\\..\\Data\\UserNate.xml";
        public BookEnter()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            string ISBN = tbISBN.Text;
            string summary = tbSummary.Text;
            string publisher = tbPublisher.Text;
            string genre = cbGenre.GetItemText(cbGenre.SelectedItem);

            //Using connection set up in program.cs
            if (CheckForData())
            {
                if (CheckDuplicates(title, ISBN))
                {
                    string message = "Book is already in your Catalog";
                    string caption = "Duplicate";
                    var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Question);
                }
                else
                {
                    Media.AddBook(_FileLocation, title, author, ISBN, summary, publisher, genre);
                    clear();
                }
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

        private bool CheckDuplicates(string title, string iSBN)
        {
            // Check for dublicate books, Using title and ISBN
            //throw new NotImplementedException();
            return false;
            
        }

        private void clear()
        {
            tbTitle.Text = "";
            tbAuthor.Text = "";
            tbISBN.Text = "";
            tbSummary.Text = "";
            tbPublisher.Text = "";
            cbGenre.SelectedIndex = 0;
        }
        private void BookEnter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(UnsavedData())
            {
                string message = "Are you sure you want to close? Any unsaved data will be lost";
                string caption = "Close";
                var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                e.Cancel = (result == DialogResult.No);
            }

        }

        private bool UnsavedData()
        {
            //throw new NotImplementedException();
            // Add Checks for data entry boxes
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbTitle.Text = "Goliath";
            tbAuthor.Text = "Scott Westerfeild";
            tbISBN.Text = "978-1-4169-7178-8";
            tbSummary.Text = "Alek and Deryn are aboard the Leviathan when the ship is ordered to pick up an unsual passenger. This brilliant/manical Inventer claims to have a weapon called Goliath that can end the war. But whose side is he really on?";
            tbPublisher.Text = "Simon Pulse";
            cbGenre.SelectedText = "Historical fiction";
        }
        private bool CheckForData()
        {
            if(tbTitle.Text == null || tbTitle.Text == string.Empty)
            {
                return false;
            }
            else if (tbAuthor.Text == null || tbAuthor.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

    }
}
