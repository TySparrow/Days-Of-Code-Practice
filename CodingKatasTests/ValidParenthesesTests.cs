using Days_Of_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKatasTests
{
//            Console.WriteLine("Expected: False, Actual: " + ValidParentheses("(((())"));
    [TestClass]
    public class ValidParenthesesTests
    {
        [TestMethod]
        public void Valid_Parentheses_Balanced()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.ValidParentheses("((Test)(String))");

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Invalid_Parentheses_Starts_With_Closing_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.ValidParentheses(")(()))");

            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Valid_Parentheses_Paren_Only()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.ValidParentheses("(())((()())())");

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Valid_Parentheses_Starts_With_Letter_and_Space()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.ValidParentheses(" 1(())((()()))()");

            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Imbalanced_Parentheses_Test()
        {
            CodingKatas testObject = new CodingKatas();

            bool result = testObject.ValidParentheses("(((())");

            Assert.AreEqual(false, result);
        }
    }
}
