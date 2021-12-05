using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersQuestions;

namespace GetNextNumberTest
{
    [TestClass]
    public class GetNextNumberTest
    {
        [TestMethod]
        public void IsLastDigitPromoted()
        {
            string value = "187";
            string actual = TragilRecursion.GetNextNumber(value);

            string expected = "188";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsLastDigitPromotedFor9()
        {
            string value = "189";
            string actual = TragilRecursion.GetNextNumber(value);

            string expected = "190";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsDigitPromotedInTheMiddle()
        {
            string value = "199";
            string actual = TragilRecursion.GetNextNumber(value);

            string expected = "200";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsStartOverCorrectly()
        {
            string value = "999";
            string actual = TragilRecursion.GetNextNumber(value);

            string expected = "000";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Is50digitsPromoted()
        {
            string value = "99999999996868999987686899998768689999876868";
            string actual = TragilRecursion.GetNextNumber(value);

            string expected = "99999999996868999987686899998768689999876869";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Is50digitsStartedOver()
        {
            string value = "99999999999999999999999999999999999999999999999999";
            string actual = TragilRecursion.GetNextNumber(value);

            string expected = "00000000000000000000000000000000000000000000000000";
            Assert.AreEqual(expected, actual);
        }

    }
}