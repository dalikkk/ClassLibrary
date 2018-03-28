using System;
using Xunit;
using Claslib;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Counting c = new Counting();
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                int a = rnd.Next();
                int b = rnd.Next();
                Assert.Equal(c.Add(a, b), a+b);
                Assert.Equal(c.Sub(a, b), a - b);
                Assert.Equal(c.Mul(a, b), a * b);
                Assert.Equal(c.Div(a, b), a / b);
            }
            
        }

        [Fact]
        public void Test2() => Assert.Equal(new Counting().Add(5, 5), 9);
    }
}
