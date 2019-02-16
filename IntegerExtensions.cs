using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                throw new NotImplementedException();
            }
            int gcd = 1;
            int min;
            if (Math.Abs(a) >= Math.Abs(b))
            {
                min = Math.Abs(b);
            }
            else
                min = Math.Abs(a);

            for (int i = 1; i <= min; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    gcd = i;
                }
            }
            return gcd;
        }
    }
}
