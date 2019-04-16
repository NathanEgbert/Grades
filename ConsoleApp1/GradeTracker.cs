using Grades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);

        public abstract GradeStatistics ComputeStatistics();

        public abstract void WriteGrades(TextWriter destination);

        public abstract IEnumerator GetEnumerator();

        //this is a field
        protected string _name;

        //this is a delegate. A variable that points to a method.
        //public NameChangedDelegate NameChanged;

        //event
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty!");
                }

                if (_name != value)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.NewName = value;
                    args.ExistingName = _name;

                    //delegate 
                    NameChanged(this, args);
                }
                _name = value;

            }
        }// property 

    }
}
