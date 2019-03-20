using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {

        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book1 = new GradeBook();

            book1.AddGrade(98);
            book1.AddGrade(87);
            book1.AddGrade(43);

            GradeStatistics results = book1.ComputeStatistics();

            Assert.AreEqual(98, results.HighestGrade);

        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book1 = new GradeBook();

            book1.AddGrade(98);
            book1.AddGrade(87);
            book1.AddGrade(43);

            GradeStatistics results = book1.ComputeStatistics();

            Assert.AreEqual(43, results.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book1 = new GradeBook();

            book1.AddGrade(91);
            book1.AddGrade(89.5f);
            book1.AddGrade(75);

            GradeStatistics results = book1.ComputeStatistics();

            Assert.AreEqual(85.16, results.AverageGrade, 0.01);

        }
    }
}
