using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book1 = new GradeBook();

            book1.Name = "Nate's Gradebook";
            book1.Name = null;

            book1.AddGrade(91);
            book1.AddGrade(89.5f);
            book1.AddGrade(75);

            GradeStatistics stats = book1.ComputeStatistics();

            Console.WriteLine(book1.Name);
            WriteResults("Average", stats.AverageGrade);
            WriteResults("Highest", (int)stats.HighestGrade);
            WriteResults("Lowest", stats.LowestGrade);

        }

        static void WriteResults(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResults(string description, float result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }
    }
}
