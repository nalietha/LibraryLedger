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
        private readonly string _File = "..\\..\\Data\\UserNate.xml";

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

        //private void Search(string keyword)
        //{
        //    var doc = XDocument.Load(_File);

        //    var query = doc.Descendants()
        //        .Where(x => !x.HasElements &&
        //                    x.Value.IndexOf(keyword, StringComparison.InvariantCultureIgnoreCase) >= 0);

        //    lvBookDisplay.Items.Clear();
        //    lvBookDisplay.Columns.Clear();
        //    if(btnSwitch.Text == "Show Movies")
        //    {
        //        lvBookDisplay.Columns.Add("Title");
        //        lvBookDisplay.Columns.Add("Director");
        //        lvBookDisplay.Columns.Add("Genre");

        //        ListViewItem item = new ListViewItem(new string[]
        //            {
        //            query("Title").Value,
        //            query.Element("Author").Value,
        //            query.Element("Genre").Value,
        //            query.Element("ISBN").Value,
        //            //layer.Element("Summary").Value,
        //            query.Element("Publisher").Value
        //            });
        //            lvBookDisplay.Items.Add(item);
            
                    
        //    }
        //    else
        //    {
        //        lvBookDisplay.Columns.Add("Title");
        //        lvBookDisplay.Columns.Add("Author");
        //        lvBookDisplay.Columns.Add("Genre");
        //        lvBookDisplay.Columns.Add("ISBN");
        //        lvBookDisplay.Columns.Add("Publisher");
        //    }
        //    foreach (var element in query)
        //            Console.WriteLine(element);

        //    lvBookDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        //    lvBookDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        //}


        private void DefaultForm_Load(object sender, EventArgs e)
        {
            SwitchListView();
        }
        private void SwitchListView(bool flag = true)
        {
            XDocument doc = XDocument.Load(_File);

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
                lvBookDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvBookDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

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
                lvBookDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvBookDisplay.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            plExtendedView.Visible = false;
        }

        private void lvBookDisplay_DoubleClick(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(_File);

            string index = ((((System.Windows.Forms.ListView)sender).FocusedItem.Index)+1).ToString();

            if(btnSwitch.Text == "Show Movies")
            {
                var exp = doc.Root.Descendants("Books").Elements("Book").Where(n => n.Attribute("id").Value == index).Single();
                //Show Boxes: ChangeText
                lblAuthorDisplay.Text = "Author:";
                lblPublisherDisplay.Visible = true;
                tbPublisherDisplay.Visible = true;
                lblISBNDisplay.Visible = true;
                tbISBNDisplay.Visible = true;

                // Additems to new view
                tbTitleDisplay.Text = exp.Element("Title").Value;
                tbAuthorDisplay.Text = exp.Element("Author").Value;
                tbPublisherDisplay.Text = exp.Element("Publisher").Value;
                tbGenreDisplay.Text = exp.Element("Genre").Value;
                tbSummaryDisplay.Text = exp.Element("Summary").Value;
                tbISBNDisplay.Text = exp.Element("ISBN").Value;
            }
            else
            {
                var exp = doc.Root.Descendants("Movies").Elements("Movie").Where(n => n.Attribute("id").Value == index).Single();
                // Hide unneed Boxes/labels
                lblAuthorDisplay.Text = "Director:";
                lblPublisherDisplay.Visible = false;
                tbPublisherDisplay.Visible = false;
                lblISBNDisplay.Visible = false;
                tbISBNDisplay.Visible = false;
                
                // Additems to new view
                tbTitleDisplay.Text = exp.Element("Title").Value;
                tbAuthorDisplay.Text = exp.Element("Director").Value;
                tbGenreDisplay.Text = exp.Element("Genre").Value;
                tbSummaryDisplay.Text = exp.Element("Summary").Value;
            }
            // Display new view
            plExtendedView.Visible = true;
        }

        private void tbSummaryDisplay_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
