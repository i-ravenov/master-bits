using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MasterBits
{
    public class GridPath
    {
        private static BigInteger F(BigInteger n)
        {
            if (n == 0) return 1;
            return n * F(n - 1);
        }

        private static BigInteger Binomial(BigInteger k, BigInteger n)
        {
            return F(n) / (F(n - k) * F(k));
        }

        public static BigInteger NumberOfRoutes(int m, int n)
        {
            return Binomial(m, m + n);
        }

        public static BigInteger NumberOfRoutes2(int m, int n)
        {
            if (m == 0 || n == 0) return 1;
            if (m == 1 || n == 1) return Math.Max(m,n) + 1;
            return 2 + NumberOfRoutes(m - 1, n - 1) + NumberOfRoutes(m-2,n) +NumberOfRoutes(m,n-2);
        }
    }
}

