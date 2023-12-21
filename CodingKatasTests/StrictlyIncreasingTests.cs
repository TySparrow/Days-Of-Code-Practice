using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_Of_Code;

namespace CodingKatasTests
{
    [TestClass]
    public class StrictlyIncreasingTests
    {
        [TestMethod]
        public void StrictlyIncreasing_True_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.IsStrictlyIncreasing(new int[] { 1, 2, 3, 4, 5, 6, 20, 25 });

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Not_Strictly_Increasing_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.IsStrictlyIncreasing(new int[] { 1, 2, 3, 3, 5, 6, 20, 25 });

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Empty_Array_IsIncreasing_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.IsStrictlyIncreasing(new int[] {});

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void StrictlyIncreasing_WithNegatives_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.IsStrictlyIncreasing(new int[] { -20, -2, 0, 4, 5, 6, 20, 25 });

            Assert.AreEqual(true, result);
        }

    }
}
