using System;

namespace ProjectEuler
{
    public class Problem9
    {
        public int PythagoreanTriplet()
        {
            for(int a = 1; a < 1000 / 3; a++)
            {
                for(int b = a; b < 1000 / 2; b++)
                {
                    int c = 1000 - a - b;

                    if(a * a + b * b == c * c)
                        return a * b * c;
                }
            }

            return 1;
        }
    }
}
