using Days_Of_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKatasTests
{
    [TestClass]
    public class DistinctValuesTests
    {
        [TestMethod]
        public void DistinctValues_DuplicatesRemoved_Test()
        {
            CodingKatas testObject = new CodingKatas();

            List<string> result = testObject.DistinctValues(new List<string> { "cat", "dog", "cat", "dog" });

            CollectionAssert.AreEqual(new List<string> { "cat", "dog" }, result);
        }
        [TestMethod]
        public void DistinctValues_WithEmptyList_Test()
        {
            CodingKatas testObject = new CodingKatas();

            List<string> result = testObject.DistinctValues(new List<string> { });

            CollectionAssert.AreEqual(new List<string> { }, result);
        }
        [TestMethod]
        public void DistinctValues_Prompt_DefaultTest()
        {
            CodingKatas testObject = new CodingKatas();

            List<string> result = testObject.DistinctValues(new List<string> { "jingle", "bells", "jingle", "bells", "jingle", "all", "the", "way" });

            CollectionAssert.AreEqual(new List<string> { "jingle", "bells", "all", "the", "way" }, result);

        }
    }
}
