using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSys
{
    public class Student
    {
        public string Navn { get; set; }
        private int Alder { get; set; }
        private string Studieprogram { get; set; }
        private Guid StudentId { get; set; }


        public Student(string navn, int alder, string studieprogram, Guid studentId)
        {
            Navn = navn;
            Alder = alder;
            Studieprogram = studieprogram;
            StudentId = studentId;
        }


        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn: {Navn}\n" +
                              $"Alder: {Alder}\n" +
                              $"Studieprogram: {Studieprogram}\n" +
                              $"StudentID: {StudentId}\n\n");
        }

        public double GjennomsnittsKarakter()
        {
            double _gjennomsnitt = 0;
            double _antallKarakterer = 0;


            foreach (Grade karakter in Program.grades)
            {
                if (karakter.student == this)
                {
                    _antallKarakterer++;
                    _gjennomsnitt += (double)karakter.grade;
                }
            }

            double resultat = _gjennomsnitt / _antallKarakterer;
            return resultat;
        }

        public int TotalStudiepoeng()
        {
            int _studiepoeng = 0;


            foreach (Grade karakter in Program.grades)
            {
                if (karakter.student == this)
                {
                    _studiepoeng += karakter.subject.Studiepoeng;
                }
            }
            return _studiepoeng;
        }
    }
}
