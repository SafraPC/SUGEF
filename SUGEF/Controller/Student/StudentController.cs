using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUGEF.Controller.Student
{
    public class StudentController
    {
        private string studentName, studentAge, studentEmail;
        private int studentId;

        public StudentController(int studentId, string studentName, string studentEmail, string studentAge)
        {
            this.studentName = studentName;
            this.studentEmail = studentEmail;
            this.studentAge = studentAge;
            this.studentId = studentId;
        }

        public string GetStudentName()
        {
            return studentName;
        }

        public string GetStudentAge()
        {
            return studentAge;
        }

        public string GetStudentEmail()
        {
            return studentEmail;
        }

        public int GetStudentID()
        {
            return studentId;
        }
    }
}
