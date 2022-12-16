using System.Numerics;

namespace TestFactorial
{
    public class Tests
    {
        [Test]
        public void TestNegative()
        {
            Assert.IsTrue(Stuff.factorial(-10) == 0);
            Assert.IsTrue(Stuff.factorial(-1) == 0);
            Assert.IsTrue(Stuff.factorial(-20) == 0);
            Assert.IsTrue(Stuff.factorial(-13) == 0);
        }

        [Test]
        public void TestZero()
        {
            Assert.IsTrue(Stuff.factorial(0) == 1);
        }

        [Test]
        public void TestPositive()
        {
            Assert.IsTrue(Stuff.factorial(1) == 1);
            Assert.IsTrue(Stuff.factorial(2) == 2);
            Assert.IsTrue(Stuff.factorial(3) == 6);
            Assert.IsTrue(Stuff.factorial(10) == 3628800);

        }
    }
}