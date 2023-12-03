using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSys
{
    public class Subject
    {
        private int Fagkode { get; set; }
        public string Fagnavn { get; set; }
        public int Studiepoeng { get; set; }

        public Subject(int fagkode, string fagnavn, int studiepoeng)
        {
            Fagkode = fagkode;
            Fagnavn = fagnavn;
            Studiepoeng = studiepoeng;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Fagkode: {Fagkode}\n" +
                              $"Fagnavn: {Fagnavn}\n" +
                              $"Studiepoeng: {Studiepoeng}\n\n");
        }
    }
}
