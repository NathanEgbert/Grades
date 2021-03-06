﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
   public class GradeStatistics
    {

        public float HighestGrade;
        public float LowestGrade;
        public float AverageGrade;

        public string LetterGrade
        {
            get
            {
                string result;
                if (AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
                else if(AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excelent";
                            break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    default:
                        result = "Failing";
                        break;
                }
                return result;

            }
        }


        public GradeStatistics()
        {
            HighestGrade = 0;
            //using float.MaxValue to compare the lowest grade to the highest grade possble
            LowestGrade = float.MaxValue;
        }

       

    }
}
