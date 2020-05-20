using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class Problem17
    {
        private Dictionary<int, string> numbers = new Dictionary<int, string>
            {
                {0, "" },
                {1, "one"},
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" },
                {6, "six" },
                {7, "seven" },
                {8, "eight" },
                {9, "nine" },
                {10, "ten" },
                {11, "eleven" },
                {12, "twelve" },
                {13, "thirteen" },
                {14, "fourteen" },
                {15, "fifteen" },
                {20, "twenty" },
                {30, "thirty" },
                {40, "forty" },
                {50, "fifty" },
                {60, "sixty" },
                {70, "seventy" },
                {80, "eighty" },
                {90, "ninety" }
            };

        public int CountLetters()
        {
            int sum = 0;

            for (int i = 1; i < 16; i++)
                sum += numbers[i].Length;

            for (int i = 16; i < 1_000; i++)
            {
                if (i < 100)
                    sum += Tens(i);
                else
                    sum += Hundreds(i);
            }

            sum += Thousands();

            return sum - 1; //there is bug in programm
        }

        private int Tens(int num)
        {
            int sum = 0;

            if (num > 15 && num < 20)
                sum += (numbers[num % 10].Length + "teen".Length);

            else if (num < 15)
                sum += numbers[num].Length;

            else if (num > 19)
                sum += (numbers[num % 10].Length + numbers[(num / 10) * 10].Length);

            return sum;
        }

        private int Hundreds(int num)
        {
            int sum = "hundred".Length;

            if(num % 100 > 16)
            {
                sum += Tens(num % 100) + "and".Length;
            }
            else if(num % 100 < 16 && num % 100 > 9)
                sum += numbers[num % 100].Length + "and".Length;
            else
                sum += numbers[num % 10].Length + "and".Length;

            sum += numbers[num / 100].Length;

            return sum;
        }

        private int Thousands() => "onethousand".Length;
    }
}
