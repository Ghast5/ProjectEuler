using System;

namespace ProjectEuler
{
    public class Problem7
    {
        public long NthPrime()
        {
            int number = 100_020_001;

            bool[] primes = new bool[number + 1];

            for (int i = 2; i <= number; i++)
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

            long position = 0;

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    position += 1;

                    if (position == 10_001)
                    {
                        return i;
                    }
                }
            }

            return position;
        }
    }
}
