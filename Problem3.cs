using System;

namespace ProjectEuler
{
    public class Problem3
    {
        public long LargestPrimeFactor()
        {
            long number = 600851475143;
            long largestFactor = 0;
            long[] factors = new long[2];

            for(long i = 2; i * i < number; i++)
            {
                if(number % i == 0)
                {
                    factors[0] = i;
                    factors[1] = number / i;

                    for(int j = 0; j < 2; j++)
                    {
                        bool isPrime = true;
                        for(long k = 2; k * k < factors[j]; k++)
                        {
                            if(factors[j] % k == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        if(isPrime && factors[j] > largestFactor)
                            largestFactor = factors[j];
                    }
                }
            }

            return largestFactor;
        }
    }
}
