using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_Of_Code;

namespace CodingKatasTests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void Fibonacci_Sequence_Test()
        {
            CodingKatas testObject = new CodingKatas();

            int[] result = testObject.Fibonacci();

            CollectionAssert.AreEqual(ExpectedFibonacci(), result);

        }
        private int[] ExpectedFibonacci()
        {
            List<int> sequence = new List<int>();

            int first = 0;
            int second = 1;

            sequence.Add(first);
            sequence.Add(second);

            int next = first + second;

            while (next < 2000)
            {
                sequence.Add(next);
                first = second;
                second = next;
                next = first + second;
            }

            return sequence.ToArray();
        }
    }
}
