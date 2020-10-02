using Xunit;
namespace CasCap.Tests
{
    public class Class1
    {
        [Fact, Trait("Category", "Performance")]
        public void TestMethod1()
        {
            var obj = new TestClass1();
            var a = 1;
            var b = 2;
            var result = obj.Add(a, b);
            Assert.True(result == a + b);
        }

        [Fact, Trait("Category", "Performance")]
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
            Assert.True(hasFailed);
        }
    }
}