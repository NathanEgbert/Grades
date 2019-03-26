using Grades;
using System;
using System.Collections.Generic;

namespace Grades
{
   public class GradeBook
    {

        private List<float> grades;

        //this is a field
        private string _name;

        //this is a delegate
        public event NameChangedDelegate NameChanged;

        //this is a property
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if(_name != value)
                    {
                        //delegate 
                        NameChanged(_name, value);
                    }
                    _name = value;
                }
            }
        }// property 

        //constructor 
        public GradeBook()
        {
            grades = new List<float>();
            _name = "Empty";
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }//end method

        public GradeStatistics ComputeStatistics()
        {

            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach(float grade in grades)
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
