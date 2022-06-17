using MySql.Data.MySqlClient;
using SUGEF.Components.Cards;
using SUGEF.Controller.Student;
using SUGEF.Helpers;
using SUGEF.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace SUGEF.View.Student
{
    public partial class StudentClass : Form
    {
        private UserModel student;
        private MySqlConnection connect = new ConnectDB().Connection();
        private StudentCard studentCard = new StudentCard();
        public StudentClass(UserModel student)
        {
            InitializeComponent();
            this.student = student;
            AutomatizeScreen formConfig = new AutomatizeScreen(this);
            formConfig.RenderSidebarStudent(this, student);
            SetTurmas();
        }

        private void SetTurmas()
        {
            try
            {
                connect.Open();
                List<string> studentTurmas = new List<string>();
                MySqlCommand command = new MySqlCommand("", this.connect);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    //studentTurmas.Add(reader.GetString("turmaId") + "|" + reader.GetString("materiaNome") + "|" + reader.GetString("turmaPeriodo") + "|" +
                    //    reader.GetString("turmaAno"));
                }
                //studentTurmas.ForEach(item =>
                //{
                //    this.flowPanel.Controls.Add(studentCard.CreateTurmasPanel(item, this, student));
                //});
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
