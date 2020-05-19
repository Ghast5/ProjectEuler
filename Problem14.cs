using System;

namespace ProjectEuler
{
    public class Problem14
    {
        public long LongestCollatz()
        {
            long chain = 0;
            long startingNumber = 0;
            long n; 
            long tempChain;

            for (int i = 14; i < 1_000_000; i++)
            {
                tempChain = 1;
                n = i;

                while (n != 1)
                {
                    if (n % 2 == 0)
                        n /= 2;
                    else
                        n = 3 * n + 1;

                    tempChain++;
                }

                if (tempChain > chain)
                {
                    chain = tempChain;
                    startingNumber = i;
                }
            }

            return startingNumber;
        }
    }
}
