using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exam;

namespace TestQuestion3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PrimeFactorsOf100()
        {
            int value = 100;
            string actual = Question3.primeFactorss(value);

            string expected = "2 2 5 5";
            Assert.AreEqual(expected, actual);
        }
    }
}