using Days_Of_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKatasTests
{
    [TestClass]
    public class ReturnMostTests
    {
        [TestMethod]
        public void MostChar_LettersOnly_Test()
        {
            CodingKatas testObject = new CodingKatas();

            char result = testObject.ReturnMost("Test String");

            Assert.AreEqual('t', result);
        }
        [TestMethod]
        public void MostChar_RepeatingLetters_Test()
        {
            CodingKatas testObject = new CodingKatas();

            char result = testObject.ReturnMost("HiHihihithere");

            Assert.AreEqual('h', result);
        }
        [TestMethod]
        public void MostChar_EmptyString_Test()
        {
            CodingKatas testObject = new CodingKatas();

            char result = testObject.ReturnMost("");

            Assert.AreEqual(' ', result);
        }
    }
}

