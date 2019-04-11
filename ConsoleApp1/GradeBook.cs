using ConsoleApp1;
using Grades;
using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{

    public class GradeBook : GradeTracker
    {

        protected List<float> grades;

        public GradeStatistics statistics;


        //constructor 
        public GradeBook()
        {
            grades = new List<float>();
            _name = "Empty";
        }

        public override void WriteGrades(TextWriter destination)
        {
            for (int i = grades.Count; i > 0; i--)
            {
                destination.WriteLine(grades[i - 1]);
            }
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }//end method

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("Inside of GradeBook");
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;

        }//end method

    }
}
