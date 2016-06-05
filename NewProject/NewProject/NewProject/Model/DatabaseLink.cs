using System;
using SQLite;

namespace NewProject
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
