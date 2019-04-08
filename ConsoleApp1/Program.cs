using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book1 = new ThrowAwayGradeBook();

            /*
            //the += adds multiple methods to the delegate. Do not have to use the new NameChangedDelegate()
            book1.NameChanged += OnNameChanged;
           
            //cannot use assignment with events.
            //book1.NameChanged = null;

            book1.Name = "Nate's Grade book";
            book1.Name = "Grade book ";
            */

            //GetBookName(book1);
            AddGrades(book1);
            SaveGrades(book1);
            WriteResults(book1);

        }

        private static void WriteResults(GradeBook book1)
        {
            try
            {
                GradeStatistics stats = book1.ComputeStatistics();
                WriteResults("Average", stats.AverageGrade);
                WriteResults("Highest", stats.HighestGrade);
                WriteResults("Lowest", stats.LowestGrade);
                WriteResults(stats.Description, stats.LetterGrade);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

           
        }

        private static void SaveGrades(GradeBook book1)
        {
            using (StreamWriter outputFile = File.CreateText("Grades.txt"))
            {
                book1.WriteGrades(outputFile);
            }
        }

        private static void AddGrades(GradeBook book1)
        {
            book1.AddGrade(91);
            book1.AddGrade(89.5f);
            book1.AddGrade(75);
        }

        private static void GetBookName(GradeBook book1)
        {
            try
            {
                Console.WriteLine("Enter a Name: ");
                book1.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex + "Something went wrong!");
            }
        }

        /*
        static void WriteResults(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }
        */

        static void WriteResults(string description, string result)
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
