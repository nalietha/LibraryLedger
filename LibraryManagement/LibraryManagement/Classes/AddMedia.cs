using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryManagement.Classes
{
    class AddMedia : User
    {

        private string _UserDataFile;
        string xmldoc = File.ReadAllText("..\\..\\Data\\UserNate.xml");


        public AddMedia()
        {

        }
        public bool AddBook(string file, string title, string author, string ISBN, string summary, string publisher, string genre)
        {
            XDocument doc = XDocument.Load(file);
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

            doc.Save(file);
            return true;
        }

        public bool AddMovie(string file, string title, string author, string summary, string genre)
        {
            XDocument doc = XDocument.Load(file);
            int numberOfMovies = doc.Descendants("Movie").Count();

            XElement Movie = (
                    new XElement("Movie", new XAttribute("id", numberOfMovies + 1),
                    new XElement("Title", title),
                    new XElement("Director", author),
                    new XElement("Genre", genre),
                    new XElement("Summary", summary)));

            //doc.Element("User").Element("Books").Add(new XElement(Book));
            doc.Root.Element("Movies").Add(Movie);

            doc.Save(file);
            return true;
        }

        public bool CheckDuplicates(string title, string iSBN, string file, string key )
        {
            // Check for dublicate books, Using title and ISBN
            //foreach(var bookid in xmldoc)
            //{
            //    if()
            //}


            return false;
        }

    }
}


 