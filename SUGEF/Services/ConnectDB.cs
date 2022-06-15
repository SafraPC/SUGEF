using System;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SUGEF.Controller.Student;

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
                Debug.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                this.connect.Close();
            }
        }

        public MySqlConnection Connection()
        {
            if (this.connect == null)
            {
                Connect();
            }
            return this.connect;
        }

        public UserController Login(string login, string senha)
        {
            try
            {
                if (this.connect == null)
                {
                    Connect();
                }

                this.connect.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM Users WHERE userLogin = '"+login+"' AND userSenha = '"+senha+"'", this.connect);
                MySqlDataReader reader = command.ExecuteReader();
                UserController user = new UserController();
                while (reader.Read())
                {
                    user.UserId = int.Parse(reader.GetString("userId")); 
                    user.UserName = reader.GetString("userName");
                    user.UserTipo = reader.GetString("userTipo");
                    user.UserLogin = reader.GetString("userLogin");
                    user.UserNascimento = reader.GetString("userNascimento");
                    user.UserCpf = reader.GetString("userCpf");
                    user.UserFoto = reader.GetString("userFoto");
                }
                return user;
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                this.connect.Close();
            }
        }
    }
}
