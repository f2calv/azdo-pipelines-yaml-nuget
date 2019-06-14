using System.Runtime.Serialization;
#if NET472
using System.Data.Entity;
using System.Configuration;
#else
using Microsoft.EntityFrameworkCore;
using System.Drawing;
#endif
namespace CasCap
{
    [DataContract]
    public class TestClass1
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public void ThrowDivideByZeroException()
        {
            var a = 10;
            var b = 0;
            var c = a / b;
        }
    }
}