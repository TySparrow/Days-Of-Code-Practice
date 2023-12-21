using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_Of_Code;

namespace CodingKatasTests
{
    [TestClass]
    public class FizzArray3Tests
    {
        [TestMethod]
        public void FizzArray_ValidArray_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int[] result = testObject.FizzArray3(1, 4);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, result);
        }
        [TestMethod]
        public void FizzArray_LargerValues_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int[] result = testObject.FizzArray3(10, 20);

            CollectionAssert.AreEqual(new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, result);
        }
        [TestMethod]
        public void FizzArray_SameIntValues_Test()
        {

            CodingKatas testObject = new CodingKatas();

            int[] result = testObject.FizzArray3(6, 6);

            CollectionAssert.AreEqual(new int[] {}, result);
        }

        //Commented Out because of instructions (end is always bigger, or equal to start)

        //[TestMethod]
        //public void FizzArray_EndSmallerThanStart_Test()
        //{
        //    CodingKatas testObject = new CodingKatas();

        //    int[] result = testObject.FizzArray3(5, 1);

        //    CollectionAssert.AreEqual(new int[] { }, result);
        //}
    }
}
