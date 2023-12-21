using Days_Of_Code;

namespace CodingKatasTests
{
    [TestClass]
    public class SwapEndsTests
    {
        [TestMethod]
        public void Array_FirstLast_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int[] result = testObject.SwapEnds(new int[] { 1, 2, 3 });

            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, result);
        }

        [TestMethod]
        public void Array_SwapEnds_LengthTwo_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int[] result = testObject.SwapEnds(new int[] { 5, 6});

            CollectionAssert.AreEqual(new int[] { 6, 5 }, result);
        }
    }
}