using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var math = new GitUnitTestDemo.Math(5, 2);
            var math2 = new GitUnitTestDemo.Math(1234, 0);

            Assert.AreEqual(7, math.Add());
            Assert.AreEqual(3, math.Subtract());
            Assert.AreEqual(10, math.Multiply());
            Assert.AreEqual(2.5, math.Divide());
            Assert.IsTrue(math.Divide() < 2.51 && math.Divide() > 2.49);
            Assert.AreEqual(System.Single.PositiveInfinity, math2.Divide());
            Assert.AreEqual(10, math2.SumDigits());
            Assert.AreEqual("101", math.Binary());
        }
    }
}
