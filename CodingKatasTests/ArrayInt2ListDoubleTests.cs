using Days_Of_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodingKatasTests
{
    [TestClass]
    public class ArrayInt2ListDoubleTests
    {
        [TestMethod]
        public void ReturnHalves_EvenNums_Test()
        {
            CodingKatas testObject = new CodingKatas();

            List<double> result = testObject.ArrayInt2ListDouble(new int[] { 2, 4, 6, 8, 10 });

            CollectionAssert.AreEqual(new List<double> { 1.0, 2.0, 3.0, 4.0, 5.0 }, result);
            Assert.AreEqual(5, result.Count);
        }

        [TestMethod]
        public void ArratInt2ListDouble_Returns_All_Test()
        {
            CodingKatas testObject = new CodingKatas();

            List<double> result = testObject.ArrayInt2ListDouble(new int[] { 2, 4, 6, 8, 10 });

            Assert.AreEqual(5, result.Count);
        }
        [TestMethod]
        public void Array2Int_Decimal_Test_With_Zero()
        {
            CodingKatas testObject = new CodingKatas();

            List<double> result = testObject.ArrayInt2ListDouble(new int[] { 15, 23, 9, 44, 0, 123, 12345 });

            CollectionAssert.AreEqual(new List<double> { 7.5, 11.5, 4.5, 22, 0, 61.5, 6172.5 }, result);
        }
        [TestMethod]
        public void Array2Int_NegativeNums_Test()
        {
            CodingKatas testObject = new CodingKatas();

            List<double> result = testObject.ArrayInt2ListDouble(new int[] { -1, -4, -10, -4 });

            CollectionAssert.AreEqual(new List<double> { -0.5, -2, -5, -2 }, result);
        }
    }
}
