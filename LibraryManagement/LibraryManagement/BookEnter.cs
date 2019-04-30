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
            string genre = cbGenre.SelectedText;

            //Using connection set up in program.cs
            if (AddMedia(title, author,ISBN,summary,publisher,genre))
            {
                clear();
            }

        }
        public bool AddMedia(string title, string author, string ISBN, string summary,string publisher,string genre)
        {
            XElement doc = XElement.Load("..\\..\\UserNate.xml");
            doc//.Element("User").Element("Books")
                .Add(
                    new XElement("Books",
                    new XElement("Book",
                    new XElement("Title", title),
                    new XElement("Author", author),
                    new XElement("Genre", genre),
                    new XElement("Summary", summary),
                    new XElement("Publisher", publisher))));

            doc.Save("UserNate.xml");


            return true;
        }
        private void clear()
        {
            tbTitle.Text = "";
            tbAuthor.Text = "";
            tbISBN.Text = "";
            tbSummary.Text = "";
            tbPublisher.Text = "";
            cbGenre.SelectedText = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            tbTitle.Text = "Leviathan Wakes";
            tbAuthor.Text = "James A Cordory";
            tbISBN.Text = "123456";
            tbSummary.Text = "Space is deadly, will they survive in the outer where no one can hear you scream?";
            tbPublisher.Text = "Oribit";
            cbGenre.SelectedText = "Science fiction";
        }
    }
}
