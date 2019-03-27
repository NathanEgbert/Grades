using ConsoleApp1;
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

            //the += adds multiple methods to the delegate. Do not have to use the new NameChangedDelegate()
            book1.NameChanged += OnNameChanged;
           
            //cannot use assignment with events.
            //book1.NameChanged = null;

            book1.Name = "Nate's Grade book";
            book1.Name = "Grade book ";
            

            book1.AddGrade(91);
            book1.AddGrade(89.5f);
            book1.AddGrade(75);

            GradeStatistics stats = book1.ComputeStatistics();

           
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

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

      
    }
}
