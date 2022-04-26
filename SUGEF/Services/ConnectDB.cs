using System;
using MySql.Data.MySqlClient;

namespace SUGEF.Services
{
    internal class ConnectDB
    {
        private MySqlConnection connect = null;
        public bool Connect()
        {
            try {
                string connectionString = "datasource=localhost;username=root;password=admin;database=SUGEF";
                this.connect = new MySqlConnection(connectionString);
                this.connect.Open();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        public bool InsertAction(string sqlQuery)
        {
            try{
                MySqlCommand command = new MySqlCommand(sqlQuery,connect);
                command.ExecuteReader();
                return true; 
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void Disconnect()
        {
            this.connect.Close();
        }
    }
}
