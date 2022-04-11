using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace ATBMHTTT.DBConnection
{
    class DBUtils
    {
        public static OracleConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 1521;
            string sid = "xe";
            string user = "nguyenvana";
            string password = "nguyenvana";

            return DBOracleUtils.GetDBConnection(host, port, sid, user, password);
        }
    }
}
