﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "nate";
            name =  name.ToUpper();

            Assert.AreEqual("NATE", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
             date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);
            Assert.AreEqual(46, x);
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAname(book2);
            Assert.AreEqual("A Grade book", book1.Name);

        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Nate";
            string name2 = "nate";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);

        }

        [TestMethod]
        public void VariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Nate's grade book";
            Assert.AreEqual(g1.Name, g2.Name);

        }

        private void GiveBookAname(GradeBook book)
        {
            book.Name = "A Grade book";
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

    }
}
