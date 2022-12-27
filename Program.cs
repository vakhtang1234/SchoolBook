using System;
using System.Linq;
using System.IO;
namespace Schoolbook
{
    class Program
    {
        static void Main(string[] Args)
        {
            SchoolLessons school = new SchoolLessons();
            Grades grades = new Grades();
            school.Lessons();

            bool b = true;
            while(b)
            {
                System.Console.WriteLine(' ');
                System.Console.WriteLine(" ");
                System.Console.WriteLine("Type 1 if you want to see your grades");
                System.Console.WriteLine("Type 2 if you want to exit");
                int result = Convert.ToInt32(Console.ReadLine());
                switch(result)
                {
                    case 1:
                        grades.AverageGrades();
                        break;
                    case 2:
                        b = false;
                        break;
                    default:
                        System.Console.WriteLine("Enter a proper number");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

