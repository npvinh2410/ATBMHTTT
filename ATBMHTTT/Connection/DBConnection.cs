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
        public static OracleConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 1521;
            string sid = "xe";
            string user = "DBA_THUVIEN2";
            string password = "DBA_THUVIEN2";

            return DBOracleUtils.GetDBConnection(host, port, sid, user, password);
        }
    }
}
