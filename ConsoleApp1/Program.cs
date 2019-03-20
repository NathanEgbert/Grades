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

            book1.AddGrade(91);
            book1.AddGrade(89.5f);
            book1.AddGrade(75);

            GradeStatistics stats = book1.ComputeStatistics();

            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.AverageGrade);
        }
    }
}
