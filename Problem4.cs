using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class Problem4
    {
        public int Palindrome()
        {
            var palindromes = new List<int>();

            for(int i = 999; i > 101; i--)
            {
                for(int j = 999; j > 101; j--)
                {
                    int result = i * j;
                    string num = result.ToString();

                    if (num.Equals(ReverseString(num)))
                        palindromes.Add(result);    
                }
            }

            palindromes.Sort();

            return palindromes[0];
        }

        private string ReverseString(string res)
        {
                char[] nums = res.ToCharArray();
                Array.Reverse(nums);

                return new string(nums); 
        }
    }
}
