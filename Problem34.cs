using System;
using System.Collections.Generic;
using System.IO;

namespace ProjectEuler
{
    public class ProjectEuler
    {
        public long Problem34()
        {
            long sum = 0;

            for(int i = 10; i < 362880; i++)
            {
                int number = i;
                int numLength = number.ToString().Length;
                long tempSum = 0;

                for (int j = 0; j < numLength; j++)
                {
                    tempSum += Factorial(number % 10);
                    number /= 10;
                }

                if(i == tempSum)
                    sum += i;
            }

            return sum;
        }

        public long Factorial(int num)
        {
            long result = 1;

            if (num == 0)
                return result;

            for(int i = num; i > 0; i--)
                result *= i;

            return result;
        }
    }
}
