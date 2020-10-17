using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;
using Dapper;

namespace Fri2Ends.ORM.DBConnection
{
    public class FrMconnection 
    {
        SqlConnection sqlConnection = new SqlConnection("data source=.;initial catalog = fri2ends;integrated security = true");

        private IDbCommand cmd;
        public void te()
        {
            
        }
    }

    public static class t
    {
        public static int Query(this IDbConnection connection)
        {
            connection.Query<>()
        }
    }
}
