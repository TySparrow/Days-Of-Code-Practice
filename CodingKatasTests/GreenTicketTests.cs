using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_Of_Code;

namespace CodingKatasTests
{
    [TestClass]
    public class GreenTicketTests
    {
        [TestMethod]
        public void All_Ints_Match_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int result = testObject.GreenTicket(5, 5, 5);

            Assert.AreEqual(20, result);
        }
        [TestMethod]
        public void No_Ints_Match_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int result = testObject.GreenTicket(1, 5, 20);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void A_and_C_Match_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int result = testObject.GreenTicket(20, 5, 20);

            Assert.AreEqual(10, result);
        }
        [TestMethod]
        public void A_and_B_Match_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int result = testObject.GreenTicket(5, 5, 20);

            Assert.AreEqual(10, result);
        }
    }
}
