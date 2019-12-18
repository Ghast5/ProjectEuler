
/// <summary>
/// The sum of the squares of the first ten natural numbers is,
/// 1^2 + 2^2 + ... + 10^2 = 385
/// The square of the sum of the first ten natural numbers is,
/// (1 + 2 + ... + 10)^2 = 55^2 = 3025
/// Hence the difference between the sum of the squares of the first ten natural numbers and
/// the square of the sum is 3025 − 385 = 2640.
/// Find the difference between the sum of the squares of the first one hundred natural numbers and
/// the square of the sum.
/// </summary>

using System.Linq;

public class Problem6
{
    public long DiffrenceOfSum(int n = 100) => Enumerable.Range(1, n).Sum() * Enumerable.Range(1, n).Sum() - Enumerable.Range(1, n).Sum(x => x * x);
}
