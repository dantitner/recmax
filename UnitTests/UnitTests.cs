using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using RecMax;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        static IEnumerable<object[]> ReusableTestDataProperty
        {
            get
            {
                return new[]
                {
                new object[] {new int[]{ 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, new int[] { 7, 7, 70, 17 }, 7 },
            };
            }
        }

        // Property ReusableTestDataProperty can be used as data source for test data with data driven test case.
        [TestMethod]
        [DynamicData("ReusableTestDataProperty")]
        public void DynamicDataTestMethod1(int[] incoming, int[] expected, int filter)
        {
            int[] actual = NumOutOfDig.FilterDigit(incoming, filter);
            bool isSameLength = actual.Length == expected.Length ? true : false;
            bool isElementEqual = actual[2] == expected[2] ? true : false;
            Assert.IsTrue(isElementEqual & isElementEqual);
        }

        
    }
}
