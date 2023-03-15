using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookServices
{
    
    class DBConnection
    {
        // Gets the connection.
        public SqlConnection GetConnection()
        {
            // Specifying the connection string from the sql server connection
            string connectionString = @"Data Source=DESKTOP-MU7AL7S\TEW_SQLEXPRESS;Initial Catalog = addressBook_services; User ID=MeghanaDasari;Password=Maggi@22;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            // Using the underlying sql server to establish the connection
            SqlConnection dbConnection = new SqlConnection(connectionString);
            return dbConnection;
        }
    }
}