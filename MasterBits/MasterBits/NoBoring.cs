#region ProblemInfo
// link : http://www.codewars.com/kata/570a6a46455d08ff8d001002
#endregion

using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterBits
{
    public class NoBoring
    {
        public static int NoBoringZeros(int n)
        {
            if (n == 0) return 0;
            List<char> myInt = n.ToString().Reverse().ToList();
            for (int i = 0; i < myInt.Count; )
            {
                if((int)char.GetNumericValue(myInt[i]) == 0)
                    myInt.RemoveAt(0);
                else break;
            }
            myInt.Reverse();
            int res = int.Parse(string.Join("", myInt.ToArray()));
            return res;
        }

        public static int NoMoreZeros(int n)
        {
            try
            {
                return Int32.Parse(n.ToString().TrimEnd('0'));
            }
            catch
            {
                return 0;
            }
        }
    }
}
