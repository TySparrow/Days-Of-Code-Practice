using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_Of_Code;

namespace CodingKatasTests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void Factorial_PositiveExample_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int result = testObject.Factorial(4);

            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void FactorialOfZero_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int result = testObject.Factorial(0);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Factorial_NegativeNumber_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int negativeNumber = -5;

            Action action = new Action(FactorialAction);

            Assert.ThrowsException<ArgumentException>(action);

            //Local function to perform factorial calculator for 'action'
            void FactorialAction()
            {
                testObject.Factorial(negativeNumber);
            }
        }
    }
}
