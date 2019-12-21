
/// <summary>
/// n! means n × (n − 1) × ... × 3 × 2 × 
/// For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800
/// and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27
/// Find the sum of the digits in the number 100!
/// </summary>

using System.Numerics;

public class Problem20
{
    public int Factorial()
    {
        BigInteger factorial = 1;

        for(int i = 100; i > 0; i--)
            factorial *= i;

        int sum = 0;

        while(factorial > 0)
        {
            sum += (int) (factorial % 10);
            factorial /= 10;
        }

        return sum;
    }
}
