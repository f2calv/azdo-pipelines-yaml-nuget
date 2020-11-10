using System.Runtime.Serialization;
using System.Drawing;
#if NET472
using System.Data.Entity;
using System.Configuration;
using System.Net.Http;
using System.Web;
#else
using Microsoft.EntityFrameworkCore;
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

        public static void ThrowDivideByZeroException()
        {
            var a = 10;
            var b = 0;
            var c = a / b;
        }
    }
#if NET5
    public record test(int id);
#endif
}