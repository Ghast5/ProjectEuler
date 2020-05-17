using System;

namespace ProjectEuler
{
    public class Problem10
    {
        public long SummOfPrimes()
        {
            int number = 2_000_000;

            bool[] primes = new bool[number + 1];

            for(int i = 2; i <= number; i++)
                primes[i] = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (primes[i])
                {
                    int num = i * i;

                    while(num <= number)
                    {
                        primes[num] = false;
                        num += i;
                    }
                }
            }

            long sum = 0;

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i] == true)
                    sum += i;
            }

            return sum;
        }
    }
}
