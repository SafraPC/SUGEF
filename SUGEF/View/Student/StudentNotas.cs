using MySql.Data.MySqlClient;
using SUGEF.Controller.Student;
using SUGEF.Helpers;
using SUGEF.Services;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;

namespace SUGEF.View.Student
{
    public partial class StudentNotas : Form
    {
        UserModel student;
        private MySqlConnection connect = new ConnectDB().Connection();
        private List<string> listUserTable = new List<string>();
        public StudentNotas(UserModel student)
        {
            InitializeComponent();
            this.student = student;
            AutomatizeScreen formConfig = new AutomatizeScreen(this);
            formConfig.RenderSidebarStudent(this, student);
            SetData();
        }

        private void SetData()
        {
            try
            {
                this.connect.Open();
                MySqlCommand command = new MySqlCommand("SELECT Notas.*, Materia.materiaId, Turma.turmaId, Matricula.totalFaltas,Turma.turmaFaltas, Matricula.matriculaId, Materia.materiaNome FROM " +
                "Matricula INNER JOIN Turma ON Turma.turmaId = Matricula.turmaId " +
                "INNER JOIN Materia ON Materia.materiaId = Turma.materiaId " +
                "INNER JOIN Notas ON Notas.matriculaId = Matricula.matriculaId " +
                $"WHERE Matricula.userId = {this.student.UserId}; ", this.connect);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string disciplina = reader.GetString("materiaNome");
                    string tFaltas = reader.GetString("totalFaltas");
                    string tAulas = reader.GetString("turmaFaltas");
                    string freq = (100 - ((int.Parse(tFaltas) * 100) / int.Parse(tAulas))).ToString();
                    string n1 = reader.GetString("nota1");
                    string n2 = reader.GetString("nota2");
                    string n3 = reader.GetString("nota3");
                    string n4 = reader.GetString("nota4");
                    string media = ((double.Parse(n1) + double.Parse(n2) + double.Parse(n3) + double.Parse(n4)) / 4).ToString();
                    string situacao = double.Parse(media) >= 5 && double.Parse(freq) >= 75 ? "Aprovado" : "Reprovado";
                    this.listUserTable.Add($"{disciplina}|{tFaltas}|{tAulas} |{freq} |{n1}|{n2}|{n3}|{n4}|{media}|{situacao}");
                    this.table.Rows.Add(disciplina, tFaltas, tAulas, freq, n1, n2, n3, n4, media, situacao);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                this.connect.Close();
            }
        }

        private void pdfButton_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog browser = new FolderBrowserDialog();
                browser.Description = "Local onde o PDF será salvo";
                if (browser.ShowDialog() == DialogResult.OK)
                {
                    Document pdf = new Document();
                    PdfWriter.GetInstance(pdf, new FileStream(browser.SelectedPath + "/SUGEFNotasAluno.pdf", FileMode.Create));
                    PdfPTable table = new PdfPTable(10);
                    table.AddCell("Disciplina");
                    table.AddCell("T.Faltas");
                    table.AddCell("T.Aulas");
                    table.AddCell("Freq.");
                    table.AddCell("N1");
                    table.AddCell("N2");
                    table.AddCell("N3");
                    table.AddCell("N4");
                    table.AddCell("Média");
                    table.AddCell("Situação");
                    this.listUserTable.ForEach(item =>
                    {
                        string[] itemArray = item.Split('|');
                        table.AddCell(itemArray[0]);
                        table.AddCell(itemArray[1]);
                        table.AddCell(itemArray[2]);
                        table.AddCell(itemArray[3]);
                        table.AddCell(itemArray[4]);
                        table.AddCell(itemArray[5]);
                        table.AddCell(itemArray[6]);
                        table.AddCell(itemArray[7]);
                        table.AddCell(itemArray[8]);
                        table.AddCell(itemArray[9]);
                    });
                    pdf.Open();
                    pdf.Add(table);
                    pdf.Close();
                }
            }catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
