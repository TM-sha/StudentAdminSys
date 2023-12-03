using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace StudentAdminSys
{
    public class Program
    {
        public static List<Grade> grades = new();
        static void Main()
        {
            Console.WriteLine("|====Studenter====|");
            Console.WriteLine();

            Student Tommy = new Student("Tommy Misje", 36, "IT", Guid.NewGuid());
            Student Stian = new Student("Stian Sundby", 26, "IT", Guid.NewGuid());
            Student John = new Student("John Doe", 32, "IT", Guid.NewGuid());


            Subject keySubject = new Subject(0016, "Nøkkelkompetanse", 1);
            Subject javaScript = new Subject(0020, "JavaScript", 3);
            Subject cSharp = new Subject(0030, "C#", 6);

            List<Student> students = new()
            {
                Tommy, Stian, John    
            };
            
            foreach (Student student in students)
            {
                student.SkrivUtInfo();
            }

            Console.ReadLine();
            Console.Clear();

            List<Subject> subjects = new()
            {
                keySubject, javaScript, cSharp
            };

            Console.WriteLine("|====Fagene====|");
            Console.WriteLine();

            foreach (Subject subject in subjects)
            {
                subject.SkrivUtInfo();
            }

            Console.ReadLine();
            Console.Clear();

            grades = new()
            {
                new Grade(Tommy, javaScript, 4),
                new Grade(Tommy, keySubject, 5),
                new Grade(Tommy, cSharp, 4),
                new Grade(Stian, javaScript,6),
                new Grade(Stian, keySubject, 6),
                new Grade(Stian, cSharp, 6),
                new Grade(John, javaScript, 5),
                new Grade(John, keySubject, 4),
                new Grade(John, cSharp, 5)
            };

            Console.WriteLine("|====Karakterer====|");
            Console.WriteLine();

            foreach (Grade grade in grades)
            {
                grade.SkrivUtInfo();
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("|====Karaktersnitt og total studiepoeng====|");
            Console.WriteLine();

            Console.WriteLine($"Tommy sitt karaktersnitt: {Tommy.GjennomsnittsKarakter()}\nStudiepoeng: {Tommy.TotalStudiepoeng()}\n");
            Console.WriteLine($"Stian sitt karaktersnitt: {Stian.GjennomsnittsKarakter()}\nStudiepoeng: {Stian.TotalStudiepoeng()}\n");
            Console.WriteLine($"John sitt karaktersnitt: {John.GjennomsnittsKarakter()}\nStudiepoeng: {John.TotalStudiepoeng()}");

            Console.ReadLine();
        }
    }
}