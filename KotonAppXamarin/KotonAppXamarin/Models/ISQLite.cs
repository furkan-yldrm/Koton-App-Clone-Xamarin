using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KotonAppXamarin.Models
{   
        public interface ISQLite
        {
            SqliteConnection GetConnection();
        }   
}
