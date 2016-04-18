#region ProblemInfo
// link : http://www.codewars.com/kata/all-inclusive
#endregion

using System;
using System.Collections.Generic;
using System.Linq;

namespace MySolution
{
    public class Rotations
    {
        public static IEnumerable<string> GetPemutations(string strng)
        {
            char[] arChar = strng.ToCharArray();
            int sz = arChar.Length;
            string[] result = new string[sz];
            for (int i = 0; i < arChar.Length; i++)
            {
                char[] res = new char[arChar.Length];
                for (int j = 0; j < arChar.Length; j++)
                {
                    res[j] = arChar[(i + j) % sz];
                }
                result[i] = new string(res);
            }
            return result.ToList();
        }

        public static Boolean ContainAllRots(string strng, List<string> arr)
        {
            if (strng == null || arr == null) throw new NullReferenceException();
            if (strng == "") return true;

            return !GetPemutations(strng).Except(arr).Any();
        }
    }
}
