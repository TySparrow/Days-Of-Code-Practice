using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_Of_Code;

namespace CodingKatasTests
{
    [TestClass]
    public class Only14Tests
    {
        [TestMethod]
        public void Has1_and_4_Only_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.Only14(new int[] { 1, 4, 1, 1, 4, 1, 4 });

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Has_1_Only_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.Only14(new int[] { 1, 1, 1, 1, 1, 1, 1 });

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Only14_OtherInts_ReturnsFalse_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.Only14(new int[] { 2, 3, 5, 1, 4, 3, 1, 2 });

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Only14s_SmallArray_ReturnsFalse_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.Only14(new int[] {});

            Assert.AreEqual(false, result);
        }
    }
}
