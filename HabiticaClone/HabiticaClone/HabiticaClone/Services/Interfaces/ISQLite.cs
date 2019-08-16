using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabiticaClone.Services.Interfaces
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
