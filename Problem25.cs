
/// <summary>
/// What is the index of the first term in the Fibonacci sequence to contain 1000 digits?
/// </summary>

using System;
using System.Numerics;

public class Problem25
{
    public int Fibonacci()
    {
        BigInteger num1 = 1;
        BigInteger num2 = 1;
        BigInteger num3;
        int index = 2;

        while (true)
        {
            num3 = num1 + num2;
            num1 = num2;
            num2 = num3;
            index++;

            Console.WriteLine(num3);

            if (num3.ToString().Length == 3)
                return index;
        } 
    }
}
