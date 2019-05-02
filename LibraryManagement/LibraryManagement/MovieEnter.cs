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
        public MovieEnter()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            string summary = tbSummary.Text;
            string genre = cbGenre.SelectedText;

            if (AddMedia(title, author, summary, genre))
            {
                clear();
            }

        }
        public bool AddMedia(string title, string author,  string summary, string genre)
        {
            if (CheckForData())
            {


                int id = 1;
                XDocument doc = XDocument.Load("..\\..\\Data\\UserNate.xml");
                int numberOfBooks = doc.Descendants("Movie").Count();


                XElement Movie = (
                        new XElement("Movie", new XAttribute("id", numberOfBooks + 1),
                        new XElement("Title", title),
                        new XElement("Director", author),
                        new XElement("Genre", genre),
                        new XElement("Summary", summary)));

                //doc.Element("User").Element("Books").Add(new XElement(Book));
                doc.Root.Element("Movies").Add(Movie);

                doc.Save("..\\..\\Data\\UserNate.xml");
            }
            else
            {
                string message = "Enter required data";
                string caption = "Required";
                var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Question);
            }

            return true;
        }
        private void clear()
        {
            tbTitle.Text = "";
            tbAuthor.Text = "";
            tbSummary.Text = "";
            cbGenre.SelectedText = "";
        }
        private void MovieEnter_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Are you sure you want to close? Any unsaved data will be lost";
            string caption = "Close";
            var result = MessageBox.Show(message, caption,
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);

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
