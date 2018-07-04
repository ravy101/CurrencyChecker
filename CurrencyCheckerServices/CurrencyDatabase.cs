using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CurrencyCheckerServices
{
    class CurrencyDatabase
    {
        private static readonly string databaseHost = "localhost";
        private static readonly string databaseUser = "currencyclient";
        private static readonly string databasePassword = "hifu7Oqi";

        public static void InsertApiRequestRecord()
        {
            using (MySqlConnection connection = new MySqlConnection($"server={databaseHost};userid={databaseUser};database={databasePassword}"))
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {

                }

                connection.Close();
            }


        }

 

    }
}
