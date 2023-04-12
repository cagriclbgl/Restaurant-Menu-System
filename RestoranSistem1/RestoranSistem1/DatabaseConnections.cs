using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace RestoranSistem1
{
    class DatabaseConnections
    {
        public static SqlConnection baglan = new SqlConnection("Data Source=FENERBAHCE-1907;Initial Catalog=adisyon;Integrated Security=True");

    }
}
