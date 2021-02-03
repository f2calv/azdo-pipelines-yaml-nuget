using System;
namespace CasCap
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new TestClass1();
            _ = obj.Add(1, 2);
            TestClass1.ThrowDivideByZeroException();

            Console.WriteLine($"Hello World @ {DateTime.UtcNow}");

            Console.ReadLine();
        }
    }
}