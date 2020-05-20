using System;

namespace ProjectEuler
{
    public class Problem30
    {
        public int DigitFifthPower()
        {
            int result = 0;

            for(int i = 10; i < 355000; i++)
            {
                int sumOfPowers = 0;
                int number = i;

                while(number > 0)
                {
                    sumOfPowers += (int) Math.Pow(number % 10, 5);
                    number /= 10;
                }

                if(sumOfPowers == i)
                    result += sumOfPowers;
            }

            return result;
        }
    }
}
