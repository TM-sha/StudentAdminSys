using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSys
{
    public class Grade
    {
        public Student student { get; set; }
        public Subject subject { get; set; }
        public int grade { get; set; }

        public Grade(Student student, Subject subject, int grade)
        {
            this.student = student;
            this.subject = subject;
            this.grade = grade;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {student.Navn}\n" +
                              $"Fag: {subject.Fagnavn}\n" +
                              $"Karakter: {grade}\n");
        }
    }
}
