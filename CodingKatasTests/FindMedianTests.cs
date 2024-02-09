using Days_Of_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKatasTests
{
    [TestClass]
    public class FindMedianTests
    {
        [TestMethod]
        public void FindMedian_SeparateNums_Sorted()
        {
            CodingKatas testObject = new CodingKatas();

            List<int> testList = new List<int>{ 1, 2, 3, 4, 5 };

            int result = testObject.FindMedian(testList);

            Assert.AreEqual(3, result);

        }
        [TestMethod]
        public void FindMedian_Min_Length()
        {
            CodingKatas testObject = new CodingKatas();

            List<int> testList = new List<int> { 4 };

            int result = testObject.FindMedian(testList);

            Assert.AreEqual(4, result);
        }
        [TestMethod]
        public void FindMedian_Unsorted()
        {
            CodingKatas testObject = new CodingKatas();

            List<int> testList = new List<int> { 58, 94, 13, 67, 10, 45, 4, 33, 1, 39, 100, 6, 79, 73, 61, 70, 90 };

            int result = testObject.FindMedian(testList);

            Assert.AreEqual(58, result);
        }
        [TestMethod]
        public void FindMedian_IncludesNegativeNumbers_And_Duplicates()
        {
            CodingKatas testObject = new CodingKatas();

            List<int> testList = new List<int> { -99, -99, -1233, 4, 41, 3, -10, 0, 99, 24, 1000, 2, 0 };

            int result = testObject.FindMedian(testList);

            Assert.AreEqual(2, result);
        }
    }
}
