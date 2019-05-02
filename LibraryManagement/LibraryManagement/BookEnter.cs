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
            if (AddMedia(title, author,ISBN,summary,publisher,genre))
            {
                clear();
            }

        }
        public bool AddMedia(string title, string author, string ISBN, string summary, string publisher, string genre)
        {
            if (CheckForData())
            {
                XDocument doc = XDocument.Load(_FileLocation);
                int numberOfBooks = doc.Descendants("Book").Count();


                XElement Book = (
                        new XElement("Book", new XAttribute("id", numberOfBooks + 1),
                        new XElement("Title", title),
                        new XElement("Author", author),
                        new XElement("Genre", genre),
                        new XElement("ISBN", ISBN),
                        new XElement("Publisher", publisher),
                        new XElement("Summary", summary)));

                //doc.Element("User").Element("Books").Add(new XElement(Book));
                doc.Root.Element("Books").Add(Book);

                doc.Save(_FileLocation);
            }
            else
            {
                string message = "Enter required data";
                string caption = "Required";
                var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Question);
                return false;
            }

            return true;
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

            string message = "Are you sure you want to close? Any unsaved data will be lost";
            string caption = "Close";
            var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbTitle.Text = "Leviathan Wakes";
            tbAuthor.Text = "James A Cordory";
            tbISBN.Text = "123456";
            tbSummary.Text = "Space is deadly, will they survive in the outer where no one can hear you scream?";
            tbPublisher.Text = "Oribit";
            cbGenre.SelectedText = "Science fiction";
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
