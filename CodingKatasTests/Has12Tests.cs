using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_Of_Code;

namespace CodingKatasTests
{
    [TestClass]
    public class Has12Tests
    {
        [TestMethod]
        public void Has12_ReturnsTrue_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.Has12(new int[] { 4, 1, 3, 3, 2, 4 });

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Has1_Not2_ReturnsFalse_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.Has12(new int[] { 0, 1, 3, 3, 4 });

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ShortArray_ReturnsFalse_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.Has12(new int[] { 1 });

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Two_Before_One_ReturnsFalse_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.Has12(new int[] { 0, 2, 3, 1 });

            Assert.AreEqual(false, result);
        }
    }
}
