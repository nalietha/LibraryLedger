using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace LibraryManagement.Classes
{
    class DataConn
    {
        private SQLiteConnection sqlite;    
        
        public DataConn()
        {
            sqlite = new SQLiteConnection("Data Source=/LibraryManagement/LibraryManagement/Database.db");

        }

        
    }
}
