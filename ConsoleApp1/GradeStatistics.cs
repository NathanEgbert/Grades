using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
   public class GradeStatistics
    {

        public float HighestGrade;
        public float LowestGrade;
        public float AverageGrade;

        public GradeStatistics()
        {
            HighestGrade = 0;
            //using float.MaxValue to compare the lowest grade to the highest grade possble
            LowestGrade = float.MaxValue;
        }

       

    }
}
