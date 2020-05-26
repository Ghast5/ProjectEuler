using System;
using System.Numerics;

namespace ProjectEuler
{
    public class Problem48
    {
        public BigInteger SelfPowers()
        {
            BigInteger sum = 0;

            for(int i = 1; i < 1001; i++)
                sum = BigInteger.Add(sum, BigInteger.Pow(i, i));

            return BigInteger.Remainder(sum, 10000000000);
        }
    }
}
