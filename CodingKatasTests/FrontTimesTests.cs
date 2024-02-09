using Days_Of_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKatasTests
{
    [TestClass]
    public class FrontTimesTests
    {
        [TestMethod]
        public void Front_Times_String_Length_3()
        {
            CodingKatas testObject = new CodingKatas();

            string result = testObject.FrontTimes("Hey", 2);

            Assert.AreEqual("HeyHey", result);
        }

        [TestMethod]
        public void Front_Times_LongerString()
        {
            CodingKatas testObject = new CodingKatas();

            string result = testObject.FrontTimes("Test string", 5);

            Assert.AreEqual("TesTesTesTesTes", result);
        }
        [TestMethod]
        public void Front_Times_n_Equal_To_Zero()
        {
            CodingKatas testObject = new CodingKatas();

            string result = testObject.FrontTimes("Test string", 0);

            Assert.AreEqual("", result);
        }
        [TestMethod]
        public void Front_Times_Test_With_Spaces()
        {
            CodingKatas testObject = new CodingKatas();

            string result = testObject.FrontTimes("T e s t s t r i n g", 3);

            Assert.AreEqual("T eT eT e", result);
        }
    }
}
