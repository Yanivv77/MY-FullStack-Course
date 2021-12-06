using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exam;

namespace TestQuestion4;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void PromotedSimple()
    {
        string value = "555";
        string actual = Question4.GetNextNumber(value);

        string expected = "556";
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Promotedlast9()
    {
        string value = "259";
        string actual = Question4.GetNextNumber(value);

        string expected = "260";
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Promotedlast10are9()
    {
        string value = "699";
        string actual = Question4.GetNextNumber(value);

        string expected = "700";
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IsDigitPromotedInTheMiddle()
    {
        string value = "99999";
        string actual = Question4.GetNextNumber(value);

        string expected = "100000";
        Assert.AreEqual(expected, actual);
    }
}