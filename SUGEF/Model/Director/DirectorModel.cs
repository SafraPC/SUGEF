using MySql.Data.MySqlClient;
using SUGEF.Services;
using System;
using System.Diagnostics;

namespace SUGEF.Model.Director
{
    internal class DirectorModel
    {
        private MySqlConnection connect = new ConnectDB().Connection();
        public bool CreateUser(string userName, string userType, string userLogin, string userSenha, 
            string userNascimento, string userCpf)
        {
            try
            {
                this.connect.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO Users VALUES" +
                   $" (default,'{userName}','{userType}','{userLogin}','{userSenha}','{userNascimento}','{userCpf}','');", this.connect);
                MySqlDataReader reader = command.ExecuteReader();
                return true;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                this.connect.Close();
            }
        }
    }
}
