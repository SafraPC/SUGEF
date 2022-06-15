using MySql.Data.MySqlClient;
using SUGEF.Controller.Student;
using SUGEF.Services;
using System;
using System.Diagnostics;

namespace SUGEF.Model.Director
{
    public class DirectorRequest
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

        public bool CreateTurma(string idMateria, string periodo, string ano,string totalFaltas)
        {
            try
            {
                this.connect.Open();
                UserModel professorSelect = new UserModel();
                MySqlCommand command = new MySqlCommand("INSERT INTO Turma VALUES" +
                    $" (default,'{idMateria}','{periodo}','{ano}','{totalFaltas}');", this.connect);
                MySqlDataReader reader = command.ExecuteReader();
                return true;    
            }catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                this.connect.Close();
            }
        }

        public bool EnrollUser(string userId, string turmaId,string qtdFalta)
        {
            try
            {
                this.connect.Open();
                UserModel professorSelect = new UserModel();
                MySqlCommand command = new MySqlCommand("INSERT INTO Matricula VALUES" +
                    $" (default,'{userId}','{turmaId}','{qtdFalta}');", this.connect);
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
