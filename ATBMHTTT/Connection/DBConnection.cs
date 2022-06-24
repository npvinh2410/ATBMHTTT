using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ATBMHTTT.Connection
{
    class DBConnection
    {
        public static OracleConnection GetDBConnection(string user, string password)
        {
            string host = "localhost";
            int port = 1521;
            string sid = "xe";

            return DBOracleUtils.GetDBConnection(host, port, sid, user, password);
        }

        public static OracleConnection GetDBConnection_OLS(string user, string password)
        {
            string host = "localhost";
            int port = 1521;
            string sid = "ols_demo";

            return DBOracleUtils.GetDBConnection(host, port, sid, user, password);
        }
    }
}
