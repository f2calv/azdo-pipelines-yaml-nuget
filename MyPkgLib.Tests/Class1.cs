using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CasCap.Tests
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var obj = new TestClass1();
            var a = 1;
            var b = 2;
            var result = obj.Add(a, b);
            Assert.IsTrue(result == a + b);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var obj = new TestClass1();
            var hasFailed = false;
            try
            {
                obj.ThrowDivideByZeroException();
            }
            catch
            {
                hasFailed = true;
            }
            Assert.IsTrue(hasFailed);
        }
    }
}