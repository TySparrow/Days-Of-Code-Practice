using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_Of_Code;

namespace CodingKatasTests
{
    [TestClass]
    public class ArrayCount9Tests
    {
        [TestMethod]
        public void Array_Of_Nines_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int result = testObject.ArrayCount9(new int[] { 9, 9, 9 });

            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void No_Nines_Count_0_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int result = testObject.ArrayCount9(new int[] { 1, 2, 3 });

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void Empty_Array_Count_0_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int result = testObject.ArrayCount9(new int[] {});

            Assert.AreEqual(0, result);
        }
    }
}
