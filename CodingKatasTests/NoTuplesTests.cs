using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_Of_Code;

namespace CodingKatasTests
{
    [TestClass]
    public class NoTuplesTests
    {
        [TestMethod]
        public void No_Triplets_Returns_True_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.NoTuples(new int[] { 0, 1, 2, 2, 3, 2, 4, 4, 1 });

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Short_Array_No_Triplet_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.NoTuples(new int[] { 1, 1 });

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Has_Triplet_Returns_False_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.NoTuples(new int[] { 0, 1, 2, 2, 2, 3, 4, 1 });

            Assert.AreEqual(false, result);
        }
    }
}
