using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_Of_Code;

namespace CodingKatasTests
{
    [TestClass]
    public class Start1Tests
    {
        [TestMethod]
        public void BothArrays_Start1_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int result = testObject.Start1(new int[] { 1, 2, 3 }, new int[] { 1, 4, 5 });

            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void OneArray_Start1_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int result = testObject.Start1(new int[] { 1, 2, 3 }, new int[] { 3, 4, 5 });

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Neither_Array_Start1_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int result = testObject.Start1(new int[] { 6, 2, 3 }, new int[] { 3, 4, 5 });

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void EmptyArrays_Start1_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int result = testObject.Start1(new int[] {}, new int[] {});

            Assert.AreEqual(0, result);
        }
    }
}
