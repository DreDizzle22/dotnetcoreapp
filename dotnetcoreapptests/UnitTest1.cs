using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnetcoreapptests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Pass()
        {
            Assert.AreEqual(1,1);
        }
        [TestMethod]
        public void TestMethod_Fail()
        {
            Assert.IsTrue(false);
        }
    }
}
