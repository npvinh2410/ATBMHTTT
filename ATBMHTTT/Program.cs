using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ATBMHTTT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
             {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2_Login());

            /*OracleConnection conn = Connection.DBConnection.GetDBConnection(user, password);

            Console.WriteLine("Get Connection: " + conn);
            try
            {
                conn.Open();

                Console.WriteLine(conn.ConnectionString, "Successful Connection");
            }
            catch (Exception ex)
            {
                Console.WriteLine("## ERROR: " + ex.Message);
                Console.Read();
                return;
            }

            Console.WriteLine("Connection successful!");

            Console.Read();*/
        }
    }
}
