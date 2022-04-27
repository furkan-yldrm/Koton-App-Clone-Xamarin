using KotonAppXamarin.Models;
using Microsoft.Data.Sqlite;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(MediaMarkt.Droid.SQLite_Android))]
namespace MediaMarkt.Droid
{  
    public class SQLite_Android : ISQLite
    {
        public SqliteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabase.db";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var cn = new SqliteConnection(path);
            return cn;
        }

        SqliteConnection ISQLite.GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}