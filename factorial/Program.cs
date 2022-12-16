using System.Numerics;

namespace stuff
{
    public class Stuff
    {
        public static BigInteger factorial(int _base)
        {
            if (_base < 0) return 0;
            if (_base == 0 || _base == 1) return 1;
            return factorial(_base - 1) * _base;
        }

    }

    public class Program
    {
        static void Main()
        {
            Console.WriteLine(Stuff.factorial(Convert.ToInt32(Console.ReadLine())));
        }
    }
}