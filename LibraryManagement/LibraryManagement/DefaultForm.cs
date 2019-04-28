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

        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            var movieDia = new MovieEnter();
            movieDia.ShowDialog();
        }
    }
}
