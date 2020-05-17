using System;

namespace ProjectEuler
{
    public class Problem5
    {
        public int SmallestMultiple()
        {
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19 };
            int multi = 1;

            for(int i = 0; i < primes.Length; i++)
            {
                int res = primes[i];

                while(res < 20)
                {
                    res *= primes[i];
                }

                multi *= res / primes[i];
            }

            return multi;
        }
    }
}
