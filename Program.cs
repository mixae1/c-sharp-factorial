using System.Numerics;
static BigInteger factorial(int _base)
{
    if (_base < 0) return 0;
    if (_base == 0 || _base == 1) return 1;
    return factorial(_base - 1) * _base;
}

System.Console.WriteLine(factorial(100));