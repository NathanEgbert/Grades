using Grades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ThrowAwayGradeBook : GradeBook
    {

        public GradeStatistics ComputeStatistics()
        {
            float lowest = float.MaxValue;
            foreach(float grade in grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            grades.Remove(lowest);

            // base uses the base class - Gradebook
            return base.ComputeStatistics();
        }
    }
}
