using System;
using System.IO;
using Xamarin.Forms;
using NewProject;
using NewProject.Droid;
using SQLite;

[assembly: Dependency(typeof(Sqlite_droid))]
namespace NewProject.Droid
{
    public class Sqlite_droid : ISQLite
    {
        public Sqlite_droid()
        {

        }

        public SQLite.SQLiteConnection GetConnection()
        {
            var sqlFilename = "NewProject.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqlFilename);
            var conn = new SQLiteConnection(path);
            return conn;
        }

    }
}