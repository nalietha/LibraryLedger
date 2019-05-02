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
    public partial class DefaultForm : Form
    {
        public DefaultForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var bookDia = new BookEnter();
            bookDia.ShowDialog();
            // Update List
            DefaultForm_Load(sender, e);

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            var movieDia = new MovieEnter();
            movieDia.ShowDialog();
            // Update List
            DefaultForm_Load(sender, e);

        }


        private void DefaultForm_Load(object sender, EventArgs e)
        {
            SwitchListView();
        }
        private void SwitchListView(bool flag = true)
        {
            XDocument doc = XDocument.Load("..\\..\\Data\\UserNate.xml");

            if (flag)
            {
                lvBookDisplay.Items.Clear();
                lvBookDisplay.Columns.Clear();
                var displayList = doc.Root.Elements("Book").Select(element => element.Value).ToList();
                int loopExit = doc.Descendants("Book").Count();

                lvBookDisplay.Columns.Add("Title");
                lvBookDisplay.Columns.Add("Author");
                lvBookDisplay.Columns.Add("Genre");
                lvBookDisplay.Columns.Add("ISBN");
                //lvBookDisplay.Columns.Add("Summary");
                lvBookDisplay.Columns.Add("Publisher");

                foreach (var layer in doc.Descendants("Book"))
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    layer.Element("Title").Value,
                    layer.Element("Author").Value,
                    layer.Element("Genre").Value,
                    layer.Element("ISBN").Value,
                    //layer.Element("Summary").Value,
                    layer.Element("Publisher").Value
                    });
                    lvBookDisplay.Items.Add(item);
                }
            }
            else
            {
                lvBookDisplay.Items.Clear();
                lvBookDisplay.Columns.Clear();
                var displayList = doc.Root.Elements("Movie").Select(element => element.Value).ToList();
                int loopExit = doc.Descendants("Movie").Count();

                lvBookDisplay.Columns.Add("Title");
                lvBookDisplay.Columns.Add("Director");
                lvBookDisplay.Columns.Add("Genre");
                //lvBookDisplay.Columns.Add("Summary");
                //lvBookDisplay.Columns.Add("Publisher");


                foreach (var layer in doc.Descendants("Movie"))
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    layer.Element("Title").Value,
                    layer.Element("Director").Value,
                    layer.Element("Genre").Value,
                    //layer.Element("Summary").Value,
                    //layer.Element("Publisher").Value
                    });
                    lvBookDisplay.Items.Add(item);
                }
            }
            

        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if(btnSwitch.Text == "Show Movies")
            {
                SwitchListView(false);
                btnSwitch.Text = "Show Books";
            }
            else
            {
                SwitchListView(true);
                btnSwitch.Text = "Show Movies";
            }
        }
    }
}
