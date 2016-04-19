using System;
using System.Numerics;

namespace MasterBits
{
    public class Easyline
    {
        private static BigInteger F(BigInteger n)
        {
            if (n == 0) return 1;
            return n*F(n - 1);
        }

        private static BigInteger Binomial(BigInteger k, BigInteger n)
        {
            return F(n)/(F(n - k)*F(k));
        }

        public static BigInteger EasyLine(int n)
        {
            return Binomial(n, 2*n);
        }

        public static BigInteger EasyLine2(int n)
        {
            return F(2 * n) / BigInteger.Pow(F(n), 2);
        }

        public static BigInteger EasyLine3(int n)
        {
            BigInteger res = 0;
            for (int i = 0; i <= n; i++)
            {
                res += Binomial(i, n) * Binomial(i, n);
            }
            return res;
        }
    }
}
