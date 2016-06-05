using System;
using System.IO;
using Xamarin.Forms;
using SQLite;
using SQLitePCL;
using NewProject;
using NewProject.iOS;


[assembly: Dependency(typeof(DatabaseMain))]
namespace NewProject.iOS
{
    public class DatabaseMain : ISQLite
    {

        public DatabaseMain()
        {

        }


        public SQLite.SQLiteConnection GetConnection()
        {


            var sqlFilename = "NewProject.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, sqlFilename);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }





    }


}


