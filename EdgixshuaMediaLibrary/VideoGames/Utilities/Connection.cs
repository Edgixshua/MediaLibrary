using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgixshuaMediaLibrary
{
    public class Connection
    {
        public string GetDatabaseConnectionString()
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MediaLibrary";

            return connectionString;
        }
    }
}
