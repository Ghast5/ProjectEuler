
/// <summary>
/// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
/// What is the sum of the digits of the number 2^1000?
/// </summary>

using System;
using System.Numerics;

public class Problem16
{
    public BigInteger RaisingToPower() => (BigInteger) Math.Pow(2, 1000);

    public BigInteger AddinNumbers()
    {
        BigInteger number = RaisingToPower();
        string numberLength = number.ToString();
        BigInteger sum = 0;

        for(int i = 0; i < numberLength.Length; i++)
        {
            sum += number % 10;
            number /= 10;
        }
        

        return sum;
    }
}
